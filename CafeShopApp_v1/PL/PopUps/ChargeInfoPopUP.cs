using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeShopApp_v1.PL.PopUps
{
    public partial class ChargeInfoPopUP : Form
    {
        public ChargeInfoPopUP(string Montant, string Date, string Responsable, string Desc)
        {
            InitializeComponent();
            txtDateUser.Text = Date + " / " + Responsable;
            txtDesc.Text = Desc;
            txtMonatant.Text = Montant + " MAD";
        }

        private const int CS_DropShadow = 0x00030000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = CS_DropShadow;
                return cp;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
