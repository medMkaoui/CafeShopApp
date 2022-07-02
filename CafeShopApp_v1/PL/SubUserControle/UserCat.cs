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
    public partial class UserCat : UserControl
    {
        BL.GlobalMethods methods = new BL.GlobalMethods();
        BL.Cfe_shop_dbEntities Db = new BL.Cfe_shop_dbEntities();
        public UserCat()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
             DialogResult dr = MessageBox.Show("Êtes-vous sûr de vouloir supprimer?.", "Message de confirmation ? ", MessageBoxButtons.YesNoCancel,
             MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                BL.category cat = Db.categories.Where(x => x.name_cat == this.nameProd.Text && x.is_categorie_Achat == CategoriesForm.catForm.type ).FirstOrDefault();
                Db.categories.Remove(cat);
                methods.SaveData(Db);
                CategoriesForm.catForm.getCategories();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            BL.category cat = Db.categories.Where(x => x.name_cat == this.nameProd.Text && x.is_categorie_Achat == CategoriesForm.catForm.type).FirstOrDefault();
            CategoriesForm.catForm.txtName.Text = nameProd.Text;
            CategoriesForm.catForm.txtImg.Text = "(1 fichier choisi)";
            CategoriesForm.catForm.btnAjouter.Text = "Modifier";
            CategoriesForm.catForm.IdCat = cat.id_cat;
        }
    }
}
