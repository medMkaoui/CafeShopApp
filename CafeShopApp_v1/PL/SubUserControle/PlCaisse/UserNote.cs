using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeShopApp_v1.PL.SubUserControle.PlCaisse
{
    public partial class UserNote : UserControl
    {
        public UserNote(string note)
        {
            InitializeComponent();
            lblNameNote.Text = note;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //if (UserRowProduitCmd.produitCmd.Height == 103) UserRowProduitCmd.produitCmd.Height = 65;
            //    UserRowProduitCmd.produitCmd.Height -= 20;
            //UserRowProduitCmd.produitCmd.Refresh();

            //this.Parent.Controls.Remove(this);
        }
    }
}
