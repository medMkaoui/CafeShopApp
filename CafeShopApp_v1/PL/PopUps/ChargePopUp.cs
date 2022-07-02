using System;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;

namespace CafeShopApp_v1.PL.PopUps
{
    public partial class ChargePopUp : Form
    {
        BL.Cfe_shop_dbEntities Db = new BL.Cfe_shop_dbEntities();
        BL.GlobalMethods globalMethods = new BL.GlobalMethods();
        string Res;
        public ChargePopUp(string Type)
        {
            InitializeComponent();
            Res = Type;
        }

        private const int CS_DropShadow = 0x00020000;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNewCharge.Text.Trim() == "")
            {
                MessageBox.Show("Ne peut pas jouter Une valeur vide", "Validation des information");
            }
            else
            {
                if(Res == "Tc")
                {
                    BL.type_charge chargeType = Db.type_charge.Where(x => x.type_charge1 == txtNewCharge.Text).FirstOrDefault();
                    if (chargeType == null) chargeType = new BL.type_charge();

                    chargeType.type_charge1 = txtNewCharge.Text;
                    Db.type_charge.AddOrUpdate(chargeType);
                    globalMethods.SaveData(Db);
                    NewChargeForm.NewCharge.FillDdTypeCharge();
                    this.Close();
                }
                else
                {
                    BL.mode_reg ModeReg = Db.mode_reg.Where(x => x.mod_reg == txtNewCharge.Text).FirstOrDefault();
                    if (ModeReg == null) ModeReg = new BL.mode_reg();
                    
                    ModeReg.mod_reg = txtNewCharge.Text;
                    Db.mode_reg.AddOrUpdate(ModeReg);
                    globalMethods.SaveData(Db);
                    NewChargeForm.NewCharge.FillDdModeReg();
                    this.Close();
                }
                
               
            }
        }
    }
}
