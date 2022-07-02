using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeShopApp_v1
{
    static class Program
    {
        public static bool IsLogin = false;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (IsLogin)
            {
                Application.Run(new PL.mainForm());
        }
            else
            {
                Application.Run(new PL.LoginForm());
            }

}
}
}
