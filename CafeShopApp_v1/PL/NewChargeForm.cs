using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeShopApp_v1.PL
{
    public partial class NewChargeForm : UserControl
    {
        BL.Cfe_shop_dbEntities Db = new BL.Cfe_shop_dbEntities();
        BL.GlobalMethods methods = new BL.GlobalMethods();
        public static NewChargeForm NewCharge = new NewChargeForm();
        public int IdCharge;
        public NewChargeForm(int id_charge = -1)
        {
            InitializeComponent();
            FillDdTypeCharge();
            FillDdModeReg();
            FillDdResponsble();
            getchargeById(id_charge);
            NewCharge = this;
        }

        public void FillDdTypeCharge()
        {
             ddType.DataSource = Db.get_all_type_charges().ToList();
             ddType.DisplayMember = "type_charge"; 
             ddType.ValueMember = "id"; 
        }

        public void FillDdModeReg()
        {
            ddModeReg.DataSource = Db.get_all_mode_reg().ToList();
            ddModeReg.DisplayMember = "mod_reg";
            ddModeReg.ValueMember = "id";
        }
        public void FillDdResponsble()
        {
            ddResponsable.DataSource = Db.get_all_users().ToList();
            ddResponsable.DisplayMember = "name_user";
            ddResponsable.ValueMember = "id_user";
        }
        public void getchargeById(int id)
        {
            BL.charge charge = Db.charges.Find(id);
            if (charge != null)
            {
                IdCharge = charge.id_charge;
                btnAjouter.Text = "Modifier";
                lblTitle.Text = "MODIFIER CHARGE";
                lblNCharges.Text = "charge : " + charge.type_charge;
                ddType.Text = charge.type_charge;
                txtMontant.Text = charge.montant.ToString();
                ddModeReg.Text = charge.mode_reglement;
                dpCharge.Value = (DateTime)charge.date_charge;
                txtDesc.Text = charge.desc_charge;
                ddResponsable.SelectedValue = (int)charge.responsable_charge;
            }

        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txtMontant.Text.Trim() == "" && ddResponsable.Text.Trim() == "" && ddType.Text.Trim() == "" && ddModeReg.Text.Trim() == "")
            {
                MessageBox.Show("Nom et max credit et Téléphone et email champ obligatoire", "Validation des information");
            }
            else
            {
                BL.charge charge = Db.charges.Find(IdCharge);
                if (charge == null) charge = new BL.charge();

                charge.type_charge = ddType.Text;
                charge.date_charge = (DateTime)dpCharge.Value;
                charge.responsable_charge = (int)ddResponsable.SelectedValue;
                charge.mode_reglement = ddModeReg.Text;
                charge.desc_charge = txtDesc.Text;
                charge.montant = decimal.Parse(txtMontant.Text);

                Db.charges.AddOrUpdate(charge);
                methods.SaveData(Db);
                getchargeById(IdCharge);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            methods.ControlsEmpty(mainPanel);
            IdCharge = -1;
            btnAjouter.Text = "Ajouter";
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            AllChargesForm chargeForm = new AllChargesForm();
            mainForm.MainForm.plYield.Controls.Clear();
            mainForm.MainForm.plYield.Controls.Add(chargeForm);
        }

        
        private void txtMontant_TextChanged(object sender, EventArgs e)
        {
            if (!(txtMontant.Text == string.Empty))
            {
                if (!decimal.TryParse(txtMontant.Text, out decimal x))
                {
                    MessageBox.Show("Veuillez n'entrer que des chiffres.");
                    txtMontant.Text = string.Empty;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PopUps.ChargePopUp PopUpNew = new PopUps.ChargePopUp("Tc");
            PopUpNew.ShowDialog();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            NewUserForm User = new NewUserForm(-1,true);
            this.Hide();
           mainForm.MainForm.plYield.Controls.Add(User);
        }

        private void btnAddReg_Click(object sender, EventArgs e)
        {
            PopUps.ChargePopUp PopUpNew = new PopUps.ChargePopUp("Rg");
            PopUpNew.lblTitle.Text = "NOUVEAU MODE DE REGLEMENT";
            PopUpNew.txtNewCharge.PlaceholderText = "Nouveu mode de réglement";
            PopUpNew.ShowDialog();
        }
    }
}
