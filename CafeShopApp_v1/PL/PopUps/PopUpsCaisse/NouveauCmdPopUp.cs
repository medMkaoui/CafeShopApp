using CafeShopApp_v1.BL;
using System;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;

namespace CafeShopApp_v1.PL.SubUserControle.PlCaisse
{
    public partial class NouveauCmdPopUp : Form
    {
        BL.Cfe_shop_dbEntities Db = new BL.Cfe_shop_dbEntities();
        BL.GlobalMethods globalMethods = new BL.GlobalMethods();
        BL.commande CMD;
        private bool Ready = false;
        public bool isReady()
        {
            return Ready;
        }

        public NouveauCmdPopUp(BL.commande cmd =null)
        {
            InitializeComponent();
            fillddLiv();
            fillddEspace();
            Ready = true;
            if (!Db.infos.FirstOrDefault().Liveraison)
            {
                lblLiv.Enabled = false; rdLiv.Enabled = false;
            }
            CMD = cmd;
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

        void fillddLiv()
        {
            ddSteLiv.DataSource = Db.ste_livraisons.AsParallel().ToList();
            ddSteLiv.DisplayMember = "name_ste";
            ddSteLiv.ValueMember = "id_ste";
        }

        void fillddEspace()
        {
            ddEspace.DataSource = Db.espaces.AsParallel().ToList();
            ddEspace.DisplayMember = "name_espace";
            ddEspace.ValueMember = "id_espace";
            ddEspace.SelectedIndex = 0;
        }

        void fillddTables()
        {
            if (this.isReady())
            {
                int id = (int)(ddEspace.SelectedValue);
                ddTable.DataSource = Db.tb_tables.Where(ele => ele.espace == id && ele.statu == "Vide").ToList();
                ddTable.DisplayMember = "name_table";
                ddTable.ValueMember = "id_table";
            }

        }

        

        private void lblLiv_Click(object sender, EventArgs e)
        {
            rdTable.Checked = false; rdEmporter.Checked = false; rdLiv.Checked = true;
            plContent.Visible = true;
            plTable.Visible = false;
            plLiv.Visible = true;
            this.Height = 295;
            this.Refresh();
        }


        private void lblTable_Click(object sender, EventArgs e)
        {
            rdTable.Checked = true; rdEmporter.Checked = false; rdLiv.Checked = false;
            plContent.Visible = true;
            plTable.Visible = true;
            plLiv.Visible = false;
            this.Height = 295;
        }

        private void lblEmp_Click(object sender, EventArgs e)
        {
            rdTable.Checked = false; rdEmporter.Checked = true; rdLiv.Checked = false;
            plContent.Visible = false;
            this.Height = 205;
            this.Refresh();

        }

        private void ddEspace_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillddTables();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            
            
            

            if (rdEmporter.Checked)
            {
                CaisseForm.CMD.type_cmd = "Emporter";
                CaisseForm.caisseForm.txtTypeCmd.Text = "Emporter";
            }
            else if (rdLiv.Checked)
            {
                CaisseForm.CMD.type_cmd = "Livraison"; 
                CaisseForm.CMD.delivery_company = (int)ddSteLiv.SelectedValue;
                CaisseForm.caisseForm.txtTypeCmd.Text = "Livraison";
            }
            else { 
                CaisseForm.CMD.type_cmd = "à Table";
                CaisseForm.caisseForm.txtTypeCmd.Text = "à Table"; 
                CaisseForm.CMD.t_able = ddTable.Text; 
            }
            if (CMD.t_able != null)
            {
                tb_tables tb = Db.tb_tables.Where(ele => ele.name_table == CMD.t_able).FirstOrDefault();
                tb.statu = "Réservé";
                Db.tb_tables.AddOrUpdate(tb);
            }
            Db.commandes.Add(CMD);
            Db.SaveChanges();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
