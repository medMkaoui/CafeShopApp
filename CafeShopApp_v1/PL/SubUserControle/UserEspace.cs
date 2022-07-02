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
    public partial class UserEspace : UserControl
    {
        BL.Cfe_shop_dbEntities Db = new BL.Cfe_shop_dbEntities();
        BL.GlobalMethods globalMethods = new BL.GlobalMethods();


        public UserEspace()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Êtes-vous sûr de vouloir supprimer?.", "Message de confirmation ? ", MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                BL.espace espace = Db.espaces.Where(x => x.name_espace == this.lblNameEspace.Text).FirstOrDefault();
                Db.espaces.Remove(espace);
                globalMethods.SaveData(Db);
                espacesForm.EspaceForm.getEspaces();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            BL.espace espace = Db.espaces.Where(x => x.name_espace == this.lblNameEspace.Text).FirstOrDefault();
            espacesForm.EspaceForm.btnAjouter.Text = "Modifier";
            espacesForm.EspaceForm.txtName.Text = espace.name_espace;
            espacesForm.EspaceForm.txtNbrTable.Text = espace.nbr_tables.ToString();
            espacesForm.EspaceForm.idEspace = espace.id_espace;

        }
    }
}
