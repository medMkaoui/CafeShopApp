using CafeShopApp_v1.PL.SubUserControle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeShopApp_v1.PL
{
    public partial class AllDetailsCmdForm : UserControl
    {
        BL.Cfe_shop_dbEntities Db = new BL.Cfe_shop_dbEntities();
        int idCmd;
        public AllDetailsCmdForm(int id)
        {
            InitializeComponent();
            idCmd = id;
            getDetails();
            
        }

        void getDetails()
        {
            List<BL.commande_details> DetailCmd = Db.commande_details.Where(ele => ele.cmd == idCmd).ToList();
            List<BL.commande_details_annuler> DetailCmdAnnuler = Db.commande_details_annuler.Where(ele => ele.cmd == idCmd).ToList();
           
            lblCountFournissuers.Text = "Commande N°" + "";
           
            int i = 1;
            foreach (BL.commande_details cmd in DetailCmd)
            {
                UserDetailsCmdRow row = new UserDetailsCmdRow();
                row.lblN.Text = i.ToString();
                row.lblDate.Text = cmd.commande.date_cmd.Value.ToString("dd/mm/yyyy");
                row.lblId.Text = cmd.cmd.ToString() + "/" + cmd.produit.ToString();
                row.lblName.Text = cmd.produit1.name_produit;
                row.lblNote.Text = cmd.note;
                row.lblPu.Text = cmd.prix_vente.ToString();
                row.lblQte.Text = cmd.qte_prod.ToString();

                plDgv.Controls.Add(row);
            }
            foreach (BL.commande_details_annuler cmd in DetailCmdAnnuler)
            {
                UserDetailsCmdRow row = new UserDetailsCmdRow();
                row.BackColor = Color.FromArgb(245, 183, 177);
                row.lblN.Text = i.ToString();
                row.lblDate.Text = cmd.commande.date_cmd.Value.ToString("dd/mm/yyyy");
                row.lblId.Text = cmd.cmd.ToString() + "/" + cmd.produit.ToString();
                row.lblName.Text = cmd.produit1.name_produit;
                row.lblNote.Text = cmd.note;
                row.lblPu.Text = cmd.prix_vente.ToString();
                row.lblQte.Text = cmd.qte_prod.ToString();

                plDgv.Controls.Add(row);
            }
               
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            int id = (int)Db.commandes.Find(idCmd).client;
            AllCreditClientForm allCreditClient = new AllCreditClientForm(id);
            mainForm.MainForm.plYield.Controls.Clear();
            mainForm.MainForm.plYield.Controls.Add(allCreditClient);
        }
    }
}
