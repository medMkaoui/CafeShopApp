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
    public partial class CategoriesForm : UserControl
    { 
        BL.Cfe_shop_dbEntities Db = new BL.Cfe_shop_dbEntities();
        BL.GlobalMethods methods = new BL.GlobalMethods();
        Image img;
        public int IdCat;
        public static CategoriesForm catForm = new CategoriesForm();

        public CategoriesForm()
        {
            InitializeComponent();
            ddTypeCat.SelectedIndex = 1;
            getCategories();
            lblCountCat.Text = Db.categories.Count().ToString() + " Categorie(s)";
            catForm = this;
        }

         public bool type = true;
        public void getCategories()
        {
            try
            {
                
                if (ddTypeCat.SelectedIndex == 0) type = false; else type = true;
                var Cats = Db.get_all_categories(type);

                plCategories.Controls.Clear();

                foreach (var cat in Cats)
                {
                    SubUserControle.UserCat Cat = new SubUserControle.UserCat();
                    Cat.imgProd.Image = methods.ConvertByteToImg(cat.image_cat);
                    Cat.nameProd.Text = cat.name_cat;
                    if((bool)cat.is_categorie_Achat)  Cat.lblType.Text = "Achat"; else Cat.lblType.Text = "Vente";
                    plCategories.Controls.Add(Cat);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtImg.Text = "(1 fichier choisi)";
                    img = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Désignation champ obligatoire", "Validation des information");

            }
            else
            {
                BL.category Categorie = Db.categories.Where(x => x.id_cat == this.IdCat).FirstOrDefault();
                if (Categorie == null) Categorie = new BL.category();

                Categorie.name_cat = txtName.Text;
                Categorie.image_cat = methods.ConvertImgToByte(img);
                Categorie.is_categorie_Achat = rdTypeCat.Checked;

                Db.categories.AddOrUpdate(Categorie);

                methods.SaveData(Db);
                ddTypeCat.SelectedIndex = 1;
                getCategories();
                btnAnnuler_Click(sender,  e);
                IdCat = -1;
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            methods.ControlsEmpty(mainPanel);
            btnAjouter.Text = "Ajouter";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try{
                if (ddTypeCat.SelectedIndex == 0) type = false; else type = true;
                var Cats = Db.get_categories_by_str_search(txtSearch.Text, type);
                plCategories.Controls.Clear();
                foreach (var cat in Cats)
                {
                    SubUserControle.UserCat Cat = new SubUserControle.UserCat();
                    Cat.imgProd.Image = methods.ConvertByteToImg(cat.image_cat);
                    Cat.nameProd.Text = cat.name_cat;
                    plCategories.Controls.Add(Cat);
                }
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void lblRdCat_Click(object sender, EventArgs e)
        {
            if (rdTypeCat.Checked) rdTypeCat.Checked = false; else rdTypeCat.Checked = true;
        }

        private void ddTypeCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            getCategories();
        }
    }
}
