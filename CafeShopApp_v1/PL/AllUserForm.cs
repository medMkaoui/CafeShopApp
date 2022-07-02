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
    public partial class AllUserForm : UserControl
    {
        BL.Cfe_shop_dbEntities Db = new BL.Cfe_shop_dbEntities();
        BL.GlobalMethods methods = new BL.GlobalMethods();
        public static AllUserForm UsersForm = new AllUserForm();
        public AllUserForm()
        {
            InitializeComponent();
            UsersForm = this;
            getUsers();
        }

        public void getUsers()
        {
            try
            {
                var Users = Db.get_all_users().ToList();
                lblCountClients.Text = Users.Count().ToString() +" Utilisateur(s)";
                plDgv.Controls.Clear();
                int i = 1;
                foreach (var User in Users)
                {
                    SubUserControle.UserRowUser row = new SubUserControle.UserRowUser();
                    row.lblN.Text = i.ToString();
                    row.lblId.Text = User.id_user.ToString();
                    row.lblName.Text = User.name_user;
                    row.lblEmail.Text = User.email;
                    row.lblTel.Text = User.tel;
                    row.txtPassword.Text = methods.Decrypte_Pass(User.mot_passe);
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
                var users = Db.get_users_by_str_search(txtSearch.Text);
                int i = 1;
                plDgv.Controls.Clear();
                foreach (var user in users)
                {
                    SubUserControle.UserRowUser row = new SubUserControle.UserRowUser();
                    row.lblN.Text = i.ToString();
                    row.lblId.Text = user.id_user.ToString();
                    row.lblName.Text = user.name_user;
                    row.lblEmail.Text = user.email;
                    row.lblTel.Text = user.tel;
                    row.txtPassword.Text = methods.Decrypte_Pass( user.mot_passe);
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
