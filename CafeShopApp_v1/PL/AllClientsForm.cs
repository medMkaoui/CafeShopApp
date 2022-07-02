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
    public partial class AllClientsForm : UserControl
    {
        BL.Cfe_shop_dbEntities Db = new BL.Cfe_shop_dbEntities();
        BL.GlobalMethods methods = new BL.GlobalMethods();
        public static AllClientsForm ClientsForm = new AllClientsForm();

        public AllClientsForm()
        {
            InitializeComponent();
            getClients();
            ClientsForm = this;
        }

        public void getClients()
        {
            try
            {
                var clients = Db.get_all_clients().ToList();
                lblCountClients.Text = clients.Count().ToString() + " Cients(s)";
                plDgv.Controls.Clear();
                int i = 1;
                foreach (var client in clients)
                {
                    SubUserControle.UserRowClients row = new SubUserControle.UserRowClients();
                    row.lblN.Text = i.ToString();
                    row.lblId.Text = client.id_client.ToString();
                    row.lblName.Text = client.name_client;
                    row.lblEmail.Text = client.email;
                    row.lblTel.Text = client.tel;
                    row.lblMaxCredit.Text =client.max_credit.ToString();
                    row.lblTotalCredit.Text = client.total_credit.ToString();
                    if (client.total_credit == null) row.lblTotalCredit.Text = "00.00";

                    if (client.total_credit >= client.max_credit)
                    {
                        row.btnDelete.BackColor = Color.White;
                        row.BackColor = Color.FromArgb(245, 183, 177);
                    }
                    plDgv.Controls.Add(row);
                    i++;
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewClientForm clientForm = new NewClientForm();
            clientForm.lblNClients.Text = " Client N° : " + (Db.clients.Count()+1); 
            mainForm.MainForm.plYield.Controls.Clear();
            mainForm.MainForm.plYield.Controls.Add(clientForm);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var clients = Db.get_clients_by_str_search(txtSearch.Text);
                int i = 1;
                plDgv.Controls.Clear();
                foreach (var client in clients)
                {
                    SubUserControle.UserRowClients row = new SubUserControle.UserRowClients();
                    row.lblN.Text = i.ToString();
                    row.lblId.Text = client.id_client.ToString();
                    row.lblName.Text = client.name_client;
                    row.lblEmail.Text = client.email;
                    row.lblTel.Text = client.tel;
                    row.lblMaxCredit.Text =client.max_credit.ToString() ;
                    row.lblTotalCredit.Text =client.total_credit.ToString() ;
                    if (client.total_credit >= client.max_credit)
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
