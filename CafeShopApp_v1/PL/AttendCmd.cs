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
    public partial class AttendCmd : Form
    {
        BL.Cfe_shop_dbEntities Db = new BL.Cfe_shop_dbEntities();
        BL.GlobalMethods methods = new BL.GlobalMethods();
        public static AttendCmd attend_cmd = new AttendCmd();
        public AttendCmd()
        {
            InitializeComponent();
            getAttendCmd();
            attend_cmd = this;
        }

        public void getAttendCmd()
        {
            try
            {
                var Cmds = Db.get_all_attend_cmd().ToList();
                lblCountCmd.Text = Cmds.Count().ToString() + " Commande(s)";
                plDgv.Controls.Clear();
                int i = 1;
                foreach (var item in Cmds)
                {  
                    SubUserControle.PlCaisse.UserRowAttendCmd row = new SubUserControle.PlCaisse.UserRowAttendCmd();
                    if (item.statu != "non-Payé"){ row.BackColor = Color.FromArgb(245, 183, 177); row.btnDelete.Enabled = false; }
                    row.lblN.Text = i.ToString();
                    row.lblId.Text = item.id_cmd.ToString();
                    row.lblType.Text = item.type_cmd;
                    row.lblTb.Text = "--------";
                    if (item.t_able != null) row.lblTb.Text = item.t_able;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
    }
}
