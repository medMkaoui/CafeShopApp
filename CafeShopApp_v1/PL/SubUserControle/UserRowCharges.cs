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
    public partial class UserRowCharges : UserControl
    {
        BL.Cfe_shop_dbEntities Db = new BL.Cfe_shop_dbEntities();
        public static UserRowCharges ClientRow = new UserRowCharges();

        public UserRowCharges()
        {
            InitializeComponent();
            

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Êtes-vous sûr de vouloir supprimer?.", "Message de confirmation ? ", MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                var charge = Db.charges.Find(int.Parse(lblId.Text));
                    Db.charges.Remove(charge);
                    Db.SaveChanges();
                    MessageBox.Show("Bien Supprimer");
                    AllChargesForm.ChargeForm.getCharges();
               
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            NewChargeForm newCharge = new NewChargeForm(int.Parse(lblId.Text));
            mainForm.MainForm.plYield.Controls.Clear();
            mainForm.MainForm.plYield.Controls.Add(newCharge);
        }

        private void btnDesc_Click(object sender, EventArgs e)
        {
            var charge = Db.charges.Find(int.Parse(lblId.Text));
            PopUps.ChargeInfoPopUP PopUpDesc = new PopUps.ChargeInfoPopUP(charge.montant.ToString(), charge.date_charge.Value.ToString("dd/mm/yyyy"), charge.user.name_user, charge.desc_charge);
            PopUpDesc.ShowDialog();
        }
    }
}
