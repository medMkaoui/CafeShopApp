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
    public partial class UserRowFournisseurs : UserControl
    {
        BL.Cfe_shop_dbEntities Db = new BL.Cfe_shop_dbEntities();
        BL.GlobalMethods methods = new BL.GlobalMethods();
        public UserRowFournisseurs()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Êtes-vous sûr de vouloir supprimer?.", "Message de confirmation ? ", MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                var fournisseur = Db.fournisseurs.Find(int.Parse(lblId.Text));
                Db.fournisseurs.Remove(fournisseur);
                Db.SaveChanges();
                MessageBox.Show("Bien Supprimer");
                AllFournisseursForm.FournissuerForm.getFournissuers();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            NewFournisseurForm newFournisseur = new NewFournisseurForm(int.Parse(lblId.Text));
            mainForm.MainForm.plYield.Controls.Clear();
            mainForm.MainForm.plYield.Controls.Add(newFournisseur);
        }
    }
}
