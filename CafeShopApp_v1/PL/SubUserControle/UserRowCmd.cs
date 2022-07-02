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
    public partial class UserRowCmd : UserControl
    {
        public UserRowCmd()
        {
            InitializeComponent();
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(lblId.Text);
            AllDetailsCmdForm allDetailsCmd = new AllDetailsCmdForm(id);
            mainForm.MainForm.plYield.Controls.Clear();
            mainForm.MainForm.plYield.Controls.Add(allDetailsCmd);
        }
    }
}
