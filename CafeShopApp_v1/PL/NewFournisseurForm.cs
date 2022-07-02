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

namespace CafeShopApp_v1.PL
{
    public partial class NewFournisseurForm : UserControl
    {
        BL.Cfe_shop_dbEntities Db = new BL.Cfe_shop_dbEntities();
        BL.GlobalMethods methods = new BL.GlobalMethods();
        public int IdFournisseur;
        public NewFournisseurForm(int id_fournisseur = -1)
        {
            InitializeComponent();
            getFournisseurById(id_fournisseur);
        }

        public void getFournisseurById(int id)
        {
            BL.fournisseur fournisseur = Db.fournisseurs.Find(id);
            if (fournisseur != null)
            {
                IdFournisseur = fournisseur.id_fournisseur;
                btnAjouter.Text = "Modifier";
                lblTitle.Text = "MODIFIER FOURNISSEUR";
                lblNClients.Text = "Fournisseur : " + fournisseur.name_fournisseur;
                txtName.Text = fournisseur.name_fournisseur;
                txtEmail.Text = fournisseur.email;
                txtMaxCredit.Text = fournisseur.max_credit.ToString();
                txtTel.Text = fournisseur.tel;
                txtdresse.Text = fournisseur.adresse;
            }

        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "" && txtMaxCredit.Text.Trim() == "" && txtTel.Text.Trim() == "" && txtdresse.Text.Trim() == "")
            {
                MessageBox.Show("Nom et Mote de Passe champ obligatoire", "Validation des information");
            }
            else
            {
                BL.fournisseur Fournisseur = Db.fournisseurs.Find(IdFournisseur);
                if (Fournisseur == null) Fournisseur = new BL.fournisseur();

                Fournisseur.name_fournisseur = txtName.Text;
                Fournisseur.max_credit = Convert.ToDecimal(txtMaxCredit.Text);
                Fournisseur.tel = txtTel.Text;
                Fournisseur.email = txtEmail.Text;
                Fournisseur.adresse = txtdresse.Text;

                Db.fournisseurs.AddOrUpdate(Fournisseur);
                methods.SaveData(Db);
                getFournisseurById(IdFournisseur);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            methods.ControlsEmpty(mainPanel);
            IdFournisseur = -1;
            btnAjouter.Text = "Ajouter";
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            AllFournisseursForm fournisseurForm = new AllFournisseursForm();
            mainForm.MainForm.plYield.Controls.Clear();
            mainForm.MainForm.plYield.Controls.Add(fournisseurForm);
        }

        private void txtMaxCredit_TextChanged(object sender, EventArgs e)
        {
            if (!(txtMaxCredit.Text == string.Empty))
            {
                if (!decimal.TryParse(txtMaxCredit.Text, out decimal x))
                {
                    MessageBox.Show("Veuillez n'entrer que des chiffres.");
                    txtMaxCredit.Text = string.Empty;
                }
            }
        }
    }
}
