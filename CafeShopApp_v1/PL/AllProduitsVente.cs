using Bunifu.UI.WinForms;
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
    public partial class AllProduitsVente : UserControl
    {
        BL.Cfe_shop_dbEntities Db = new BL.Cfe_shop_dbEntities();
        BL.GlobalMethods methods = new BL.GlobalMethods();
        public static AllProduitsVente ProdVForm = new AllProduitsVente();
        bool windowReady = false;
        public AllProduitsVente()
        {
            InitializeComponent();
            getProdVente();
            FillDdSteLiv();
            ProdVForm = this;
        }


        public void getProdVente()
        {
            try
            {
                var ProdVente = Db.get_all_produits_vente().ToList();
                lblCountProd.Text = ProdVente.Count().ToString() + " Produits(s)";
                plDgv.Controls.Clear();
                foreach (var ProdV in ProdVente)
                {
                    SubUserControle.UserRowProduitVente row = new SubUserControle.UserRowProduitVente();
                    row.imgProd.Image = methods.ConvertByteToImg(ProdV.image_produit);
                    row.lblName.Text = ProdV.name_produit;
                    row.lblCat.Text = ProdV.name_produit;
                    row.lblId.Text = ProdV.id_produit.ToString();
                    row.lblPrixJ.Text = ProdV.prix_jour.ToString();
                    row.lblPrixN.Text = ProdV.prix_nuit.ToString();
                    if (ProdV.lieu_préparation == "Prepare par le cuisinier") row.lblType.Text = "Cuisine"; else if (ProdV.lieu_préparation == "Prepare par le bar man")
                        row.lblType.Text = "Bar-man";else row.lblType.Text = "Snack";
                    plDgv.Controls.Add(row);  
                }
                FillDdSteLiv();
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }

        public void FillDdSteLiv()
        {
            ddSteLiv.DataSource = Db.get_all_ste_livraisons().ToList();
            ddSteLiv.DisplayMember = "name_ste";
            ddSteLiv.ValueMember = "id_ste";
            windowReady = true;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            NewProduitForm ProdVForm = new NewProduitForm();
            ProdVForm.lblNProdV.Text = " Produit N° : " + (Db.produits.Count() + 1);
            mainForm.MainForm.plYield.Controls.Clear();
            mainForm.MainForm.plYield.Controls.Add(ProdVForm);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var produitsVente = Db.get_produit_vente_by_str_search(txtSearch.Text);
                plDgv.Controls.Clear();
                foreach (var ProdV in produitsVente)
                {
                    SubUserControle.UserRowProduitVente row = new SubUserControle.UserRowProduitVente();
                    row.imgProd.Image = methods.ConvertByteToImg(ProdV.image_produit);
                    row.lblName.Text = ProdV.name_produit;
                    row.lblCat.Text = ProdV.name_cat;
                    row.lblId.Text = ProdV.id_produit.ToString();
                    row.lblPrixJ.Text = ProdV.prix_jour.ToString();
                    row.lblPrixN.Text = ProdV.prix_nuit.ToString();
                    plDgv.Controls.Add(row);
                }
                getPrixLivraison();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }


        public void getPrixLivraison()
        {
            try
            {
                foreach (Control row in plDgv.Controls)
                {
                    var rowProd = (SubUserControle.UserRowProduitVente)row;
                    int idProd = int.Parse(rowProd.lblId.Text);
                    int idSteLiv = (int)ddSteLiv.SelectedValue;
                    var SteLiv_Prod = Db.livraison_produit.Where(ele => ele.produit == idProd && ele.liv == idSteLiv).FirstOrDefault();
                    foreach (Control item in row.Controls)
                    {
                        if (item is BunifuTextBox && item.Name == "lblPrixLiv")
                        {
                            BunifuTextBox item1 = (BunifuTextBox)item;
                            if (SteLiv_Prod != null) item1.Text = SteLiv_Prod.prix_jour.ToString(); else { item1.PlaceholderText = "Prix " + ddSteLiv.Text; item1.Text = string.Empty; }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void ddSteLiv_SelectedValueChanged(object sender, EventArgs e)
        {
            if (windowReady){getPrixLivraison();}
           // MessageBox.Show(ddSteLiv.SelectedValue.ToString());
            
        }
    }
}
