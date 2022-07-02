using CafeShopApp_v1.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeShopApp_v1.PL.SubUserControle.PlCaisse
{
    public partial class UserRowAttendCmd : UserControl
    {
        public static PlCaisse.UserPlCmd userPlCmd = new PlCaisse.UserPlCmd();
        BL.Cfe_shop_dbEntities Db = new BL.Cfe_shop_dbEntities();
        BL.GlobalMethods methods = new BL.GlobalMethods();

        public UserRowAttendCmd()
        {
            InitializeComponent();
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            int idcmd = int.Parse(lblId.Text);
            List<BL.commande_details> DetailCmd = Db.commande_details.Where(ele => ele.cmd == idcmd ).ToList();
            CaisseForm.caisseForm.lblCountCmd.Text = "Commande N° : 0" + lblId.Text;
            UserPlCmd.userPl.plCmdRows.Controls.Clear();
            CaisseForm.caisseForm.btnCaisse.PerformClick();
            CaisseForm.caisseForm.plContentCommandeRows.Controls.Add(userPlCmd);
            CaisseForm.caisseForm.plContent.Enabled = true;
            CaisseForm.caisseForm.ddClient.Enabled = true;
            CaisseForm.caisseForm.btnNouveu.Enabled = false;
            CaisseForm.caisseForm.lblId.Text = lblId.Text;
            CaisseForm.caisseForm.txtTypeCmd.Text = lblType.Text;
            CaisseForm.caisseForm.txtTypeCmd.Enabled = true;

            foreach (BL.commande_details item in DetailCmd)
            {
                UserRowProduitCmd Row = new UserRowProduitCmd();
                Row.lblTitleProd.Text = Db.produits.Find(item.produit).name_produit;
                Row.lblQteCmd.Text = item.qte_prod.ToString();
                Row.lblId.Text = item.produit.ToString();

                Row.imgProd.Image = methods.ConvertByteToImg(Db.produits.Find(item.produit).image_produit);
                UserPlCmd.userPl.plCmdRows.Controls.Add(Row);

                string note = item.note;

                if(note != null)
                {
                    string[] notes = note.Split('|');

                    foreach (string n in notes)
                    {
                        UserNote not = new UserNote(n);
                        Row.plUserNote.Controls.Add(not);
                        if (Row.Height == 65) Row.Height += 18;
                        Row.Height += 20;
                        if (Row.Height == 180) Row.Height = 180;
                    }
                }
            }
            AttendCmd.attend_cmd.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(lblId.Text);
            List<commande_details> cmdDetails = Db.commande_details.Where(ele=> ele.cmd == id).ToList();
            Db.commande_details.RemoveRange(cmdDetails);
            Db.commandes.Remove(Db.commandes.Find(id));
            Db.SaveChanges();

            AttendCmd.attend_cmd.getAttendCmd();
           
        }
    }
}
