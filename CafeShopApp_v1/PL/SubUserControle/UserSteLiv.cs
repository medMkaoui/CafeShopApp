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
    public partial class UserSteLiv : UserControl
    {
        BL.GlobalMethods methods = new BL.GlobalMethods();
        BL.Cfe_shop_dbEntities Db = new BL.Cfe_shop_dbEntities();
        public UserSteLiv()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            BL.ste_livraisons ste = Db.ste_livraisons.Where(x => x.name_ste == this.lblNameSte.Text).FirstOrDefault();

            SteLivraison.SteLiv.txtName.Text = lblNameSte.Text;
            SteLivraison.SteLiv.txtImg.Text = "(1 fichier choisi)";
            SteLivraison.SteLiv.btnAjouter.Text = "Modifier";
            SteLivraison.SteLiv.IdSte = ste.id_ste;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Êtes-vous sûr de vouloir supprimer?.", "Message de confirmation ? ", MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                BL.ste_livraisons ste = Db.ste_livraisons.Where(x => x.name_ste == this.lblNameSte.Text).FirstOrDefault();
                Db.ste_livraisons.Remove(ste);
                Db.SaveChanges();
                MessageBox.Show("Bien Supprimer");
                SteLivraison.SteLiv.getSte();
            }
        }
    }
}
