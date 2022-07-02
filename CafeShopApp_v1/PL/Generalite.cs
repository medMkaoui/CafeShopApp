using System;
using System.ComponentModel;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace CafeShopApp_v1.PL
{
    public partial class Generalite : UserControl
    {
        DesignCode.Methods methods = new DesignCode.Methods();
        BL.GlobalMethods GMethod = new BL.GlobalMethods();
        BL.Cfe_shop_dbEntities Db = new BL.Cfe_shop_dbEntities();
        Image img;
        public Generalite()
        {
            InitializeComponent();
            getInfoBoutique();
        }

        public void getInfoBoutique()
        {
            BL.info Info = Db.infos.FirstOrDefault();
            if (Info != null)
            {
                txtName.Text = Info.name_boutique;
                img = GMethod.ConvertByteToImg(Info.logo);
                txtTel.Text = Info.tel;
                txtEmail.Text = Info.email;
                txtAdresse.Text = Info.adresse;
                checkLiv_Ste.Checked = Info.Liveraison;
                chechPrix.Checked = Info.Prix_J_N;
                txtTimeDebut.Text = Info.Time_Debut_J.ToString(@"hh\:mm");
                txtTimeFin.Text = Info.Time_F_J.ToString(@"hh\:mm");
                txtTimeDebut.Enabled = txtTimeFin.Enabled = chechPrix.Checked;
                txtTimeFin.Modified = txtTimeDebut.Modified = chechPrix.Checked;
            }

        }
        private void txtTimeDebut_Validating(object sender, CancelEventArgs e)
        {
            methods.validationTime(txtTimeDebut);
        }
        private void txtTimeFin_Validating(object sender, CancelEventArgs e)
        {
            methods.validationTime(txtTimeFin);
        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "" && txtAdresse.Text.Trim() == "" && txtTel.Text.Trim() == "")
            {
                MessageBox.Show("Nom,Telephone et Adresse credit et Téléphone et email champ obligatoire", "Validation des information");
            }
            else
            {
                BL.info Info = Db.infos.FirstOrDefault();
                if (Info == null) Info = new BL.info();

                Info.name_boutique = txtName.Text;
                Info.logo = GMethod.ConvertImgToByte(img);
                Info.tel = txtTel.Text;
                Info.email = txtEmail.Text;
                Info.adresse = txtAdresse.Text;
                Info.Liveraison = checkLiv_Ste.Checked;
                Info.Prix_J_N = chechPrix.Checked;
                if (chechPrix.Checked ==true && txtTimeFin.Text.Trim() !="" && txtTimeDebut.Text.Trim() != "") { 
                    Info.Time_Debut_J = TimeSpan.Parse(txtTimeDebut.Text);
                    Info.Time_F_J = TimeSpan.Parse(txtTimeFin.Text);
                }
                Db.infos.AddOrUpdate(Info);
                GMethod.SaveData(Db);
            }
        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtImg.Text = "(1 fichier choisi)";
                    img = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void lblprixJN_Click(object sender, EventArgs e)
        {
            chechPrix.Checked = !chechPrix.Checked;
            chechPrix_OnChange(sender, e);

        }

        private void lblSteLiv_Click(object sender, EventArgs e)
        {
            checkLiv_Ste.Checked = !checkLiv_Ste.Checked;
        }

        private void chechPrix_OnChange(object sender, EventArgs e)
        {
            txtTimeDebut.Enabled = txtTimeFin.Enabled = chechPrix.Checked;
            txtTimeFin.Modified = txtTimeDebut.Modified = chechPrix.Checked;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            getInfoBoutique();
        }
    }
}
