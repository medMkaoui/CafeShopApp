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
    public partial class DashboardForm : UserControl
    {
        BL.Cfe_shop_dbEntities Db = new BL.Cfe_shop_dbEntities();
        BL.GlobalMethods methods = new BL.GlobalMethods();
        public DashboardForm()
        {
            InitializeComponent();

            var totalVisiteur = Db.get_montant_total_cmd_visiteur().FirstOrDefault();
            if(totalVisiteur != null) lblCountVisiteur.Text = totalVisiteur.ToString() + " MAD"; else lblCountVisiteur.Text ="00.00 MAD";
            
            var totalcmd = Db.get_data_daily_rapport(DateTime.Now).FirstOrDefault();
            if(totalVisiteur != null) lblTotalCmd.Text = totalVisiteur.ToString() + " MAD"; else lblTotalCmd.Text ="00.00 MAD";

            var totalGain = Db.get_montant_total_all_cmd().FirstOrDefault();
            if (totalVisiteur != null) lblTotalGain.Text = totalVisiteur.ToString() + " MAD"; else lblTotalGain.Text = "00.00 MAD";



        }
    }
}
