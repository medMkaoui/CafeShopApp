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

namespace CafeShopApp_v1.PL.SubUserControle
{
    public partial class UserRowProduitVente : UserControl
    {
        BL.Cfe_shop_dbEntities Db = new BL.Cfe_shop_dbEntities();
        BL.GlobalMethods methods = new BL.GlobalMethods();

        public UserRowProduitVente()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            NewProduitForm newFournisseur = new NewProduitForm(int.Parse(lblId.Text));
            mainForm.MainForm.plYield.Controls.Clear();
            mainForm.MainForm.plYield.Controls.Add(newFournisseur);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Êtes-vous sûr de vouloir supprimer?.", "Message de confirmation ? ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                var produitVente = Db.produits.Find(int.Parse(lblId.Text));
                Db.produits.Remove(produitVente);
                Db.SaveChanges();
                MessageBox.Show("Bien Supprimer");
                AllProduitsVente.ProdVForm.getProdVente();
            }
        }

        private void lblPrixLiv_TextChanged(object sender, EventArgs e)
        {
            if (!(lblPrixLiv.Text == string.Empty))
            {
                if (!decimal.TryParse(lblPrixLiv.Text, out decimal x))
                {
                    MessageBox.Show("Veuillez n'entrer que des chiffres.");
                    lblPrixLiv.Text = string.Empty;
                }
            }
        }

        private void lblPrixLiv_Validating(object sender, CancelEventArgs e)
        {
            if (lblPrixLiv.Text.Trim() != "")
            {
                int idProd = int.Parse(lblId.Text);
                int idSteLiv = (int)AllProduitsVente.ProdVForm.ddSteLiv.SelectedValue;
                var SteLiv_Prod = Db.livraison_produit.Where(ele => ele.produit == idProd && ele.liv == idSteLiv).FirstOrDefault();
                if (SteLiv_Prod == null) SteLiv_Prod = new BL.livraison_produit();

                SteLiv_Prod.prix_jour = decimal.Parse(lblPrixLiv.Text);
                SteLiv_Prod.liv = idSteLiv;
                SteLiv_Prod.produit = idProd;

                Db.livraison_produit.AddOrUpdate(SteLiv_Prod);
                Db.SaveChanges();
                AllProduitsVente.ProdVForm.getProdVente();
            }
        }
    }
}
