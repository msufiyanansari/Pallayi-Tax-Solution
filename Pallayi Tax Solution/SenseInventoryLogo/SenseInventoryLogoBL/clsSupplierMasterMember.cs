using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SenseInventoryLogoDA;

namespace SenseInventoryLogoBL
{
    public class clsSupplierMasterMember
    {
        public int SupplierID { get; set; }
        public String SupplierName { get; set; }
        public String SupplierAddress { get; set; }
        public int SupplierStateFKey { get; set; }
        public int SupplierCityFKey { get; set; }
        public int SupplierAreaFKey { get; set; }
        public String SupplierContactNo { get; set; }
        public String SupplierEmail { get; set; }
        public String SupplierGSTNo { get; set; }
        public String SupplierGSTDate { get; set; }
        public String SupplierCSTDate { get; set; }
        public String SupplierCSTNo { get; set; }
        public int SupplierIsActive { get; set; }
        public int CompanyID { get; set; }
        public int UserID { get; set; }
        public String Mode { get; set; }
        public String SupplierContactPerson { get; set; }
        public String SupplierDetai { get; set; }
    }
    public class clsSupplierMaster : clsSupplierMasterMember
    {
        public int AddUpdateDelete()
        {
            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.CRUDConnString);
                SqlParameter[] objParam = new SqlParameter[]
                {
                    new SqlParameter("@SupplierID"              ,   SupplierID            ),
                    new SqlParameter("@SupplierName"            ,   SupplierName          ),
                    new SqlParameter("@SupplierAddress"         ,   SupplierAddress       ),
                    new SqlParameter("@SupplierStateFKey"       ,   SupplierStateFKey     ),
                    new SqlParameter("@SupplierCityFKey"        ,   SupplierCityFKey      ),
                    new SqlParameter("@SupplierAreaFKey"        ,   SupplierAreaFKey      ),
                    new SqlParameter("@SupplierContactNo"       ,   SupplierContactNo     ),
                    new SqlParameter("@SupplierEmail"           ,   SupplierEmail         ),
                    new SqlParameter("@SupplierGSTNo"           ,   SupplierGSTNo         ),
                    new SqlParameter("@SupplierCSTNo"           ,   SupplierCSTNo         ),
                    new SqlParameter("@SupplierIsActive"        ,   SupplierIsActive      ),
                    new SqlParameter("@SupplierGSTDate"         ,   SupplierGSTDate       ),
                    new SqlParameter("@SupplierCSTDate"         ,   SupplierCSTDate       ),
                    new SqlParameter("@SupplierContactPerson"   ,   SupplierContactPerson ),

                    new SqlParameter("@UserID"		            ,   UserID	              ), 
                    new SqlParameter("@CompanyID"		        ,   CompanyID	          ),
                    new SqlParameter("@Action"                  ,	Mode	              )
                };

