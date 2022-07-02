using CafeShopApp_v1.BL;
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
    public partial class UserEspaceCard : UserControl
    {
        BL.Cfe_shop_dbEntities Db = new Cfe_shop_dbEntities();

        public UserEspaceCard()
        {
            InitializeComponent();
        }

        private void UserEspaceCard_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Parent.Controls)
            {
                UserEspaceCard item1 = (UserEspaceCard)item;
                item.BackColor = Color.White;
                item1.lblName.ForeColor = Color.Black;
            }
            int id = int.Parse(lblId.Text);

            List<tb_tables> tbs = Db.tb_tables.Where(ele => ele.espace == id).ToList();
            if(tbs.Count==0) tbs = Db.tb_tables.AsParallel().ToList();

            UserPlEtatBoutique.userPlEtatBoutique.getTables(tbs);
            this.BackColor = Color.FromArgb(138, 195, 137);
            this.lblName.ForeColor = Color.White;

            
        }
    }
}
