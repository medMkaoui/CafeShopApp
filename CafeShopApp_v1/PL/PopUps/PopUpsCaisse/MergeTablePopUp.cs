using CafeShopApp_v1.PL.SubUserControle.PlEtatB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeShopApp_v1.PL.PopUps.PopUpsCaisse
{
    public partial class MergeTablePopUp : Form
    {
        BL.Cfe_shop_dbEntities Db = new BL.Cfe_shop_dbEntities();
        BL.GlobalMethods globalMethods = new BL.GlobalMethods();
        public MergeTablePopUp()
        {
            InitializeComponent();
            fillddEspace();
        }

        void fillddTables()
        {
            if (this.Created)
            {
                int id = (int)(ddEspace.SelectedValue);
                ddTable.DataSource = Db.tb_tables.Where(ele => ele.espace == id && ele.statu != "Vide").ToList();
                ddTable.DisplayMember = "name_table";
                ddTable.ValueMember = "id_table";
            }
        }
        void fillddEspace()
        {
            ddEspace.DataSource = Db.espaces.AsParallel().ToList();
            ddEspace.DisplayMember = "name_espace";
            ddEspace.ValueMember = "id_espace";
            ddEspace.SelectedIndex = 0;
        }

        private void ddEspace_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillddTables();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            
        }
    }
}
