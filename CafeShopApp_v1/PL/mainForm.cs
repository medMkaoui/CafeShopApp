using System;
using System.Linq;
using System.Windows.Forms;

namespace CafeShopApp_v1.PL
{
    public partial class mainForm : Form
    {
        DesignCode.Methods methods = new DesignCode.Methods();
        BL.GlobalMethods GMethod = new BL.GlobalMethods();
        BL.Cfe_shop_dbEntities Db = new BL.Cfe_shop_dbEntities();
        public static mainForm MainForm = new mainForm();
        public mainForm()
        {
            InitializeComponent();
            GetCodeDash();
            MainForm = this;
        }

        public void GetCodeDash()
        {
            if (GMethod.CheckUserPrivilege("controle_Panel"))
            { 
                methods.hideSubMenu(plSubMenuProd, plSubMenuSetting);
                plYield.Controls.Clear();
                DashboardForm Dash = new DashboardForm();
                plYield.Controls.Add(Dash);
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            GetCodeDash();
        }

        private void btnSaillingPoint_Click(object sender, EventArgs e)
        {
            if (GMethod.CheckUserPrivilege("c_aisse"))
            { 
                methods.hideSubMenu(plSubMenuProd, plSubMenuSetting);

                CaisseForm caisseForm = new CaisseForm();
                caisseForm.ShowDialog();
            }
        }

        private void btnProduit_Click(object sender, EventArgs e)
        {
            if (GMethod.CheckUserPrivilege("p_roduits"))
            { 
                 methods.showSubMenu(plSubMenuProd);
                AllProduitsVente ProduitVenteForm = new AllProduitsVente();
                plYield.Controls.Clear();
                plYield.Controls.Add(ProduitVenteForm);
            }
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            if (GMethod.CheckUserPrivilege("c_lients"))
            {
                methods.hideSubMenu(plSubMenuProd, plSubMenuSetting);
                AllClientsForm clientForm = new AllClientsForm();
                plYield.Controls.Clear();
                plYield.Controls.Add(clientForm);
            }
        }

        private void btnSuplayer_Click(object sender, EventArgs e)
        {
            if (GMethod.CheckUserPrivilege("f_ournisseurs"))
            {
                methods.hideSubMenu(plSubMenuProd, plSubMenuSetting);
                AllFournisseursForm fournisseurForm = new AllFournisseursForm();
                plYield.Controls.Clear();
                plYield.Controls.Add(fournisseurForm);
            }

        }

        private void btnAchats_Click(object sender, EventArgs e)
        {
            if (GMethod.CheckUserPrivilege("a_chats"))
            { 
                methods.hideSubMenu(plSubMenuProd, plSubMenuSetting);
            }
        }

        private void btnCharges_Click(object sender, EventArgs e)
        {
            if (GMethod.CheckUserPrivilege("c_harges"))
            {             
                methods.hideSubMenu(plSubMenuProd, plSubMenuSetting);
                AllChargesForm chargeForm = new AllChargesForm();
                plYield.Controls.Clear();
                plYield.Controls.Add(chargeForm);
            }

        }

        private void btnCmd_Click(object sender, EventArgs e)
        {
            if (GMethod.CheckUserPrivilege("c_ommandes"))
            { 
                 methods.hideSubMenu(plSubMenuProd, plSubMenuSetting);
                AllCmdForm allCmdForm = new AllCmdForm();
                plYield.Controls.Clear();
                plYield.Controls.Add(allCmdForm);
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            methods.showSubMenu(plSubMenuSetting);
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            if (GMethod.CheckUserPrivilege("c_ategories"))
            { 
                CategoriesForm FormCat = new CategoriesForm();
                plYield.Controls.Clear();
                plYield.Controls.Add(FormCat);
            }
        }

        private void btnEspaces_Click(object sender, EventArgs e)
        {
            if (GMethod.CheckUserPrivilege("e_spaces"))
            {
                espacesForm EspaceForm = new espacesForm();
                plYield.Controls.Clear();
                plYield.Controls.Add(EspaceForm);
            }
        
        }

        private void btnSteLiv_Click(object sender, EventArgs e)
        {
            if (GMethod.CheckUserPrivilege("s_te_liv"))
            { 
                SteLivraison steLiv = new SteLivraison();
                plYield.Controls.Clear();
                plYield.Controls.Add(steLiv);
            }

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            if (GMethod.CheckUserPrivilege("u_tilisateur"))
            {
                AllUserForm User = new AllUserForm();
                plYield.Controls.Clear();
                plYield.Controls.Add(User);
            }
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            if (GMethod.CheckUserPrivilege("s_tock"))
            {
                AllProduitsAchat FormCat = new AllProduitsAchat();
                plYield.Controls.Clear();
                plYield.Controls.Add(FormCat);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnUnite_Click(object sender, EventArgs e)
        {
            if (GMethod.CheckUserPrivilege("u_nites"))
            { 
                UniteForm FormUnite = new UniteForm();
                plYield.Controls.Clear();
                plYield.Controls.Add(FormUnite);
            }

        }

        private void btnGeneralite_Click(object sender, EventArgs e)
        {
            //    if (GMethod.CheckUserPrivilege("u_nites"))
            //    {
            Generalite FormGeneralite = new Generalite();
                plYield.Controls.Clear();
                plYield.Controls.Add(FormGeneralite);
            //}
        }
    }
}
