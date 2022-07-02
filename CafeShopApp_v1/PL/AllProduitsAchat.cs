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
    public partial class AllProduitsAchat : UserControl
    {
        BL.Cfe_shop_dbEntities Db = new BL.Cfe_shop_dbEntities();
        BL.GlobalMethods methods = new BL.GlobalMethods();
        public static AllProduitsAchat ProdAForm = new AllProduitsAchat();
        public AllProduitsAchat()
        {
            InitializeComponent();
            getProdAchate();
            ProdAForm = this;
        }

        public void getProdAchate()
        {
            try
            {
                var ProdAchat = Db.get_all_produits_achat().ToList();
                lblCountProd.Text = ProdAchat.Count().ToString() + " Produits(s)";
                plDgv.Controls.Clear();
                foreach (var ProdA in ProdAchat)
                {
                    SubUserControle.UserRowProduitAchat row = new SubUserControle.UserRowProduitAchat();
                    row.imgProd.Image = methods.ConvertByteToImg(ProdA.image_produit);
                    row.lblName.Text = ProdA.name_produit;
                    row.lblCat.Text = Db.categories.Find(ProdA.categorie_Achat).name_cat;
                    row.lblId.Text = ProdA.id_produit.ToString();
                    row.lblUniter.Text = Db.unites.Find(ProdA.unite_prod).name_unit;
                    row.lblQte.Text = ProdA.qte_stock.ToString();
                    row.CheckConsom.Checked = (bool)ProdA.consom_directe;
                    plDgv.Controls.Add(row);
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewProduitForm ProdAForm = new NewProduitForm();
            ProdAForm.lblNProdV.Text = " Produit N° : " + (Db.produits.Count() + 1);
            mainForm.MainForm.plYield.Controls.Clear();
            mainForm.MainForm.plYield.Controls.Add(ProdAForm);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var produitsAachat = Db.get_produit_achat_by_str_search(txtSearch.Text);
                plDgv.Controls.Clear();
                foreach (var ProdA in produitsAachat)
                {
                    SubUserControle.UserRowProduitAchat row = new SubUserControle.UserRowProduitAchat();
                    row.imgProd.Image = methods.ConvertByteToImg(ProdA.image_produit);
                    row.lblName.Text = ProdA.name_produit;
                    row.lblCat.Text = ProdA.name_cat;
                    row.lblId.Text = ProdA.id_produit.ToString();
                    row.lblUniter.Text = ProdA.name_unit;
                    row.lblQte.Text = ProdA.qte_stock.ToString();
                    row.CheckConsom.Checked = (bool)ProdA.consom_directe;
                    plDgv.Controls.Add(row);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            }
        }
    }
}
