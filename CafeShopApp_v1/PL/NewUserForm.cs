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
    public partial class NewUserForm : UserControl
    {
        BL.Cfe_shop_dbEntities Db = new BL.Cfe_shop_dbEntities();
        BL.GlobalMethods methods = new BL.GlobalMethods();
        PL.DesignCode.Methods DesignMethods = new DesignCode.Methods();
        public int IdUser;
        bool difirent_reteur;
        public NewUserForm(int idUser = -1,bool dfrt_reteur = false)
        {
            InitializeComponent();
            lblNClients.Text = "Client N° : 0"+(Db.users.Count() + 1);
            getUserById(idUser);
            difirent_reteur = dfrt_reteur;
        }

        public void getUserById(int id)
        {
            BL.user User = Db.users.Find(id);
            if (User != null)
            {
               IdUser = User.id_user;
               btnAjouter.Text = "Modifier";
               lblTitle.Text = "MODIFIER CLIENT";
               lblNClients.Text = "Client : "+ User.name_user;
               txtName.Text = User.name_user;
               txtEmail.Text = User.email;
               txtPassword.Text = methods.Decrypte_Pass(User.mot_passe);
               txtTel.Text = User.tel;
               txtdresse.Text = User.adresse;
            }

        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (difirent_reteur)
            {
                NewChargeForm.NewCharge.Show();
                NewChargeForm.NewCharge.FillDdResponsble();
                mainForm.MainForm.plYield.Controls.Remove(this);
            }
            else
            {
              AllUserForm AllUser = new AllUserForm();
              mainForm.MainForm.plYield.Controls.Clear();
              mainForm.MainForm.plYield.Controls.Add(AllUser);
            }

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "" && txtPassword.Text.Trim()=="")
            {
                MessageBox.Show("Nom et Mote de Passe champ obligatoire", "Validation des information");
            }
            else
            {
                BL.user User = Db.users.Find(IdUser);
                if (User == null) User = new BL.user();

                User.name_user = txtName.Text;
                User.mot_passe = methods.Encrypte_Pass(txtPassword.Text);
                User.tel = txtTel.Text;
                User.email = txtEmail.Text;
                User.adresse = txtdresse.Text;

                Db.users.AddOrUpdate(User);
                methods.SaveData(Db);
                getUserById(IdUser);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            methods.ControlsEmpty(mainPanel);
            IdUser = -1;
            btnAjouter.Text = "Ajouter";
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if(txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
                txtPassword.TextMarginTop = 8;
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtPassword.TextMarginTop = 12;
            }
        }

        private void txtPassword_Validated(object sender, EventArgs e)
        {
            DesignMethods.ValidationPassWordInt(txtPassword);
        }
    }
}
