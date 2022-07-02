
using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeShopApp_v1.PL.DesignCode
{
    class Methods
    {
        BL.Cfe_shop_dbEntities Db = new BL.Cfe_shop_dbEntities();
        public void hideSubMenu(Panel Pl1, Panel Pl2)
        {
            Pl1.Visible = false;
            Pl2.Visible = false;
        }

       
        public void validationDecimal(BunifuTextBox bunifuTextBox)
        {
            if (!(bunifuTextBox.Text == string.Empty))
            {
                if (!decimal.TryParse(bunifuTextBox.Text, out decimal x))
                {
                    MessageBox.Show("Veuillez n'entrer que des chiffres.");
                    bunifuTextBox.Text = string.Empty;
                    bunifuTextBox.Focus();
                }
            }
        }

        public void validationTime(BunifuTextBox bunifuTextBox)
        {
            if (!(bunifuTextBox.Text == string.Empty))
            {
                if (bunifuTextBox.Enabled == true && !(System.Text.RegularExpressions.Regex.IsMatch(bunifuTextBox.Text, "^(2[0-3]|[01]?[0-9]):([0-5]?[0-9])$")))
                {
                    MessageBox.Show("Veuillez entrer une heure correcte.\n par exemple 16:30");
                    bunifuTextBox.Text = string.Empty;
                    bunifuTextBox.Focus();
                }
            }
        }

        public void ValidationPassWordInt(BunifuTextBox bunifuTextBox)
        {
            if (bunifuTextBox.Text.Length == 4 )
            {
                ValidationInt(bunifuTextBox);
                
            }else
            {
                MessageBox.Show("Le mot de passe doit être en 4 chiffre");
            }
            
        } 
        
        public void ValidationInt(BunifuTextBox bunifuTextBox)
        {
            if (!(bunifuTextBox.Text == string.Empty))
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(bunifuTextBox.Text, "[^0-9]"))
                {
                    MessageBox.Show("Veuillez n'entrer que des chiffres.");
                    bunifuTextBox.Text = string.Empty;
                }
            }
        }


        public void ActiveCatStyle(SubUserControle.UserCatCard CatCardAll)
        {
            CatCardAll.BackColor = Color.FromArgb(138, 195, 137);
            CatCardAll.lblContProd.ForeColor = Color.WhiteSmoke;
            CatCardAll.lblName.ForeColor = Color.White;
        }
        public void NormalCat(SubUserControle.UserCatCard CatCardAll)
        {
            CatCardAll.BackColor = Color.White;
            CatCardAll.lblContProd.ForeColor = Color.DarkGray;
            CatCardAll.lblName.ForeColor = Color.Black;
        }


        public void showSubMenu(Panel Pl)
        {
            if (Pl.Visible == true)
            {
                Pl.Visible = false;
            }
            else
            {
                Pl.Visible = true;
            }
        }
    }
}
