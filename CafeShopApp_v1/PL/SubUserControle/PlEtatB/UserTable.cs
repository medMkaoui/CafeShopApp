using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeShopApp_v1.PL.SubUserControle.PlEtatB
{
    public partial class UserTable : UserControl
    {
        BL.Cfe_shop_dbEntities Db = new BL.Cfe_shop_dbEntities();
        public static UserTable user_table = new UserTable();
        public static BL.commande Cmd =null; 
        public UserTable()
        {
            InitializeComponent();
        }

        private void UserTable_DoubleClick(object sender, EventArgs e)
        {
            
            if (Cmd == null)
            {

                Cmd = Db.commandes.Where(ele=> ele.t_able == this.lblTitleTable.Text).FirstOrDefault();
                CaisseForm.caisseForm.btnMerge.Enabled = true;
                CaisseForm.caisseForm.btnTransfer.Enabled = true;
                foreach (UserTable item in UserPlEtatBoutique.userPlEtatBoutique.plTable.Controls)
                {
                    if (item.BackColor != Color.FromArgb(138, 195, 137))
                    {
                        item.checkMerge.Visible = true;
                        item.checkMerge.Enabled = true;
                    }
                }
            }
            else
            {
                Cmd = null;
                CaisseForm.caisseForm.btnMerge.Enabled = false;
                CaisseForm.caisseForm.btnTransfer.Enabled = false;
                foreach (UserTable item in UserPlEtatBoutique.userPlEtatBoutique.plTable.Controls)
                {

                    if (item.BackColor != Color.FromArgb(138, 195, 137))
                    {
                        item.checkMerge.Visible = false;
                        item.checkMerge.Enabled = false;
                    }
                }
            }
          

        }
        
    }
}
