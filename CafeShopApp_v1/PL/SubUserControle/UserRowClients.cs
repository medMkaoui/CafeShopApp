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
    public partial class UserRowClients : UserControl
    {
        BL.Cfe_shop_dbEntities Db = new BL.Cfe_shop_dbEntities();
        BL.GlobalMethods globalMethods = new BL.GlobalMethods();
        public static UserRowClients ClientRow = new UserRowClients(); 
        
        public UserRowClients()
        {
            InitializeComponent();
            ClientRow = this;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Êtes-vous sûr de vouloir supprimer?.", "Message de confirmation ? ", MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Information);

            if (dr == DialogResult.Yes  )
            {
                var client = Db.clients.Find(int.Parse(lblId.Text));
                if(client.total_credit == 0 || client.total_credit == null) 
                { 
                    Db.clients.Remove(client);
                    globalMethods.SaveData(Db);
                    AllClientsForm.ClientsForm.getClients();
                }
                else
                {
                    MessageBox.Show("Total credit de ce client est : "+client.total_credit+ "MAD, \n ne peut pas être supprimé.", "Message de confirmation ? ", MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                }
            }    
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            NewClientForm newClient = new NewClientForm(int.Parse(lblId.Text));
            mainForm.MainForm.plYield.Controls.Clear();
            mainForm.MainForm.plYield.Controls.Add(newClient);
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            AllCreditClientForm allCreditClient = new AllCreditClientForm(int.Parse(lblId.Text));
            mainForm.MainForm.plYield.Controls.Clear();
            mainForm.MainForm.plYield.Controls.Add(allCreditClient);
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            AllRegClientForm allCreditClient = new AllRegClientForm(int.Parse(lblId.Text));
            mainForm.MainForm.plYield.Controls.Clear();
            mainForm.MainForm.plYield.Controls.Add(allCreditClient);
        }
    }
}
