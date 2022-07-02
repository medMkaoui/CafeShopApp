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
    public partial class NewClientForm : UserControl
    {
        BL.Cfe_shop_dbEntities Db = new BL.Cfe_shop_dbEntities();
        BL.GlobalMethods methods = new BL.GlobalMethods();
        public int Idclient;
        public NewClientForm(int id_client=-1)
        {
            InitializeComponent();
            getClientById(id_client);
        }

        public void getClientById(int id)
        {
            BL.client client = Db.clients.Find(id);
            if (client != null)
            {
                Idclient = client.id_client;
                btnAjouter.Text = "Modifier";
                lblTitle.Text = "MODIFIER CLIENT";
                lblNClients.Text = "Client : " + client.name_client;
                txtName.Text = client.name_client;
                txtEmail.Text = client.email;
                txtMaxCredit.Text = client.max_credit.ToString();
                txtTel.Text = client.tel;
                txtdresse.Text = client.adresse;
            }

        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "" && txtMaxCredit.Text.Trim() == "" && txtTel.Text.Trim() == "" && txtdresse.Text.Trim() == "")
            {
                MessageBox.Show("Nom et max credit et Téléphone et email champ obligatoire", "Validation des information");
            }
            else
            {
                BL.client Client = Db.clients.Find(Idclient);
                if (Client == null) { Client = new BL.client();
                    Client.total_credit = 0;
                }

                Client.name_client = txtName.Text;
                Client.max_credit = Convert.ToDecimal(txtMaxCredit.Text);
                Client.tel = txtTel.Text;
                Client.email = txtEmail.Text;
                Client.adresse = txtdresse.Text;

                Db.clients.AddOrUpdate(Client);
                methods.SaveData(Db);
                getClientById(Idclient);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            methods.ControlsEmpty(mainPanel);
            Idclient = -1;
            btnAjouter.Text = "Ajouter";
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            AllClientsForm clientForm = new AllClientsForm();
            mainForm.MainForm.plYield.Controls.Clear();
            mainForm.MainForm.plYield.Controls.Add(clientForm);
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
