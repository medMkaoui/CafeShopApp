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
    public partial class UserUnite : UserControl
    {
        BL.GlobalMethods methods = new BL.GlobalMethods();
        BL.Cfe_shop_dbEntities Db = new BL.Cfe_shop_dbEntities();

        public UserUnite()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Êtes-vous sûr de vouloir supprimer?.", "Message de confirmation ? ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    BL.unite Unite = Db.unites.Find(int.Parse(lblId.Text));
                    Db.unites.Remove(Unite);
                    methods.SaveData(Db);
                    UniteForm.uniteForm.getUnites();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            BL.unite unite = Db.unites.Where(x => x.name_unit == this.nameProd.Text).FirstOrDefault();
            UniteForm.uniteForm.txtName.Text = nameProd.Text;
            UniteForm.uniteForm.btnAjouter.Text = "Modifier";
            UniteForm.uniteForm.IdUnite = unite.id_unit;
        }
    }
}
