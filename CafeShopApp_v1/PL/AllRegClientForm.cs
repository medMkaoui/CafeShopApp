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
    public partial class AllRegClientForm : UserControl
    {
        BL.Cfe_shop_dbEntities Db = new BL.Cfe_shop_dbEntities();
        BL.GlobalMethods methods = new BL.GlobalMethods();
        int idClient ;

        public AllRegClientForm(int id)
        {
            InitializeComponent();
            idClient = id;
            getReg();
        }
        public void getReg()
        {
            try
            {
                var Regs = Db.reglements.Where(ele=> ele.client == idClient).ToList();
                lblClient.Text =Db.clients.Find(idClient).name_client;
                plDgv.Controls.Clear();
                int i = 1;
                foreach (var item in Regs)
                {
                    SubUserControle.UserRowReg row = new SubUserControle.UserRowReg();
                    row.lblN.Text = i.ToString();
                    row.lblId.Text = item.id_reg.ToString();
                    row.lblName.Text = item.client1.name_client;
                    row.lblDateReg.Text = item.date_reg.Value.ToShortDateString();
                    row.lblMontant.Text = item.montant.ToString();
                    row.lblModePay.Text = item.mode_payment;
                    plDgv.Controls.Add(row);
                    i++;
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewUserForm newUser = new NewUserForm();
            mainForm.MainForm.plYield.Controls.Clear();
            mainForm.MainForm.plYield.Controls.Add(newUser);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var Regs = Db.get_reg_client_by_str_search(txtSearch.Text, idClient).ToList();
                lblClient.Text = Db.clients.Find(idClient).name_client;
                plDgv.Controls.Clear();
                int i = 1;
                foreach (var item in Regs)
                {
                    SubUserControle.UserRowReg row = new SubUserControle.UserRowReg();
                    row.lblN.Text = i.ToString();
                    row.lblId.Text = item.id_reg.ToString();
                    row.lblName.Text = Db.clients.Find(idClient).name_client;
                    row.lblDateReg.Text = item.date_reg.Value.ToShortDateString();
                    row.lblMontant.Text = item.montant.ToString();
                    row.lblModePay.Text = item.mode_payment;
                    plDgv.Controls.Add(row);
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
