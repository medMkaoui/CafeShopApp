using System;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CafeShopApp_v1.PL
{
    public partial class espacesForm : UserControl
    {
        BL.Cfe_shop_dbEntities Db = new BL.Cfe_shop_dbEntities();
        BL.GlobalMethods methods = new BL.GlobalMethods();
        DesignCode.Methods DesignMethod = new DesignCode.Methods();
        public static espacesForm EspaceForm = new espacesForm();
        Image img;
        public int idEspace;
        public espacesForm()
        {
            InitializeComponent();
            EspaceForm = this;
            getEspaces();
        }

        public void getEspaces()
        {
            try{
                var Espaces = Db.get_all_espaces();
                plEspaces.Controls.Clear();
                foreach (var espace in Espaces)
                {
                    SubUserControle.UserEspace Espace = new SubUserControle.UserEspace();
                    Espace.lblNameEspace.Text = espace.name_espace;
                    Espace.lblNbrTables.Text = espace.nbr_tables.ToString()+" Table(s)";
                    plEspaces.Controls.Add(Espace);
                }
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() {  Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtNbrTable.Text ="(1 fichier choisi)";
                    img = Image.FromFile(ofd.FileName); 
                }
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if(txtName.Text.Trim() =="" && txtNbrTable.Text=="" )
            {
                MessageBox.Show("Nom d'espace  champ obligatoire");
            }
            else
            {
                BL.espace espace = Db.espaces.Find(this.idEspace);
                if (espace == null) espace = new BL.espace();
                espace.name_espace = txtName.Text;
                DesignMethod.ValidationInt(txtNbrTable);
                espace.nbr_tables = int.Parse(txtNbrTable.Text); 
                Db.espaces.AddOrUpdate(espace);
                methods.SaveData(Db);

                var tbExet = Db.tb_tables.Where(ele => ele.espace == espace.id_espace).ToList();

                if(tbExet != null)
                {
                    Db.tb_tables.RemoveRange(tbExet);
                    Db.SaveChanges();
                    CreateTb(espace, int.Parse(txtNbrTable.Text));

                }else { CreateTb(espace, int.Parse(txtNbrTable.Text));}
                
                getEspaces();
                btnAnnuler_Click(sender,e);
                idEspace = -1;
            }
        }

        public void CreateTb(BL.espace espace, int Count)
        {
            for (int i = 0; i < Count; i++)
            {
                BL.tb_tables tb = new BL.tb_tables();
                tb.name_table = espace.name_espace.ToUpper() + "-Tb-" + (i + 1);
                tb.espace = espace.id_espace;
                tb.statu = "Vide";
                Db.tb_tables.Add(tb);
                Db.SaveChanges();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            methods.ControlsEmpty(mainPanel);
            btnAjouter.Text = "Ajouter";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var Espace = Db.get_espaces_by_str_search(txtSearch.Text);
                plEspaces.Controls.Clear();
                foreach (var espace in Espace)
                {
                    SubUserControle.UserEspace Esp = new SubUserControle.UserEspace();
                    Esp.lblNameEspace.Text = espace.name_espace;
                    Esp.lblNbrTables.Text = espace.nbr_tables.ToString();
                    plEspaces.Controls.Add(Esp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