                int result = objSql.ExecuteNonQuery("SupplierMasterSave", objParam);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<clsSupplierMasterMember> GetSupplier()
        {
            List<clsSupplierMasterMember> objList = new List<clsSupplierMasterMember>();

            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[] 
                        {
                            new SqlParameter("@SupplierID"	 ,   SupplierID  ),
                                                                        
                            new SqlParameter("@UserID"       ,   UserID       ),
                            new SqlParameter("@CompanyID"	 ,   CompanyID    ),
                            new SqlParameter("@Action"       ,   Mode       ) 
                        };

                DataSet ds = objSql.ExecuteDataSet("SupplierMasterGet", objParams);

                if (ds != null)
                {
                    clsSupplierMasterMember objSupplier = new clsSupplierMasterMember();

                    #region Supplier
                    if (ds.Tables.Count > 0)
                    {
                        foreach (DataRow r in ds.Tables[1].Rows)
                        {
                            objSupplier.SupplierID = Convert.ToInt32(r["SupplierID"] ?? -1);
                            objSupplier.SupplierName = (r["SupplierName"] ?? "").ToString();
                            objSupplier.SupplierAddress = (r["SupplierAddress"] ?? "").ToString();
                            objSupplier.SupplierStateFKey = Convert.ToInt32(r["SupplierStateFKey"] ?? -1);
                            objSupplier.SupplierCityFKey = Convert.ToInt32(r["SupplierCityFKey"] ?? -1);
                            objSupplier.SupplierAreaFKey = Convert.ToInt32(r["SupplierAreaFKey"] ?? -1);
                            objSupplier.SupplierContactNo = (r["SupplierContactNo"] ?? "").ToString();
                            objSupplier.SupplierEmail = (r["SupplierEmail"] ?? "").ToString();
                            objSupplier.SupplierGSTNo = (r["SupplierGSTNo"] ?? "").ToString();
                            objSupplier.SupplierCSTNo = (r["SupplierCSTNo"] ?? "").ToString();
                            objSupplier.SupplierIsActive = Convert.ToInt32(r["SupplierActive"] ?? 0);
                            objSupplier.CompanyID = Convert.ToInt32(r["CompanyID"] ?? 0);
                            objSupplier.SupplierGSTDate = (r["SupplierGSTDate"] ?? "").ToString();
                            objSupplier.SupplierCSTDate = (r["SupplierCSTDate"] ?? "").ToString();
                            objSupplier.SupplierDetai = (r["SupplierDetai"] ?? "").ToString();
                            objList.Add(objSupplier);
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

        public List<clsSupplierMasterMember> GetSupplierDetail()
        {
            List<clsSupplierMasterMember> objList = new List<clsSupplierMasterMember>();

            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[] 
                                {
                                    new SqlParameter("@SupplierID"	 ,   SupplierID  ),
                                                                                
                                    new SqlParameter("@UserID"       ,   UserID      ),
                                    new SqlParameter("@CompanyID"	 ,   CompanyID   ),
                                    new SqlParameter("@Action"       ,   Mode        ) 
                                };

                DataSet ds = objSql.ExecuteDataSet("SupplierMasterGet", objParams);

                if (ds != null)
                {
                    clsSupplierMasterMember objSupplier = new clsSupplierMasterMember();

                    #region Supplier
                    if (ds.Tables.Count > 0)
                    {
                        foreach (DataRow r in ds.Tables[0].Rows)
                        {
                            objSupplier.SupplierDetai = (r["SupplierDetai"] ?? "").ToString();
                            objList.Add(objSupplier);
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

        public DataSet GetAllSupplier()
        {
            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[] 
                                {
                                    new SqlParameter("@SupplierID"	 ,   SupplierID   ),
                                    new SqlParameter("@UserID"       ,   UserID       ),
                                    new SqlParameter("@CompanyID"	 ,   CompanyID    ),
                                    new SqlParameter("@Action"       ,   Mode         ) 
                                };

                DataSet ds = objSql.ExecuteDataSet("SupplierMasterGet", objParams);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet GetSearchSupplier()
        {
            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[] 
                                {
                                    new SqlParameter("@SupplierName"	     ,   SupplierName		   ),
                                    new SqlParameter("@SupplierContactNo"	 ,   SupplierContactNo     ),
                                    new SqlParameter("@SupplierAddress"	     ,   SupplierAddress       ),

                                    new SqlParameter("@UserID"               ,   UserID                ),
                                    new SqlParameter("@CompanyID"	         ,   CompanyID             ),
                                    new SqlParameter("@Action"               ,   Mode                  ) 
                                };

                DataSet ds = objSql.ExecuteDataSet("SupplierMasterSearch", objParams);
                return ds;
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
                if (SupplierName.Length.Equals(0))
                {
                    msg = "Please Enter the Supplier Name";
                }
                if (SupplierAddress.Length.Equals(0))
                {
                    msg = msg.Length > 0 ? msg + "\nPlease Enter the Supplier Address" : msg + "Please Enter the Supplier Address";
                }
                //if (SupplierCSTDate.Length.Equals(0))
                //{
                //    msg = msg.Length > 0 ? msg + "\nPlease Enter the Supplier CST Date" : msg + "Please Enter the Supplier CST Date";
                //}
                return msg;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
