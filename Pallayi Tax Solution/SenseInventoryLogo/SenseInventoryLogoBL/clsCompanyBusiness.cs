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
    public class clsCompanyBusinessMember
    {

        public int    CompanyBusinessKey            { get; set; }
        public String CompanyName                   { get; set; }
        public String CompanyBusinessTitle          { get; set; }
        public String CompanyBusinessDescription    { get; set; }
        public String CompanyBusinessAddress        { get; set; }
        public String CompanyBusinessContact1       { get; set; }
        public String CompanyBusinessContact2       { get; set; }
        public String CompanyBusinessGstTinNo       { get; set; }
        public String CompanyBusinessBankName       { get; set; }
        public String CompanyBusinessBankAcctNo     { get; set; }
        public String CompanyBusinessBankIFSCCode   { get; set; }
        public String CompanyBusinessBankBranch     { get; set; }
        public int CompanyID { get; set; }
        public String Mode { get; set; }
        public int UserID { get; set; }
        public String   CompanyStateName            {get;set;}
        public String   CompanyStateCode            {get;set;}
    }
    public class clsCompanyBusiness : clsCompanyBusinessMember
    {
        public List<clsCompanyBusinessMember> GetCompanyBusiness()
        {
            List<clsCompanyBusinessMember> objList = new List<clsCompanyBusinessMember>();

            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[]
                {
                    new SqlParameter("@CompanyBusinessKey"          ,   CompanyBusinessKey              ),

                    new SqlParameter("@UserID"                      ,   UserID                          ),
                    new SqlParameter("@CompanyID"                   ,   CompanyID                       ),
                    new SqlParameter("@Action"                      ,   Mode                            )
                };
                DataSet ds = objSql.ExecuteDataSet("CompanyBusinessDetailGet", objParams);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            foreach (DataRow r in ds.Tables[0].Rows)
                            {
                                clsCompanyBusinessMember UM = new clsCompanyBusinessMember();
                                UM.CompanyBusinessKey = Convert.ToInt32((r["CompanyBusinessKey"] ?? -1).ToString());
                                UM.CompanyName = (r["CompanyName"] ?? "").ToString();
                                UM.CompanyBusinessTitle = (r["CompanyBusinessTitle"] ?? "").ToString();
                                UM.CompanyBusinessDescription = (r["CompanyBusinessDescription"] ?? "").ToString();
                                UM.CompanyBusinessAddress = (r["CompanyBusinessAddress"] ?? "").ToString();
                                UM.CompanyBusinessContact1 = (r["CompanyBusinessContact1"] ?? "").ToString();
                                UM.CompanyBusinessContact2 = (r["CompanyBusinessContact2"] ?? "").ToString();
                                UM.CompanyBusinessGstTinNo = (r["CompanyBusinessGstTinNo"] ?? "").ToString();
                                UM.CompanyBusinessBankName = (r["CompanyBusinessBankName"] ?? "").ToString();
                                UM.CompanyBusinessBankAcctNo = (r["CompanyBusinessBankAcctNo"] ?? "").ToString();
                                UM.CompanyBusinessBankIFSCCode = (r["CompanyBusinessBankIFSCCode"] ?? "").ToString();
                                UM.CompanyBusinessBankBranch = (r["CompanyBusinessBankBranch"] ?? "").ToString();
                                UM.CompanyStateName          = (r["CompanyStateName"] ?? "").ToString();
                                UM.CompanyStateCode          = (r["CompanyStateCode"] ?? "").ToString();
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

        public DataSet GetAllCompany()
        {
            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[]
                {
                    new SqlParameter("@CompanyBusinessKey"          ,   CompanyBusinessKey              ),

                    new SqlParameter("@UserID"                      ,   UserID                          ),
                    new SqlParameter("@CompanyID"                   ,   CompanyID                       ),
                    new SqlParameter("@Action"                      ,   Mode                            )
                };
                DataSet ds = objSql.ExecuteDataSet("CompanyBusinessDetailGet", objParams);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet SearchCompanyDetail()
        {
            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[]
                {
                    new SqlParameter("@CompanyName"                     ,   CompanyName              ),
                    new SqlParameter("@CompanyBusinessAddress"          ,   CompanyBusinessAddress   ),

                    new SqlParameter("@UserID"                          ,   UserID                   ),
                    new SqlParameter("@CompanyID"                       ,   CompanyID                ),
                    new SqlParameter("@Action"                          ,   Mode                     )
                };
                DataSet ds = objSql.ExecuteDataSet("CompanyBusinessSearch", objParams);
                return ds;
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
                            new SqlParameter("@CompanyBusinessKey"             ,   CompanyBusinessKey            ),
                            new SqlParameter("@CompanyName"                    ,   CompanyName                   ),
                            new SqlParameter("@CompanyBusinessTitle"           ,   CompanyBusinessTitle          ),
                            new SqlParameter("@CompanyBusinessDescription"     ,   CompanyBusinessDescription    ),
                            new SqlParameter("@CompanyBusinessAddress"         ,   CompanyBusinessAddress        ),
                            new SqlParameter("@CompanyBusinessContact1"        ,   CompanyBusinessContact1       ),
                            new SqlParameter("@CompanyBusinessContact2"        ,   CompanyBusinessContact2       ),
                            new SqlParameter("@CompanyBusinessGstTinNo"        ,   CompanyBusinessGstTinNo       ),
                            new SqlParameter("@CompanyBusinessBankName"        ,   CompanyBusinessBankName       ),
                            new SqlParameter("@CompanyBusinessBankAcctNo"      ,   CompanyBusinessBankAcctNo     ),
                            new SqlParameter("@CompanyBusinessBankIFSCCode"    ,   CompanyBusinessBankIFSCCode   ),
                            new SqlParameter("@CompanyBusinessBankBranch"      ,   CompanyBusinessBankBranch     ), 
                            new SqlParameter("@CompanyStateName"               ,   CompanyStateName              ), 
                            new SqlParameter("@CompanyStateCode"               ,   CompanyStateCode              ), 

                            new SqlParameter("@CompanyID"   	               ,   CompanyID   	                 ),
                            new SqlParameter("@Action"   	                   ,   Mode   	                     ),
                        };
                int result = objSql.ExecuteNonQuery("CompanyBusinessSave", objParam);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public String Validation()
        {
            try
            {
                String msg = String.Empty;
                if (CompanyName.Length.Equals(0))
                {
                    msg = "Please Enter the Company Name";
                }
                if (CompanyBusinessAddress.Length.Equals(0))
                {
                    msg = msg.Length > 0 ? msg + "\n Please Enter the Company Address" : msg + "Please Enter the Company Address";
                }
                return msg;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
