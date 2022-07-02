using Bunifu.UI.WinForms;
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
    public partial class NewProduitForm : UserControl
    {
        BL.Cfe_shop_dbEntities Db = new BL.Cfe_shop_dbEntities();
        BL.GlobalMethods methods = new BL.GlobalMethods();
        DesignCode.Methods methodsDesign = new DesignCode.Methods();
        public static NewProduitForm NewProdVente = new NewProduitForm();
        Image img;
        public int idProdVente;


        public NewProduitForm(int idProdV = -1)
        {
            InitializeComponent();
            NewProdVente = this;
            FillDds();
            getProduitVenteById(idProdV);
            
        }

        public void FillDds()
        {
            ddCatAchat.DataSource = Db.get_all_categories(true).ToList();
            ddCatAchat.DisplayMember = "name_cat";
            ddCatAchat.ValueMember = "id_cat";

            ddCatVente.DataSource = Db.get_all_categories(false).ToList();
            ddCatVente.DisplayMember = "name_cat";
            ddCatVente.ValueMember = "id_cat";

            ddUnite.DataSource = Db.get_all_unites().ToList();
            ddUnite.DisplayMember = "name_unit";
            ddUnite.ValueMember = "id_unit";
        }


        public void getProduitVenteById(int id)
        {
            BL.produit ProdV = Db.produits.Find(id);
            if (ProdV != null)
            {

                idProdVente = ProdV.id_produit;
                btnAjouter.Text = "Modifier";
                lblTitle.Text = "MODIFIER PRODUIT";
                lblNProdV.Text = "Produit : " + ProdV.name_produit;

                txtName.Text = ProdV.name_produit;
                img = methods.ConvertByteToImg(ProdV.image_produit);

                if (ProdV.prix_jour != null && ProdV.categorie_Achat ==null)
                {
                    plProdV.Visible = true;
                    plProdA.Visible = false;
                    FillControlsProdVente(ProdV);
                }
                else if(ProdV.prix_jour == null && ProdV.categorie_Vent ==null)
                {
                    plProdV.Visible = false;
                    plProdA.Visible = true;
                    FillControlsProdAchat(ProdV);
                }
                else
                {
                    plProdV.Visible = true;
                    plProdA.Visible = true;
                    ddTypeProduit.SelectedIndex = 2;

                    FillControlsProdVente(ProdV);
                    FillControlsProdAchat(ProdV);
                    ddTypeProduit.SelectedIndex = 2;

                }
                  
            }

        }

        public void FillControlsProdVente(BL.produit ProdV)
        {
            
            ddTypeProduit.SelectedIndex = 0;
            ddCuisineBarman.SelectedText = ProdV.lieu_préparation;
            txtPrixN.Text = ProdV.prix_nuit.ToString();
            txtPrixJ.Text = ProdV.prix_jour.ToString();
            ddCatVente.SelectedValue = ProdV.categorie_Vent;
        }
        
        public void FillControlsProdAchat(BL.produit ProdV)
        {
            
            ddTypeProduit.SelectedIndex = 1;
            txtQte.Text = ProdV.qte_stock.ToString();
            ddCatAchat.SelectedValue = ProdV.categorie_Achat;
            ddUnite.SelectedValue = ProdV.unite_prod;
        }


       

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            methods.ControlsEmpty(mainPanel);
            idProdVente = -1;
            btnAjouter.Text = "Ajouter";
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            AllProduitsVente prodVForm = new AllProduitsVente();
            mainForm.MainForm.plYield.Controls.Clear();
            mainForm.MainForm.plYield.Controls.Add(prodVForm);
        }

        private void ddTypeProduit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ddTypeProduit.SelectedIndex == 0)
            {
                plProdV.Visible = true;
                plProdA.Visible = false;
            }else if (ddTypeProduit.SelectedIndex == 1)
            {
                plProdA.Visible = true;
                plProdV.Visible = false;
            }
            else
            {
                plProdA.Visible = true;
                plProdV.Visible = true;
            }
        }

        private void txtPrixJ_TextChanged(object sender, EventArgs e)
        {
            methodsDesign.validationDecimal(txtPrixJ);
        }

        private void txtPrixN_TextChanged_1(object sender, EventArgs e)
        {
            methodsDesign.validationDecimal(txtPrixN);
        }

        private void txtQte_TextChanged(object sender, EventArgs e)
        {
            methodsDesign.validationDecimal(txtQte);
        }

        private void btnImg_Click(object sender, EventArgs e)
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
                MessageBox.Show("Les informations demandées sont incomplètes !!", "Validation des information");
            }
            else
            {
                BL.produit prod = Db.produits.Find(idProdVente);
                if (prod == null) prod = new BL.produit();
                else { prod = new BL.produit();  prod.id_produit = idProdVente; }
               
                prod.name_produit = txtName.Text;
                prod.image_produit = methods.ConvertImgToByte(img);
                if (ddTypeProduit.SelectedIndex == 0) prod.consom_directe = true; else prod.consom_directe = false;

                //produit de vente info

                if (plProdV.Visible)
                {
                    prod.categorie_Vent = (int)ddCatVente.SelectedValue;
                    prod.lieu_préparation = ddCuisineBarman.Text.Trim();
                    prod.prix_jour = decimal.Parse(txtPrixJ.Text);
                    prod.prix_nuit = decimal.Parse(txtPrixN.Text);
                }
                

                //produit d'achat info

                if(plProdA.Visible)
                {
                    prod.categorie_Achat = (int)ddCatAchat.SelectedValue;
                    prod.qte_stock = int.Parse(txtQte.Text);
                    prod.unite_prod = (int)ddUnite.SelectedValue;
                }

                Db.produits.AddOrUpdate(prod);
                methods.SaveData(Db);

                //MessageBox.Show(prod.categorie_Achat.ToString());

                getProduitVenteById(idProdVente);
            }
        }
    }
}
