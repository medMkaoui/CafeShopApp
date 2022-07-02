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
    public partial class AllFournisseursForm : UserControl
    {
        BL.Cfe_shop_dbEntities Db = new BL.Cfe_shop_dbEntities();
        BL.GlobalMethods methods = new BL.GlobalMethods();

        public static AllFournisseursForm FournissuerForm = new AllFournisseursForm();
        public AllFournisseursForm()
        {
            InitializeComponent();
            FournissuerForm = this;
            getFournissuers();
        }

        public void getFournissuers()
        {
            try
            {
                var fournisseurs = Db.get_all_fournisseurs().ToList();
                lblCountFournissuers.Text = fournisseurs.Count().ToString() + " Fournisseurs(s)";
                plDgv.Controls.Clear();
                int i = 1;
                foreach (var fournissuer in fournisseurs)
                {
                    SubUserControle.UserRowFournisseurs row = new SubUserControle.UserRowFournisseurs();
                    row.lblN.Text = i.ToString();
                    row.lblId.Text = fournissuer.id_fournisseur.ToString();
                    row.lblName.Text = fournissuer.name_fournisseur;
                    row.lblEmail.Text = fournissuer.email;
                    row.lblTel.Text = fournissuer.tel;
                    row.lblMaxCredit.Text = fournissuer.max_credit.ToString();
                    row.lblTotalCredit.Text = fournissuer.total_credit.ToString();
                    if (fournissuer.total_credit >= fournissuer.max_credit)
                    {
                        row.btnDelete.BackColor = Color.White;
                        row.BackColor = Color.FromArgb(235, 95, 63);
                    }
                    plDgv.Controls.Add(row);
                    i++;
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewFournisseurForm fournisseurForm = new NewFournisseurForm();
            fournisseurForm.lblNClients.Text = " Fournissuer N° : " + (Db.fournisseurs.Count() + 1);
            mainForm.MainForm.plYield.Controls.Clear();
            mainForm.MainForm.plYield.Controls.Add(fournisseurForm);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var fournisseurs = Db.get_fournisseurs_by_str_search(txtSearch.Text);
                int i = 1;
                plDgv.Controls.Clear();
                foreach (var fournissuer in fournisseurs)
                {
                    SubUserControle.UserRowFournisseurs row = new SubUserControle.UserRowFournisseurs();
                    row.lblN.Text = i.ToString();
                    row.lblId.Text = fournissuer.id_fournisseur.ToString();
                    row.lblName.Text = fournissuer.name_fournisseur;
                    row.lblEmail.Text = fournissuer.email;
                    row.lblTel.Text = fournissuer.tel;
                    row.lblMaxCredit.Text = fournissuer.max_credit.ToString();
                    row.lblTotalCredit.Text = fournissuer.total_credit.ToString();
                    if (fournissuer.total_credit >= fournissuer.max_credit)
                    {
                        row.btnDelete.BackColor = Color.White;
                        row.BackColor = Color.FromArgb(235, 95, 63);
                    }
                    plDgv.Controls.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
