using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenseInventoryLogoUI.Forms.Class
{
    public static class clsCommoan
    {
        public static String  GetDateInddMMYYYY(String date)
        {
            return date.Length>0 ? Convert.ToDateTime(date).ToString("MM/dd/yyyy"):String.Empty; 
        }
    }
}
