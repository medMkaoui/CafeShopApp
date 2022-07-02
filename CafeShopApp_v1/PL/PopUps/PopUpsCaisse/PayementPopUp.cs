using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using CafeShopApp_v1.BL;
using CafeShopApp_v1.PL.SubUserControle.PlCaisse;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace CafeShopApp_v1.PL.PopUps.PopUpsCaisse
{


    public partial class PayementPopUp : Form
    {

        decimal Montant = 0;
        int Client = 0;
        Point point;
        BL.Cfe_shop_dbEntities Db = new BL.Cfe_shop_dbEntities();
        PL.DesignCode.Methods globalMethods = new DesignCode.Methods();
        public PayementPopUp(decimal montant, int idClient = -1)
        {
            InitializeComponent();
            Montant = montant;
            Client = idClient;
            FillDdModeReg();
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

        private void btnNouveu_Click(object sender, EventArgs e)
        {
           BunifuButton sender1 = (BunifuButton)sender;
           txtMontantPayer.Text += sender1.Text;
        }

        private void txtMontantPayer_Click(object sender, EventArgs e)
        {
            int height = (int)SystemParameters.FullPrimaryScreenHeight;
            int width = (int)SystemParameters.FullPrimaryScreenWidth;
            plKeys.Visible = true;
            point.X = (width - this.Width)/2;
            point.Y = (height -520) / 2;
            this.Location = point;
            this.Height = 520;
        }

        private void txtMontantPayer_TextChanged(object sender, EventArgs e)
        {

            globalMethods.ValidationInt(txtMontantPayer);
            if (txtMontantPayer.Text != "")
            {
                decimal MontantP = Decimal.Parse(txtMontantPayer.Text);
                txtRest.Text = ((Montant - MontantP)*-1).ToString();
                if(Montant > MontantP)
                {
                    btnOpenCaisse.Text = "Envoyer vers Credit";
                }
                else { btnOpenCaisse.Text = "Ovrir la caisse"; }
            }
            else txtRest.Text = "00.00";
            
        }

        private void btnDeleteC_Click(object sender, EventArgs e)
        {
            if(txtMontantPayer.Text.Length>0)txtMontantPayer.Text = txtMontantPayer.Text.Remove(txtMontantPayer.Text.Length - 1);        
            
        }

        public void FillDdModeReg()
        {
            ddModeReg.DataSource = Db.get_all_mode_reg().ToList();
            ddModeReg.DisplayMember = "mod_reg";
            ddModeReg.ValueMember = "id";
        }

        private void btnOpenCaisse_Click(object sender, EventArgs e)
        {
            if(btnOpenCaisse.Text == "Envoyer vers Credit")
            {
                decimal MontantP = Decimal.Parse(txtMontantPayer.Text);
                if (Client == -1)
                {
                    MessageBox.Show("chois le client");
                }
                else
                {
                    Db.reglements.Add(new BL.reglement() { date_reg = DateTime.Now, client = Client, montant = MontantP, mode_payment = ddModeReg.Text});
                    Db.commandes.Find(int.Parse(CaisseForm.caisseForm.lblId.Text)).enattend = false;
                    Db.commandes.Find(int.Parse(CaisseForm.caisseForm.lblId.Text)).client = Client;
                    Db.commandes.Find(int.Parse(CaisseForm.caisseForm.lblId.Text)).montant_rest = (Montant - MontantP);
                    Db.commandes.Find(int.Parse(CaisseForm.caisseForm.lblId.Text)).statu = "Payé";
                    if (Db.commandes.Find(int.Parse(CaisseForm.caisseForm.lblId.Text)).t_able != null)
                    {
                        String nameTb = Db.commandes.Find(int.Parse(CaisseForm.caisseForm.lblId.Text)).t_able;
                        string[] Tbls = nameTb.Split('|');
                        foreach (var tbl in Tbls)
                        {
                           Db.tb_tables.Where(ele => ele.name_table == tbl).FirstOrDefault().statu = "Vide";
                        }
                    }
                    Db.clients.Find(Client).total_credit += (Montant - MontantP);
                    UserPlCmd.userPl.btnEnAttend.PerformClick();
                }
            }
            else
            {
                if (txtMontantPayer.Text != "" )
                {
                    decimal MontantP = Decimal.Parse(txtMontantPayer.Text);
                    Db.commandes.Find(int.Parse(CaisseForm.caisseForm.lblId.Text)).enattend = false;
                    Db.commandes.Find(int.Parse(CaisseForm.caisseForm.lblId.Text)).statu = "Payé";
                    if (Db.commandes.Find(int.Parse(CaisseForm.caisseForm.lblId.Text)).t_able != null)
                    {
                        String nameTb = Db.commandes.Find(int.Parse(CaisseForm.caisseForm.lblId.Text)).t_able;
                        string[] Tbls = nameTb.Split('|');
                        foreach (var tbl in Tbls)
                        {
                            Db.tb_tables.Where(ele => ele.name_table == tbl).FirstOrDefault().statu = "Vide";
                        }
                    }


                    UserPlCmd.userPl.btnEnAttend.PerformClick();
                }
                
            }


            Db.SaveChanges();
            this.Close();



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
