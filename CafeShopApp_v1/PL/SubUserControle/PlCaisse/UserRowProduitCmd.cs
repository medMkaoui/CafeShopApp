using CafeShopApp_v1.PL.PopUps.PopUpsCaisse;
using CafeShopApp_v1.PL.SubUserControle.PlCaisse;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeShopApp_v1.PL.SubUserControle
{
    public partial class UserRowProduitCmd : UserControl
    {
        BL.Cfe_shop_dbEntities Db = new BL.Cfe_shop_dbEntities();
       public static UserRowProduitCmd produitCmd = new UserRowProduitCmd();
        public UserRowProduitCmd()
        {
            InitializeComponent();
            produitCmd = this;

        }

        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.lblId.Text);
            int idCmd = int.Parse(CaisseForm.caisseForm.lblId.Text);
            BL.commande_details Cd = Db.commande_details.Find(idCmd, id);
            if (Cd != null)
            {
                Db.commande_details.Remove(Cd);
                Db.commande_details_annuler.Add(new BL.commande_details_annuler() {cmd = Cd.cmd, produit = Cd.produit, note=Cd.note, prix_vente= Cd.prix_vente,qte_prod= Cd.qte_prod });
            }
            UserPlCmd.userPl.plCmdRows.Controls.Remove(this);
            Db.SaveChanges();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int idProd = int.Parse(lblId.Text);
            NotePupUp notePupUp = new PopUps.PopUpsCaisse.NotePupUp(idProd, this);

            notePupUp.ShowDialog();
        }
    }
}
