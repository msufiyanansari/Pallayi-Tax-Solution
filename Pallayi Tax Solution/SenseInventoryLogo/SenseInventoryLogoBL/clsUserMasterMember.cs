using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SenseInventoryLogoDA;
using System.Runtime.Serialization;

namespace SenseInventoryLogoBL
{
    public class clsUserMasterMember 
    {
        public int    UserID             {get;set;}
        public String UserFirstName      {get;set;}
        public String UserLastName       {get;set;}
        public String UserName           {get;set;}
        public String UserPassword       {get;set;}
        public String UserEmail          {get;set;}
        public String UserAddress        {get;set;}
        public int    UserStateFKey      {get;set;}
        public int    UserCityFKey       {get;set;}
        public int    UserAreaFKey       {get;set;}
        public String UserPhone          {get;set;}
        public int    UserRollFKey       {get;set;}
        public int    UserIsActive       {get;set;}
        public int    CompanyID          {get;set;}
        public String Mode               {get;set;}
    }

    public class clsUserMaster : clsUserMasterMember
    {

        public List<clsUserMasterMember> GetUserData()
        {
            List<clsUserMasterMember> objList = new List<clsUserMasterMember>();

            try
            {

                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[]
                {
                    new SqlParameter("@UserID"          ,   UserID              ),
                    new SqlParameter("@UserName"        ,   UserName            ),
                    new SqlParameter("@UserPassword"    ,   UserPassword        ),

                    new SqlParameter("@CompanyID"       ,   CompanyID           ),
                    new SqlParameter("@Action"          ,   Mode                )
                };

                DataSet ds = objSql.ExecuteDataSet("UserMasterGet", objParams);
                if (ds != null)
                {
                    clsUserMasterMember UM = new clsUserMasterMember();
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            foreach (DataRow r in ds.Tables[0].Rows)
                            {
                                UM.UserID = Convert.ToInt32((r["UserID"] ?? -1).ToString());
                                UM.UserFirstName = (r["UserFirstName"] ?? "").ToString();
                                UM.UserLastName = (r["UserLastName"] ?? "").ToString();
                                UM.UserName = (r["UserName"] ?? "").ToString();
                                UM.UserPassword = (r["UserPassword"] ?? "").ToString();
                                UM.UserEmail = (r["UserEmail"] ?? "").ToString();
                                UM.UserAddress = (r["UserAddress"] ?? "").ToString();
                                UM.UserStateFKey = Convert.ToInt32((r["UserStateFKey"] ?? -1).ToString());
                                UM.UserCityFKey = Convert.ToInt32((r["UserCityFKey"] ?? -1).ToString());
                                UM.UserAreaFKey = Convert.ToInt32((r["UserAreaFKey"] ?? -1).ToString());
                                UM.UserPhone = (r["UserPhone"] ?? "").ToString();
                                UM.UserRollFKey = Convert.ToInt32((r["UserRollFKey"] ?? -1).ToString());
                                UM.UserIsActive = Convert.ToInt32((r["UserIsActive"] ?? -1).ToString());
                                objList.Add(UM);
                            }
                        }
                    }
                }
                return objList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int AddUpdateDelete()
        {
            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.CRUDConnString);
                SqlParameter[] objParam = new SqlParameter[]
                        {
                            new SqlParameter("@UserID"             ,   UserID           ),
                            new SqlParameter("@UserFirstName"      ,   UserFirstName    ),
                            new SqlParameter("@UserLastName"       ,   UserLastName     ),
                            new SqlParameter("@UserName"           ,   UserName         ),
                            new SqlParameter("@UserPassword"       ,   UserPassword     ),
                            new SqlParameter("@UserEmail"          ,   UserEmail        ),
                            new SqlParameter("@UserAddress"        ,   UserAddress      ),
                            new SqlParameter("@UserStateFKey"      ,   UserStateFKey    ),
                            new SqlParameter("@UserCityFKey"       ,   UserCityFKey     ),
                            new SqlParameter("@UserAreaFKey"       ,   UserAreaFKey     ),
                            new SqlParameter("@UserPhone"          ,   UserPhone        ),
                            new SqlParameter("@UserRollFKey"       ,   UserRollFKey     ), 
                            new SqlParameter("@UserIsActive"       ,   UserIsActive     ),
                            new SqlParameter("@Action"   	       ,   Mode   	        ),
                            new SqlParameter("@CompanyID"   	   ,   CompanyID   	    ),
                        };
                int result = objSql.ExecuteNonQuery("UserMasterSave", objParam);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public String AuthenticateValidate()
        {
            String msg = String.Empty;
            if (UserName.Length.Equals(0))
            {
                msg = "Please Enter the User Name";
            }
            if(UserPassword.Length.Equals(0))
            {
                msg = msg.Length > 0 ? msg + "\n Please Enter the PassWord" : msg + "Please Enter the PassWord";
            }
            if (CompanyID.Equals(0))
            {
                msg = msg.Length > 0 ? msg + "\n Please Select the Company" : msg + "Please Select the Company";
            }
            return msg;
        }
    }
}
