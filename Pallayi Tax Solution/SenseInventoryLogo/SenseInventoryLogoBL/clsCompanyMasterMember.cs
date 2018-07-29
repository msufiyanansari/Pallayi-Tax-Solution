using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SenseInventoryLogoDA;
namespace SenseInventoryLogoBL
{
    public class clsCompanyMasterMember
    {
        public int CompanyMasterKey { get; set; }
        public String CompanyMasterAddress { get; set; }
        public int CompanyMasterStateFKey { get; set; }
        public int CompanyMasterCityFKey { get; set; }
        public int CompanyMasterAreaFkey { get; set; }
        public String CompanyMasterPhone1 { get; set; }
        public String CompanyMasterPhone2 { get; set; }
        public String CompanyMasterEmailAddress { get; set; }
        public String CompanyMasterContactPerson { get; set; }
        public String CompanyMasterStateFKeyName { get; set; }
        public String CompanyMasterCityFKeyName { get; set; }
        public String CompanyMasterAreaFkeyName { get; set; }
        public int CompanyMasterIsActive { get; set; }
        public String Mode               {get;set;}
        public int    UserID             {get;set;}
        public int    CompanyID          {get;set;}
    }
    public class clsCompanyMaster : clsCompanyMasterMember
    {
        public int AddUpdateDelete()
        {
            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.CRUDConnString);
                SqlParameter[] objParam = new SqlParameter[]
                {
                    new SqlParameter("@CompanyMasterKey"                ,   CompanyMasterKey              ),
                    new SqlParameter("@CompanyMasterAddress"            ,   CompanyMasterAddress          ),
                    new SqlParameter("@CompanyMasterStateFKey"          ,   CompanyMasterStateFKey        ),
                    new SqlParameter("@CompanyMasterCityFKey"           ,   CompanyMasterCityFKey         ),
                    new SqlParameter("@CompanyMasterAreaFkey"           ,   CompanyMasterAreaFkey         ),
                    new SqlParameter("@CompanyMasterPhone1"             ,   CompanyMasterPhone1           ),
                    new SqlParameter("@CompanyMasterPhone2"             ,   CompanyMasterPhone2           ),
                    new SqlParameter("@CompanyMasterEmailAddress"       ,   CompanyMasterEmailAddress     ),
                    new SqlParameter("@CompanyMasterContactPerson"      ,   CompanyMasterContactPerson    ),
                    new SqlParameter("@CompanyMasterIsActive"           ,   CompanyMasterIsActive         ),

                    new SqlParameter("@UserID"		                    ,   UserID	                      ), 
                    new SqlParameter("@CompanyID"		                ,   CompanyID	                  ),
                    new SqlParameter("@Action"                          ,	Mode	                      )
                };

                int result = objSql.ExecuteNonQuery("CompanyMasterSave", objParam);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<clsCompanyMasterMember> GetCompanyMaster()
        {
            List<clsCompanyMasterMember> objList = new List<clsCompanyMasterMember>();

            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[] 
                {
                    new SqlParameter("@CompanyMasterKey"	,   CompanyMasterKey    ),
                                                                
                    new SqlParameter("@UserID"              ,   UserID              ),
                    new SqlParameter("@CompanyID"	        ,   CompanyID           ),
                    new SqlParameter("@Action"              ,   Mode                ) 
                };

                DataSet ds = objSql.ExecuteDataSet("CompanyMasterGet", objParams);

                if (ds != null)
                {
                    clsCompanyMasterMember objCompanyMaster = new clsCompanyMasterMember();

                    #region Customer
                    if (ds.Tables.Count > 0)
                    {
                        foreach (DataRow r in ds.Tables[1].Rows)
                        {
                            objCompanyMaster.CompanyMasterKey = Convert.ToInt32(r["CompanyMasterKey"] ?? -1);
                            objCompanyMaster.CompanyMasterAddress = (r["CompanyMasterAddress"] ?? "").ToString();
                            objCompanyMaster.CompanyMasterStateFKey = Convert.ToInt32(r["CompanyMasterStateFKey"] ?? -1);
                            objCompanyMaster.CompanyMasterCityFKey = Convert.ToInt32(r["CompanyMasterCityFKey"] ?? -1);
                            objCompanyMaster.CompanyMasterAreaFkey = Convert.ToInt32(r["CompanyMasterAreaFkey"] ?? -1);
                            objCompanyMaster.CompanyMasterStateFKeyName = (r["CompanyMasterStateFKeyName"] ?? "").ToString();
                            objCompanyMaster.CompanyMasterCityFKeyName = (r["CompanyMasterCityFKeyName"] ?? "").ToString();
                            objCompanyMaster.CompanyMasterAreaFkeyName = (r["CompanyMasterAreaFkeyName"] ?? "").ToString();
                            objCompanyMaster.CompanyMasterPhone1 = (r["CompanyMasterPhone1"] ?? "").ToString();
                            objCompanyMaster.CompanyMasterPhone2 = (r["CompanyMasterPhone2"] ?? "").ToString();
                            objCompanyMaster.CompanyMasterEmailAddress = (r["CompanyMasterEmailAddress"] ?? "").ToString();
                            objCompanyMaster.CompanyMasterContactPerson = (r["CustomerEmail"] ?? "").ToString();
                            objCompanyMaster.CompanyMasterIsActive = Convert.ToInt32(r["CompanyMasterIsActive"] ?? -1);
                            objList.Add(objCompanyMaster);
                        }
                    }

                    #endregion
                }

                return objList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
