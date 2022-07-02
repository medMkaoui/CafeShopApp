using CafeShopApp_v1.BL;
using CafeShopApp_v1.PL.PopUps.PopUpsCaisse;
using CafeShopApp_v1.PL.SubUserControle.PlCaisse;
using CafeShopApp_v1.PL.SubUserControle.PlEtatB;
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
    public partial class CaisseForm : Form
    {
        BL.Cfe_shop_dbEntities Db = new BL.Cfe_shop_dbEntities();
        BL.GlobalMethods methods = new BL.GlobalMethods();
        public static CaisseForm caisseForm = new CaisseForm();
        public static commande CMD = new commande();
        Point point = new Point();

        public CaisseForm()
        {
            InitializeComponent();
            FillDdClient();
            caisseForm = this;
            ddClient.SelectedIndex = -1;
        }


        public void FillDdClient()
        {
            ddClient.DataSource = Db.get_all_clients().ToList();
            ddClient.DisplayMember = "name_client";
            ddClient.ValueMember = "id_client";
        }

        public void GetCategorie_Produit()
        {
            UserCategorie_Prod userCategorie_Prod = new UserCategorie_Prod();
            plContent.Controls.Clear();
            plContent.Controls.Add(userCategorie_Prod);
        }

        private void btnCaisse_Click(object sender, EventArgs e)
        {
            lblCmd.Visible = true;
            plEtatBoutiqueSide.Visible = false;
            plCarte.Width = 320;
            plContent.Width = 704;
            point.X = 704; point.Y = 58;
            plCarte.Location = point;
            btnNouveu.Enabled = true;
            plNew.Visible = true;
            btnCmdEnAttend.Enabled = true;
            txtTypeCmd.Enabled = false;
            GetCategorie_Produit();
            btnCaisse.Enabled = false;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            mainForm.MainForm.Show();
            mainForm.MainForm.Refresh();
            this.Close();
        }

        private void btnNouveu_Click(object sender, EventArgs e)
        {
            CMD.date_cmd = DateTime.Now;
            CMD.enattend = true;
            CMD.isready = false;
            CMD.montant_total = 00;
            CMD.montant_rest = 00;
            CMD.responsable = 1;
            CMD.statu = "non-Payé";
            if (ddClient.SelectedIndex != -1) CMD.client = (int)ddClient.SelectedValue; 
            CMD.created_at = DateTime.Now;

            plContentCommandeRows.Controls.Clear();
            NouveauCmdPopUp nouveauCmdPopUp = new NouveauCmdPopUp(CMD);
            nouveauCmdPopUp.ShowDialog();

            lblCountCmd.Text = "Commande N° : 0" + (Db.commandes.Count() + 1);
            lblId.Text = CMD.id_cmd.ToString();
            this.plContent.Enabled = true;
            ddClient.Enabled = true;
            this.btnNouveu.Enabled = false;
            txtTypeCmd.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            plContentCommandeRows.Controls.Clear();
            AttendCmd atndCMD = new AttendCmd();
            atndCMD.ShowDialog();
        }

        private void btnEtatBtq_Click(object sender, EventArgs e)
        {
            lblCmd.Visible = false;
            plEtatBoutiqueSide.Visible = true;
            btnMerge.Enabled = true;
            btnTransfer.Enabled = true;
            btnCaisse.Enabled = true;
            plNew.Visible = false;
            plContent.Enabled = true;
            plCarte.Width = 70;
            point.X = 954;  
            point.Y = 58;
            plCarte.Location = point;
            plContent.Width = 954;
            UserPlEtatBoutique userEpace_Tb = new UserPlEtatBoutique();
            plContent.Controls.Clear();
            plContent.Controls.Add(userEpace_Tb);
        }

        private void txtTypeCmd_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(lblId.Text);

            
            NouveauCmdPopUp popUp = new NouveauCmdPopUp();
            popUp.rdTable.Checked = true;
            popUp.ShowDialog();

            Db.SaveChanges();
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {

            BL.commande tb = UserTable.Cmd;

            foreach (UserTable item in UserPlEtatBoutique.userPlEtatBoutique.plTable.Controls)
            {
                if (item.checkMerge.Checked)
                {
                    UserTable.Cmd.t_able += "|" + Db.tb_tables.Find(int.Parse(item.lblId.Text)).name_table;
                    Db.tb_tables.Find(int.Parse(item.lblId.Text)).statu = "Réservé";
                }
            }
            Db.SaveChanges();
        }
    }
    }
