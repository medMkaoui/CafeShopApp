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
    public partial class AllCreditClientForm : UserControl
    {
        BL.Cfe_shop_dbEntities Db = new BL.Cfe_shop_dbEntities();
        BL.GlobalMethods methods = new BL.GlobalMethods();
        int id = 0;
        public AllCreditClientForm(int idClient)
        {
            InitializeComponent();
            id = idClient;
            getCmd();
        }

        public void getCmd()
        {
            try
            {
                var Cmds = Db.commandes.Where(ele => ele.client == id).ToList();
                lblClient.Text = Db.clients.Find(id).name_client;
                plDgv.Controls.Clear();
                int i = 1;
                foreach (var item in Cmds)
                {
                    SubUserControle.UserRowCmd row = new SubUserControle.UserRowCmd();
                    row.lblN.Text = i.ToString();
                    row.lblId.Text = item.id_cmd.ToString();
                    row.lblDate.Text = item.date_cmd.Value.ToString("dd/mm/yyyy");
                    row.lblTb.Text = item.type_cmd;
                    row.lblNTb.Text = "--------";
                    if (item.t_able != null) row.lblNTb.Text = item.t_able;
                    row.lblClient.Text = "Particulier";
                    if (item.client != null) row.lblClient.Text = Db.clients.Find(item.client).name_client;
                    if (item.responsable != null) row.lblTResponsable.Text = Db.users.Find(item.responsable).name_user;
                    row.lblMontant.Text = item.montant_total.ToString();

                    plDgv.Controls.Add(row);
                    i++;
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var Cmds = Db.get_credit_client_by_str_search(txtSearch.Text, id).ToList();
                lblClient.Text = Db.clients.Find(id).name_client;
                plDgv.Controls.Clear();
                int i = 1;
                foreach (var item in Cmds)
                {
                    SubUserControle.UserRowCmd row = new SubUserControle.UserRowCmd();
                    row.lblN.Text = i.ToString();
                    row.lblId.Text = item.id_cmd.ToString();
                    row.lblDate.Text = item.date_cmd.Value.ToString("dd/mm/yyyy");
                    row.lblTb.Text = item.type_cmd;
                    row.lblNTb.Text = "--------";
                    if (item.t_able != null) row.lblNTb.Text = item.t_able;
                    row.lblClient.Text = "Particulier";
                    if (item.client != null) row.lblClient.Text = Db.clients.Find(item.client).name_client;
                    if (item.responsable != null) row.lblTResponsable.Text = Db.users.Find(item.responsable).name_user;
                    row.lblMontant.Text = item.montant_total.ToString();

                    plDgv.Controls.Add(row);
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            }
        }
    }
}
