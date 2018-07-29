using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace SenseInventoryLogoDA
{
    public class clsHelper
    {
        public enum DBCONNTYPE
        {
            GetConnString,
            CRUDConnString
        }
    }
}

