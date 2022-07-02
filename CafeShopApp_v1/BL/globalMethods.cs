using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeShopApp_v1.BL
{
    class GlobalMethods
    {

        BL.Cfe_shop_dbEntities Db = new BL.Cfe_shop_dbEntities();
        public byte[] ConvertImgToByte(Image img)
        {
            if (img != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms,img.RawFormat);
                    return ms.ToArray();
                }
            }
            return null;
        }


        public void SaveData(BL.Cfe_shop_dbEntities Db)
        {
            try
            {
                Db.SaveChanges();
                MessageBox.Show("Opération réussie", "Message de Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MessageBox.Show("une erreur s'est produite", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

}

        public bool CheckUserPrivilege(string PNNam)
        {
            int button = Db.users_privileges.SqlQuery("select * from users_privileges where id_Utilisateur = CONVERT(nvarchar," + 1 + ") and " + PNNam + " = 1").ToList().Count();
            if (button>0){ return true;} else{return false;}
        }

        public Image ConvertByteToImg(byte[] data)
        {
            if (data != null)
            {
                using (MemoryStream ms = new MemoryStream(data))
                {
                   return Image.FromStream(ms);
                }
            }
            return null;
        }

        public void ControlsEmpty(BunifuPanel pl)
        {
            foreach(Control Item in pl.Controls)
            {
                if(Item is BunifuTextBox)
                {
                   BunifuTextBox Item1=(BunifuTextBox)Item; 
                    Item1.Text = "";
                }
                
                if(Item is BunifuDropdown)
                {
                    BunifuDropdown Item1 =(BunifuDropdown)Item; 
                    Item1.ResetText();
                }
            }
        }

        public string Encrypte_Pass(string Pass)
        {
            double Password =int.Parse(Pass);
            Password = ( Math.Pow(Password,2)+88);
            return Password.ToString();
        }  
        public string Decrypte_Pass(string Pass)
        {
            double Password =int.Parse(Pass);
            Password = Math.Sqrt(Password-88);
            return Password.ToString();
        }
    }
}
