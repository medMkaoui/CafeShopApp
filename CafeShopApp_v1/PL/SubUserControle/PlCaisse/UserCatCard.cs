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
    public partial class UserCatCard : UserControl
    {
        BL.Cfe_shop_dbEntities Db = new BL.Cfe_shop_dbEntities();
        BL.GlobalMethods methods = new BL.GlobalMethods();
        PL.DesignCode.Methods Methods = new DesignCode.Methods();
        public UserCatCard()
        {
            InitializeComponent();
        }

        private void UserCatCard_Click(object sender, EventArgs e)
        {
            Methods.ActiveCatStyle(this);
            
            foreach (Control item in this.Parent.Controls)
            {
                UserCatCard item1 = (UserCatCard)item;
                if(item != this)
                {
                    Methods.NormalCat(item1);
                }
            }
            UserCategorie_Prod.userCategorie_Prod.plProd.Controls.Clear();
            getProd(int.Parse(lblId.Text));
        }

        public void getProd(int id)
        {
            var produits = Db.produits.Where(ele => ele.categorie_Vent == id).ToList();
            if (id == -1) produits= Db.produits.Where(ele=> ele.categorie_Vent != null).ToList();

            foreach (var prod in produits)
            {
                SubUserControle.UserProdCard ProdCard = new SubUserControle.UserProdCard();
                ProdCard.lblId.Text = prod.id_produit.ToString();
                ProdCard.lblTitleProd.Text = prod.name_produit;
                ProdCard.imgProd.Image = methods.ConvertByteToImg(prod.image_produit);
                ProdCard.lblPrix.Text = prod.prix_jour.ToString();
                UserCategorie_Prod.userCategorie_Prod.plProd.Controls.Add(ProdCard);
            }
        }
    }
}
