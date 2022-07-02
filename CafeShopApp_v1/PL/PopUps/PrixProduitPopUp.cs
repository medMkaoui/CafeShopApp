using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeShopApp_v1.PL.PopUps
{
    public partial class PrixProduitPopUp : Form
    {
        BL.Cfe_shop_dbEntities Db = new BL.Cfe_shop_dbEntities();
        BL.GlobalMethods methods = new BL.GlobalMethods();
        int idProd = -1;

        public PrixProduitPopUp(int idProd)
        {
            InitializeComponent();
            this.idProd = idProd;
            FillDdCategorie();
        }

        public void FillDdCategorie()
        {
            ddCat.DataSource = Db.get_all_categories(false).ToList();
            ddCat.DisplayMember = "name_cat";
            ddCat.ValueMember = "id_cat";
        }

        private const int CS_DropShadow = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = CS_DropShadow;
                return cp;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {

        }
    }
}
