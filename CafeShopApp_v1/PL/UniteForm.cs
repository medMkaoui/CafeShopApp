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
    public partial class UniteForm : UserControl
    {
        BL.Cfe_shop_dbEntities Db = new BL.Cfe_shop_dbEntities();
        BL.GlobalMethods methods = new BL.GlobalMethods();
        public int IdUnite;
        public static UniteForm uniteForm = new UniteForm();
        public UniteForm()
        {
            InitializeComponent();
            getUnites();
        }

        public void getUnites()
        {
            try
            {
                var unites = Db.get_all_unites();
                plCategories.Controls.Clear();
                foreach (var unite in unites)
                {
                    SubUserControle.UserUnite Unite = new SubUserControle.UserUnite();
                    Unite.nameProd.Text = unite.name_unit;
                    Unite.lblId.Text = unite.id_unit.ToString();
                    plCategories.Controls.Add(Unite);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                BL.unite Unite = Db.unites.Find(this.IdUnite);
                if (Unite == null) Unite = new BL.unite();
                Unite.name_unit = txtName.Text;
                Db.unites.AddOrUpdate(Unite);
                methods.SaveData(Db);
                getUnites();
                btnAnnuler_Click(sender, e);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            methods.ControlsEmpty(mainPanel);
            btnAjouter.Text = "Ajouter";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var unites = Db.get_all_Unite(txtSearch.Text);
                plCategories.Controls.Clear();
                foreach (var unite in unites)
                {
                    SubUserControle.UserUnite Unite = new SubUserControle.UserUnite();
                    Unite.nameProd.Text = unite.name_unit;
                    plCategories.Controls.Add(Unite);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
