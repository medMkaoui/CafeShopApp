using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;

namespace CafeShopApp_v1.PL
{
    public partial class UserPreviliges : UserControl
    {
        BL.Cfe_shop_dbEntities Db = new BL.Cfe_shop_dbEntities();
        BL.GlobalMethods methods = new BL.GlobalMethods();
        PL.DesignCode.Methods Methods = new DesignCode.Methods();
        int IdU;
        public UserPreviliges(int idUser)
        {
            InitializeComponent();
            get_UserPreviliges(idUser);
            IdU = idUser;
        }

        public void get_UserPreviliges(int idu)
        {
            BL.users_privileges user_privilege = Db.users_privileges.Where(item => item.id_Utilisateur == idu).FirstOrDefault();
            lbluser.Text += Db.users.Find(idu).name_user;
            Chec_Caisse.Checked = (bool)user_privilege.c_aisse;
            Chec_Categories.Checked = (bool)user_privilege.c_ategories;
            Chec_Achats.Checked = (bool)user_privilege.a_chats;
            Chec_Conrole_Panel.Checked = (bool)user_privilege.controle_Panel;
            Chec_Charges.Checked = (bool)user_privilege.c_harges;
            Chec_Clients.Checked = (bool)user_privilege.c_lients;
            Chec_Cmd.Checked = (bool)user_privilege.c_ommandes;
            Chec_Espaces.Checked = (bool)user_privilege.e_spaces;
            Chec_ste_Liv.Checked = (bool)user_privilege.s_te_liv;
            Chec_Unite.Checked = (bool)user_privilege.u_nites;
            Chec_Utilisateurs.Checked = (bool)user_privilege.u_tilisateur;
            Chec_Fournisseurs.Checked = (bool)user_privilege.f_ournisseurs;
            Chec_Stock.Checked = (bool)user_privilege.s_tock;
            Chec_Produits.Checked = (bool)user_privilege.p_roduits;
            //Chec_Generalite.Checked = (bool)user_privilege.p_roduits;

        }
        public void set_UserPreviliges(int idu)
        {
            BL.users_privileges user_privilege = Db.users_privileges.Where(item => item.id_Utilisateur == idu).FirstOrDefault();
            int count = Db.users_privileges.Where(item => item.u_tilisateur == true).Count();
            if (count <= 1 && Chec_Utilisateurs.Checked == false) 
            {
                MessageBox.Show("Au moins un utilisateur doit être autorisé à modifier les autorisations des utilisateurs", "Attention", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else {
                if (user_privilege == null)  user_privilege = new BL.users_privileges(); 
                user_privilege.c_aisse = Chec_Caisse.Checked;
                user_privilege.c_ategories = Chec_Categories.Checked;
                user_privilege.a_chats = Chec_Achats.Checked;
                user_privilege.controle_Panel = Chec_Conrole_Panel.Checked;
                user_privilege.c_harges = Chec_Charges.Checked;
                user_privilege.c_lients = Chec_Clients.Checked;
                user_privilege.c_ommandes = Chec_Cmd.Checked;
                user_privilege.e_spaces = Chec_Espaces.Checked;
                user_privilege.s_te_liv = Chec_ste_Liv.Checked;
                user_privilege.u_nites = Chec_Unite.Checked;
                user_privilege.u_tilisateur = Chec_Utilisateurs.Checked;
                user_privilege.f_ournisseurs = Chec_Fournisseurs.Checked;
                user_privilege.s_tock = Chec_Stock.Checked;
                user_privilege.p_roduits = Chec_Produits.Checked;
                //Chec_Generalite.Checked = (bool)user_privilege.p_roduits;
                Db.users_privileges.AddOrUpdate(user_privilege);
                methods.SaveData(Db);
            }
        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            set_UserPreviliges(IdU);
        }

        private void btnReturn_Click(object sender, System.EventArgs e)
        {
            AllUserForm User = new AllUserForm();
            mainForm.MainForm.plYield.Controls.Clear();
            mainForm.MainForm.plYield.Controls.Add(User);
        }

        private void btnAnnuler_Click(object sender, System.EventArgs e)
        {
            get_UserPreviliges(IdU);
        }
    }
}
