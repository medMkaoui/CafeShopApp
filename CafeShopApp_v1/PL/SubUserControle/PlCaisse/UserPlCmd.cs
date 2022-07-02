using CafeShopApp_v1.PL.PopUps.PopUpsCaisse;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeShopApp_v1.PL.SubUserControle.PlCaisse
{
    public partial class UserPlCmd : UserControl
    {
        BL.Cfe_shop_dbEntities Db = new BL.Cfe_shop_dbEntities();
        Point p;
        public static UserPlCmd userPl = new UserPlCmd(); 
        public UserPlCmd()
        {
            InitializeComponent();
            userPl = this;
        }

        public void plCmdRows_ControlAdded(object sender, ControlEventArgs e)
        {
            CaculateMontant(e);
        }

        public void CaculateMontant(ControlEventArgs e)
        {
            UserRowProduitCmd item = (UserRowProduitCmd)e.Control;
            var prod = Db.produits.Find(int.Parse(item.lblId.Text));
            Decimal montant = decimal.Parse(lblMontantTotal.Text);
            int qte = int.Parse(item.lblQteCmd.Text);

            if (prod != null)
            {
                Decimal prix = (decimal)prod.prix_jour;
                montant += (qte * prix);
            }

            lblMontantTotal.Text = montant.ToString();
        }

        public void plCmdRows_ControlRemoved(object sender, ControlEventArgs e)
        {
            UserRowProduitCmd item = (UserRowProduitCmd)e.Control;
            var prod = Db.produits.Find(int.Parse(item.lblId.Text));
            Decimal montant = decimal.Parse(lblMontantTotal.Text);
            int qte = int.Parse(item.lblQteCmd.Text);

            if (prod != null)
            {
                Decimal prix = (decimal)prod.prix_jour;
                montant -= (qte * prix);
            }

            lblMontantTotal.Text = montant.ToString();
        }

        private void btnEnAttend_Click(object sender, EventArgs e)
        {
            plCmdRows.Controls.Clear();
            
            CaisseForm.caisseForm.lblCountCmd.Text ="Commande N° : -----";
            CaisseForm.caisseForm.txtTypeCmd.Enabled = false;
            CaisseForm.caisseForm.btnNouveu.Enabled = true;
            CaisseForm.caisseForm.plContent.Enabled = false;
            CaisseForm.caisseForm.ddClient.Enabled = false;
        }

        

        private void btnEnvoyerCuisine_Click(object sender, EventArgs e)
        {
            if (plCmdRows.Controls.Count != 0)
            {
                foreach(Control ele in plCmdRows.Controls)
                {
                    UserRowProduitCmd item = (UserRowProduitCmd)ele;
                    BL.commande_details CmdDetails = new BL.commande_details();
                    CmdDetails.produit = int.Parse(item.lblId.Text);
                    CmdDetails.qte_prod = int.Parse(item.lblQteCmd.Text);
                    CmdDetails.prix_vente = Db.produits.Find(int.Parse(item.lblId.Text)).prix_jour;
                    CmdDetails.cmd = int.Parse(CaisseForm.caisseForm.lblId.Text);
                    if(item.Height != 65) 
                    {
                        string note="";
                        int i = 0;
                        foreach(Control ite in item.plUserNote.Controls)
                        {
                            UserNote user = (UserNote)ite;
                            if(i==0) note = note + user.lblNameNote.Text; else note = note +" | "+ user.lblNameNote.Text;
                            i++;
                        }
                        CmdDetails.note = note;
                    }
                    Db.commande_details.AddOrUpdate(CmdDetails);
                    Db.commandes.Find(CmdDetails.cmd).statu= "preparation";
                    Db.SaveChanges();
                }
            }
        }

        private void btnPayer_Click(object sender, EventArgs e)
        {
            PayementPopUp popUp;
            if (CaisseForm.caisseForm.ddClient.SelectedValue != null) popUp= new PayementPopUp(decimal.Parse(lblMontantTotal.Text),(int)CaisseForm.caisseForm.ddClient.SelectedValue);
            else popUp = new PayementPopUp(decimal.Parse(lblMontantTotal.Text));
            p.Y = 130;
            popUp.Location = p;
            popUp.ShowDialog();
        }
    }
}
