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
    public class clsCustomerMasterMember
    {
        public int CustomerID { get; set; }
        public String CustomerName { get; set; }
        public String CustomerAddress { get; set; }
        public int CustomerStateFKey { get; set; }
        public int CustomerCityFKey { get; set; }
        public int CustomerAreaFKey { get; set; }
        public String CustomerContactNo { get; set; }
        public String CustomerEmail { get; set; }
        public String CustomerGSTNo { get; set; }
        public String CustomerGSTDate { get; set; }
        public String CustomerCSTDate { get; set; }
        public String CustomerCSTNo { get; set; }
        public int CustomerIsActive { get; set; }
        public int CompanyID { get; set; }
        public int UserID { get; set; }
        public String Mode { get; set; }
        public String CustomerContactPerson { get; set; }
        public String CustomerDetai         { get; set; }
        public String CustomerPanNo         { get; set; }    
    }
    public class clsCustomerMaster : clsCustomerMasterMember
    {
        public int AddUpdateDelete()
        {
            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.CRUDConnString);
                SqlParameter[] objParam = new SqlParameter[]
                {
                    new SqlParameter("@CustomerID"              ,   CustomerID            ),
                    new SqlParameter("@CustomerName"            ,   CustomerName          ),
                    new SqlParameter("@CustomerAddress"         ,   CustomerAddress       ),
                    new SqlParameter("@CustomerStateFKey"       ,   CustomerStateFKey     ),
                    new SqlParameter("@CustomerCityFKey"        ,   CustomerCityFKey      ),
                    new SqlParameter("@CustomerAreaFKey"        ,   CustomerAreaFKey      ),
                    new SqlParameter("@CustomerContactNo"       ,   CustomerContactNo     ),
                    new SqlParameter("@CustomerEmail"           ,   CustomerEmail         ),
                    new SqlParameter("@CustomerGSTNo"           ,   CustomerGSTNo         ),
                    new SqlParameter("@CustomerCSTNo"           ,   CustomerCSTNo         ),
                    new SqlParameter("@CustomerIsActive"        ,   CustomerIsActive      ),
                    new SqlParameter("@CustomerGSTDate"         ,   CustomerGSTDate       ),
                    new SqlParameter("@CustomerCSTDate"         ,   CustomerCSTDate       ),
                    new SqlParameter("@CustomerContactPerson"   ,   CustomerContactPerson ),
                    new SqlParameter("@CustomerPanNo"           ,   CustomerPanNo ),
                    
                    new SqlParameter("@UserID"		            ,   UserID	              ), 
                    new SqlParameter("@CompanyID"		        ,   CompanyID	          ),
                    new SqlParameter("@Action"                  ,	Mode	              )
                };
                int result = objSql.ExecuteNonQuery("CustomerMasterSave", objParam);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<clsCustomerMasterMember> GetCustomer()
        {
            List<clsCustomerMasterMember> objList = new List<clsCustomerMasterMember>();

            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[] 
                        {
                            new SqlParameter("@CustomerID"	 ,   CustomerID  ),
                                                                        
                            new SqlParameter("@UserID"       ,   UserID       ),
                            new SqlParameter("@CompanyID"	 ,   CompanyID    ),
                            new SqlParameter("@Action"       ,   Mode       ) 
                        };

                DataSet ds = objSql.ExecuteDataSet("CustomerMasterGet", objParams);

                if (ds != null)
                {
                    clsCustomerMasterMember objCustomer = new clsCustomerMasterMember();

                    #region Customer
                    if (ds.Tables.Count > 0)
                    {
                        foreach (DataRow r in ds.Tables[1].Rows)
                        {
                            objCustomer.CustomerID          = Convert.ToInt32(r["CustomerID"] ?? -1);
                            objCustomer.CustomerName        = (r["CustomerName"] ?? "").ToString();
                            objCustomer.CustomerAddress     = (r["CustomerAddress"] ?? "").ToString();
                            objCustomer.CustomerStateFKey   = Convert.ToInt32(r["CustomerStateFKey"] ?? -1);
                            objCustomer.CustomerCityFKey    = Convert.ToInt32(r["CustomerCityFKey"] ?? -1);
                            objCustomer.CustomerAreaFKey    = Convert.ToInt32(r["CustomerAreaFKey"] ?? -1);
                            objCustomer.CustomerContactNo   = (r["CustomerContactNo"] ?? "").ToString();
                            objCustomer.CustomerEmail       = (r["CustomerEmail"] ?? "").ToString();
                            objCustomer.CustomerGSTNo       = (r["CustomerGSTNo"] ?? "").ToString();
                            objCustomer.CustomerCSTNo       = (r["CustomerCSTNo"] ?? "").ToString();
                            objCustomer.CustomerIsActive    = Convert.ToInt32(r["CustomerActive"] ?? 0);
                            objCustomer.CompanyID           = Convert.ToInt32(r["CompanyID"] ?? 0);
                            objCustomer.CustomerGSTDate     = (r["CustomerGSTDate"] ?? "").ToString();
                            objCustomer.CustomerCSTDate     = (r["CustomerCSTDate"] ?? "").ToString();
                            objCustomer.CustomerDetai       = (r["CustomerDetai"] ?? "").ToString();
                            objCustomer.CustomerPanNo       = (r["CustomerPanNo"] ?? "").ToString();
                            objList.Add(objCustomer);
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

        public List<clsCustomerMasterMember> GetCustomerDetail()
        {
            List<clsCustomerMasterMember> objList = new List<clsCustomerMasterMember>();

            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[] 
                                {
                                    new SqlParameter("@CustomerID"	 ,   CustomerID  ),
                                                                                
                                    new SqlParameter("@UserID"       ,   UserID      ),
                                    new SqlParameter("@CompanyID"	 ,   CompanyID   ),
                                    new SqlParameter("@Action"       ,   Mode        ) 
                                };

                DataSet ds = objSql.ExecuteDataSet("CustomerMasterGet", objParams);

                if (ds != null)
                {
                    clsCustomerMasterMember objCustomer = new clsCustomerMasterMember();

                    #region Customer
                    if (ds.Tables.Count > 0)
                    {
                        foreach (DataRow r in ds.Tables[0].Rows)
                        {
                            objCustomer.CustomerDetai = (r["CustomerDetai"] ?? "").ToString();
                            objList.Add(objCustomer);
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

        public DataSet GetAllCustomer()
        {
            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[] 
                                {
                                    new SqlParameter("@CustomerID"	 ,   CustomerID   ),
                                    new SqlParameter("@UserID"       ,   UserID       ),
                                    new SqlParameter("@CompanyID"	 ,   CompanyID    ),
                                    new SqlParameter("@Action"       ,   Mode         ) 
                                };

                DataSet ds = objSql.ExecuteDataSet  ("CustomerMasterGet", objParams   );
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet GetSearchCustomer()
        {
            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[] 
                                {
                                    new SqlParameter("@CustomerName"	     ,   CustomerName		   ),
                                    new SqlParameter("@CustomerContactNo"	 ,   CustomerContactNo     ),
                                    new SqlParameter("@CustomerAddress"	     ,   CustomerAddress       ),

                                    new SqlParameter("@UserID"               ,   UserID                ),
                                    new SqlParameter("@CompanyID"	         ,   CompanyID             ),
                                    new SqlParameter("@Action"               ,   Mode                  ) 
                                };

                DataSet ds = objSql.ExecuteDataSet("CustomerMasterSearch", objParams);
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
                if (CustomerName.Length.Equals(0))
                {
                    msg = "Please Enter the Customer Name";
                }
                if (CustomerAddress.Length.Equals(0))
                {
                    msg = msg.Length > 0 ? msg + "\nPlease Enter the Customer Address" : msg + "Please Enter the Customer Address";
                }
                //if (CustomerCSTDate.Length.Equals(0))
                //{
                //    msg = msg.Length > 0 ? msg + "\nPlease Enter the Customer CST Date" : msg + "Please Enter the Customer CST Date";
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
