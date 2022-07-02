using CafeShopApp_v1.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeShopApp_v1.PL.SubUserControle.PlEtatB
{
    public partial class UserPlEtatBoutique : UserControl
    {
        BL.Cfe_shop_dbEntities Db = new  BL.Cfe_shop_dbEntities();
        BL.GlobalMethods methods = new  BL.GlobalMethods();
        public static UserPlEtatBoutique userPlEtatBoutique = new UserPlEtatBoutique();

        public UserPlEtatBoutique()
        {
            List<espace> espaces = Db.espaces.AsParallel().ToList();
            List<tb_tables> tables = Db.tb_tables.AsParallel().ToList();
            InitializeComponent();
            userPlEtatBoutique = this;
            getEspace(espaces);
            getTables(tables);
        }

        public void getEspace(List<espace> espaces)
        {
            plEspace.Controls.Clear();
            UserEspaceCard EspceCardAll = new UserEspaceCard();

            EspceCardAll.lblId.Text = (-1).ToString();
            EspceCardAll.BackColor = Color.FromArgb(138, 195, 137);
            EspceCardAll.lblName.ForeColor = Color.White;

            plEspace.Controls.Add(EspceCardAll);

            foreach (var espace in espaces)
            {
                UserEspaceCard EspaceCard = new UserEspaceCard();
                EspaceCard.lblId.Text = espace.id_espace.ToString();
                EspaceCard.lblName.Text = espace.name_espace;

                plEspace.Controls.Add(EspaceCard);
            }
        }
        public void getTables(List<tb_tables> tables)
        {
            plTable.Controls.Clear(); // clear 

            foreach (tb_tables table in tables)
            {
                UserTable ProdCard = new UserTable();
                ProdCard.lblId.Text = table.id_table.ToString();
                if (table.statu != "Vide") { ProdCard.BackColor = Color.FromArgb(138, 195, 137); ProdCard.lblTitleTable.ForeColor = Color.White; }
                ProdCard.lblTitleTable.Text = table.name_table;
                plTable.Controls.Add(ProdCard);
            }
        }
    }
}
