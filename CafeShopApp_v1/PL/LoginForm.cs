
using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeShopApp_v1.PL
{
    public partial class LoginForm : Form
    {
        Padding padding = new Padding();
        BunifuTextBox lastEntry;
        string MotPasse="";
        public LoginForm()
        {
            

            InitializeComponent();
            CostomizePictureBox();
            initiaPramsContent(88,275);
        }

        void CostomizePictureBox()
        {
            padding.All = 0;
            pbPhoto.Height = 768;
            pbPhoto.Width = 512;
            pbPhoto.BorderRadius = 0;
            pbPhoto.Margin = padding;
        }

        void initiaPramsContent(int x, int y)
        {
            Point p = new Point(x, y);
            plContent.Location = p;
        }

        private void plInputs_Click(object sender, EventArgs e)
        {
            if (plKeys.Visible)
            {
                plKeys.Visible = false;
                initiaPramsContent(88, 275);
            }
            else
            {
                plKeys.Visible = true;
                initiaPramsContent(88, 180);
            }
        }

        private void btnNouveu_Click(object sender, EventArgs e)
        {
            bool VS = true;
            BunifuTextBox ele;
            foreach (Control item in plInputs.Controls)
            {
                ele = (BunifuTextBox)item;

                if (ele.Text.Length==0 && VS)
                {
                    BunifuButton sender1 = (BunifuButton)sender;
                    ele.Text = sender1.Text;
                    MotPasse = MotPasse + ele.Text ;
                    VS = false;
                    lastEntry = ele;
                    if (MotPasse.Length == 4) btnLogin.Enabled = true;
                    continue;

                }
                else
                {
                    continue;
                }
                ele.Focus();
                break;
            }
        }

        private void btnDeleteC_Click(object sender, EventArgs e)
        {
            if(MotPasse.Length!=0) MotPasse = MotPasse.Remove(MotPasse.Length - 1);
            if (MotPasse.Length != 4) btnLogin.Enabled = false;
            lastEntry.Text = "";
            foreach (Control item in plInputs.Controls)
            {
                BunifuTextBox ele = (BunifuTextBox)item;
                if (ele.Text.Length != 0 ){ lastEntry = ele;}
            }

        }

        private void btnImg_Click(object sender, EventArgs e)
        {

            Program.IsLogin = true;
            this.Hide();
            mainForm mainForm = new mainForm();
            mainForm.Show();
            
        }

        private void txtC1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }


        void txt_vide(BunifuTextBox txt)
        {
            if (txt.Text!="")
            {
                txt.Text = "";
            }
        }
    }
}
