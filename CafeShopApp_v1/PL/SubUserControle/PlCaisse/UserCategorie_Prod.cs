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
    public partial class UserCategorie_Prod : UserControl
    {
        BL.Cfe_shop_dbEntities Db = new BL.Cfe_shop_dbEntities();
        BL.GlobalMethods methods = new BL.GlobalMethods();
        PL.DesignCode.Methods methodsD = new DesignCode.Methods();
        public static UserCategorie_Prod userCategorie_Prod = new UserCategorie_Prod();


        public UserCategorie_Prod()
        {
            InitializeComponent();
            userCategorie_Prod = this;
            var produits = Db.get_all_produits_vente().ToList();
            getProd();
            getCats();
        }

        public void getCats()
        {
            plCate.Controls.Clear();

            var categories = Db.get_all_categories(false).ToList();

            SubUserControle.UserCatCard CatCardAll = new SubUserControle.UserCatCard();

            CatCardAll.lblId.Text = (-1).ToString();
            CatCardAll.lblName.Text = "Tout";
            CatCardAll.lblContProd.Text = Db.produits.AsParallel().ToList().Count.ToString() + " Produit(s)";
            CatCardAll.BackColor = Color.FromArgb(138, 195, 137);
            CatCardAll.lblName.Text = "Tous Produits";
            CatCardAll.lblName.ForeColor = Color.White;

            plCate.Controls.Add(CatCardAll);

            foreach (var categorie in categories)
            {
                SubUserControle.UserCatCard CatCard = new SubUserControle.UserCatCard();
                CatCard.lblId.Text = categorie.id_cat.ToString();
                CatCard.lblName.Text = categorie.name_cat;
                CatCard.imgProd.Image = methods.ConvertByteToImg(categorie.image_cat);
                CatCard.lblContProd.Text = Db.produits.Where(ele => ele.categorie_Vent == categorie.id_cat).ToList().Count.ToString() + " Produit(s)";

                plCate.Controls.Add(CatCard);
            }
        }
        public void getProd()
        {
            var produits = Db.get_all_produits_vente().ToList();

            plProd.Controls.Clear(); // clear 

            foreach (var prod in produits)
            {
                SubUserControle.UserProdCard ProdCard = new SubUserControle.UserProdCard();
                ProdCard.lblId.Text = prod.id_produit.ToString();
                ProdCard.lblTitleProd.Text = prod.name_produit;
                ProdCard.imgProd.Image =methods.ConvertByteToImg(prod.image_produit);
                ProdCard.lblPrix.Text = prod.prix_jour.ToString();
                plProd.Controls.Add(ProdCard);
            }
        }
    }
}
