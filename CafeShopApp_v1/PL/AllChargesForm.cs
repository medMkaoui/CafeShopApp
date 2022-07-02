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
    public partial class AllChargesForm : UserControl
    {
        BL.Cfe_shop_dbEntities Db = new BL.Cfe_shop_dbEntities();
        BL.GlobalMethods methods = new BL.GlobalMethods();
        public static AllChargesForm ChargeForm = new AllChargesForm();
        public AllChargesForm()
        {
            InitializeComponent();
            getCharges();
            ChargeForm = this;
        }

        public void getCharges()
        {
            try
            {
                var Charges = Db.get_all_charges().ToList();
                lblCountClients.Text = Charges.Count().ToString() + " Charges(s)";
                plDgv.Controls.Clear();
                int i = 1;
                foreach (var Charge in Charges)
                {
                    SubUserControle.UserRowCharges row = new SubUserControle.UserRowCharges();
                    row.lblN.Text = i.ToString();
                    row.lblId.Text = Charge.id_charge.ToString();
                    row.lblType.Text = Charge.type_charge;
                    row.lblMontant.Text = Charge.montant.ToString();
                    var user = Db.users.Find((Charge.id_user));
                    row.lblResponsable.Text = user.name_user;
                    row.lblMode.Text = Charge.mode_reglement;
                    row.lblDate.Text = Charge.date_charge.ToString();

                    plDgv.Controls.Add(row);
                    i++;
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewChargeForm chargeForm = new NewChargeForm();
            chargeForm.lblNCharges.Text = " Charge N° : " + (Db.charges.Count() + 1);
            mainForm.MainForm.plYield.Controls.Clear();
            mainForm.MainForm.plYield.Controls.Add(chargeForm);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var Charges = Db.get_charges_by_str_search(txtSearch.Text);
                int i = 1;
                plDgv.Controls.Clear();
                foreach (var Charge in Charges)
                {
                    SubUserControle.UserRowCharges row = new SubUserControle.UserRowCharges();
                    row.lblN.Text = i.ToString();
                    row.lblId.Text = Charge.id_charge.ToString();
                    row.lblType.Text = Charge.type_charge;
                    row.lblMontant.Text = Charge.montant.ToString();
                    row.lblResponsable.Text = Charge.name_user;
                    row.lblMode.Text = Charge.mode_reglement;
                    row.lblDate.Text = Charge.date_charge.ToString();
                    plDgv.Controls.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
