using CafeShopApp_v1.BL;
using CafeShopApp_v1.PL.SubUserControle;
using CafeShopApp_v1.PL.SubUserControle.PlCaisse;
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

namespace CafeShopApp_v1.PL.PopUps.PopUpsCaisse
{
    public partial class NotePupUp : Form
    {
        Cfe_shop_dbEntities Db = new Cfe_shop_dbEntities();
        GlobalMethods globalMethods = new GlobalMethods();

         UserRowProduitCmd userRowProduit = new UserRowProduitCmd();
        int idProd = 0;
        public NotePupUp(int id, UserRowProduitCmd userRow )
        {
            InitializeComponent();
            userRowProduit = userRow;
            idProd = id;
            Filldd();
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

        public void Filldd()
        {
            ddNotes.DataSource = Db.get_all_notes_by_categorie(Db.produits.Find(idProd).categorie_Vent).ToList();
            ddNotes.DisplayMember = "note";
            ddNotes.ValueMember = "id_note";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            plTxtAdd.Visible = true;
            this.Height = 235;
        }

        private void btnAddNoteDb_Click(object sender, EventArgs e)
        {
            if(txtAdd.Text != "")
            {
                var prod = Db.produits.Find(idProd);
                note note = Db.notes.Where(x => x.note1 == txtAdd.Text).FirstOrDefault();
                if (note == null) note = new note();

                note.note1 = txtAdd.Text;
                note.cat = prod.categorie_Vent;
                Db.notes.AddOrUpdate(note);
                globalMethods.SaveData(Db);
                txtAdd.Text = "";
                Filldd();
                this.Height = 180;
                plTxtAdd.Visible = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            UserNote note = new UserNote(ddNotes.Text);
            bool exist = false;
            foreach(Control item in userRowProduit.plUserNote.Controls)
            {
                UserNote n_ote = (UserNote)item;
                if(n_ote.lblNameNote.Text == ddNotes.Text)
                {
                    exist = true;
                    break;
                }
            }


            if (!exist)
            {
                userRowProduit.plUserNote.Controls.Add(note);
                if (userRowProduit.Height == 65) userRowProduit.Height += 18;
                userRowProduit.Height += 20;
                if (userRowProduit.Height == 180) userRowProduit.Height = 180;  
            }

           

            userRowProduit.Refresh();
            this.Close();
        }
    }
}
