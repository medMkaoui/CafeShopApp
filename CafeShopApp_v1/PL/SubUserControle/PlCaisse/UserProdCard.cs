using CafeShopApp_v1.PL.SubUserControle.PlCaisse;
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
    public partial class UserProdCard : UserControl
    {
        public static UserPlCmd userPlCmd = new PlCaisse.UserPlCmd();
         public UserProdCard()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int nbr = int.Parse(lblNbr.Text);
            if(nbr >= 0)
            {
                nbr += 1;
                lblNbr.Text = nbr.ToString();
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            int nbr = int.Parse(lblNbr.Text);

            if (nbr >= 0)
            {
                nbr -= 1;
                lblNbr.Text = nbr.ToString();
            }
        }

        public void AddRowToCmd()
        {
            UserRowProduitCmd Row = new UserRowProduitCmd();
            Row.lblTitleProd.Text = lblTitleProd.Text;
            Row.lblQteCmd.Text = lblNbr.Text;
            Row.lblId.Text = lblId.Text;
            Row.imgProd.Image = imgProd.Image;
            userPlCmd.plCmdRows.Controls.Add(Row);
        }

        private void UserProdCard_Click(object sender, EventArgs e)
        {
            var controls = CaisseForm.caisseForm.plContentCommandeRows.Controls;
            if (controls.Count == 0)
            {
                CaisseForm.caisseForm.plContentCommandeRows.Controls.Clear();
                CaisseForm.caisseForm.plContentCommandeRows.Controls.Add(userPlCmd);
            }
            else
            {
                foreach(Control ele in CaisseForm.caisseForm.plContentCommandeRows.Controls)
                {
                    userPlCmd = (UserPlCmd)ele;
                    break;
                }
            }
            bool exist = false;
            foreach (Control item in userPlCmd.plCmdRows.Controls)
            {
                var item1 = (UserRowProduitCmd)item;
                if (item1.lblId.Text == this.lblId.Text && item1.Height == 65)
                {
                    int Qte = int.Parse(item1.lblQteCmd.Text);
                    decimal prix = decimal.Parse(lblPrix.Text);
                    decimal mantant = Qte * prix;
                    decimal prixTotal = decimal.Parse(userPlCmd.lblMontantTotal.Text);

                    prixTotal -= mantant; 
                    Qte += int.Parse(lblNbr.Text);
                    item1.lblQteCmd.Text = Qte.ToString();
                    prixTotal += Qte * prix;
                    userPlCmd.lblMontantTotal.Text = prixTotal.ToString();
                    exist = true;
                    break;
                }
            }
            if (!exist)
            {
                AddRowToCmd();
            }
        }
    }
}
