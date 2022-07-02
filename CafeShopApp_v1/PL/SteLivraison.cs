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
    public partial class SteLivraison : UserControl
    {
        BL.Cfe_shop_dbEntities Db = new BL.Cfe_shop_dbEntities();
        BL.GlobalMethods methods = new BL.GlobalMethods();
        Image img;
        public int IdSte;
        public static SteLivraison SteLiv = new SteLivraison();
        public SteLivraison()
        {
            InitializeComponent();
            SteLiv = this;
            getSte();
        }

        public void getSte()
        {
            //try{
            var Ste = Db.get_all_ste_livraisons();
            plSteLiv.Controls.Clear();
            foreach (var ste in Ste)
            {
                SubUserControle.UserSteLiv SteLiv = new SubUserControle.UserSteLiv();
                SteLiv.LogoSte.Image = methods.ConvertByteToImg(ste.logo);
                SteLiv.lblNameSte.Text = ste.name_ste;
                plSteLiv.Controls.Add(SteLiv);
            }
            // }catch(Exception e) { }

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
                MessageBox.Show("Nom champ obligatoire", "Validation des information");
            }
            else
            {
                BL.ste_livraisons SteLivr = Db.ste_livraisons.Where(x => x.id_ste == this.IdSte).FirstOrDefault();
                if (SteLivr == null) SteLivr = new BL.ste_livraisons();

                SteLivr.name_ste = txtName.Text;
                SteLivr.logo = methods.ConvertImgToByte(img);

                Db.ste_livraisons.AddOrUpdate(SteLivr);
                Db.SaveChanges();

                MessageBox.Show("opération réussie");
                getSte();
                btnAnnuler_Click(sender, e);
                IdSte = -1;
            }


        }
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            methods.ControlsEmpty(mainPanel);
            btnAjouter.Text = "Ajouter";
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                var StesLiv = Db.get_steLiv_by_str_search(txtSearch.Text);
                plSteLiv.Controls.Clear();
                foreach (var SteLiv in StesLiv)
                {
                    SubUserControle.UserSteLiv steLiv = new SubUserControle.UserSteLiv();
                    steLiv.LogoSte.Image = methods.ConvertByteToImg(SteLiv.logo);
                    steLiv.lblNameSte.Text = SteLiv.name_ste;
                    plSteLiv.Controls.Add(steLiv);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
