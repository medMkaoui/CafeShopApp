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
    public partial class UserRowUser : UserControl
    {
        BL.Cfe_shop_dbEntities Db = new BL.Cfe_shop_dbEntities();
        BL.GlobalMethods methods = new BL.GlobalMethods();
        public static UserRowUser userRow = new UserRowUser();
        public UserRowUser()
        {
            InitializeComponent();
            userRow = this;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Êtes-vous sûr de vouloir supprimer?.", "Message de confirmation ? ", MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                var user = Db.users.Find(int.Parse(lblId.Text));
                Db.users.Remove(user);
                Db.SaveChanges();
                MessageBox.Show("Bien Supprimer");
                AllUserForm.UsersForm.getUsers();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            NewUserForm newUser = new NewUserForm(int.Parse(lblId.Text));
            mainForm.MainForm.plYield.Controls.Clear();
            mainForm.MainForm.plYield.Controls.Add(newUser);
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
                txtPassword.TextMarginTop = 2;
            }
            else { txtPassword.PasswordChar = '*'; txtPassword.TextMarginTop = 4; }
        }

        private void btnPriviliges_Click(object sender, EventArgs e)
        {
            UserPreviliges URUser = new UserPreviliges(/*int.Parse(lblId.Text)*/ 1);
            mainForm.MainForm.plYield.Controls.Clear();
            mainForm.MainForm.plYield.Controls.Add(URUser);
        }
    }
}
