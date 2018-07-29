using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SenseInventoryLogoDA;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace SenseInventoryLogoBL
{
    public class clsPurchaseItemMasterMember
    {
        public int PurchaseItemMasterKey { get; set; }
        public String PurchaseItemMasterName { get; set; }
        public int PurchaseItemMasterGroupFKey { get; set; }
        public Decimal PurchaseItemMasterRate { get; set; }
        public String PurchaseItemMasterDescription { get; set; }
        public int CompanyID { get; set; }
        public String Mode { get; set; }
        public int UserID { get; set; }
        public String PurchaseItemMasterGroupFKeyName { get; set; }
        public Decimal PurchaseItemMasterStock { get; set; }
        public String PurchaseItemMasterImage { get; set; }
        public Decimal PurchaseItemMasterJobRate { get; set; }
        public String PurchaseItemMasterType     { get;set;}
        public String PurchaseItemMasterHsnCode  { get;set; }
    }
    public class clsPurchaseItemMaster : clsPurchaseItemMasterMember
    {
        public int AddUpdateDelete()
        {
            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.CRUDConnString);
                SqlParameter[] objParam = new SqlParameter[]
                        {
                            new SqlParameter("@PurchaseItemMasterKey"                ,   PurchaseItemMasterKey           ),
                            new SqlParameter("@PurchaseItemMasterName"               ,   PurchaseItemMasterName          ),
                            new SqlParameter("@PurchaseItemMasterGroupFKey"          ,   PurchaseItemMasterGroupFKey     ),
                            new SqlParameter("@PurchaseItemMasterRate"               ,   PurchaseItemMasterRate          ),
                            new SqlParameter("@PurchaseItemMasterDescription"        ,   PurchaseItemMasterDescription   ),
                            new SqlParameter("@PurchaseItemMasterStock"              ,   PurchaseItemMasterStock         ),
                            new SqlParameter("@PurchaseItemMasterImage"              ,   PurchaseItemMasterImage         ),
                            new SqlParameter("@PurchaseItemMasterJobRate"            ,   PurchaseItemMasterJobRate       ),
                            new SqlParameter("@PurchaseItemMasterType"               ,   PurchaseItemMasterType          ),
                            new SqlParameter("@PurchaseItemMasterHsnCode"            ,   PurchaseItemMasterHsnCode       ),


                            new SqlParameter("@CompanyID"                            ,   CompanyID                       ),
                            new SqlParameter("@UserID"		                         ,   UserID	                         ), 
                            new SqlParameter("@Action"                               ,	 Mode	                         )
                        };                                                           

                int result = Convert.ToInt32(objSql.ExecuteScalar("PurchaseItemMasterSave", objParam));
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<clsPurchaseItemMasterMember> GetPurchaseItemMaster()
        {
            List<clsPurchaseItemMasterMember> objList = new List<clsPurchaseItemMasterMember>();

            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[] 
                        {
                            new SqlParameter("@PurchaseItemMasterKey"	         ,   PurchaseItemMasterKey        ),

                            new SqlParameter("@UserID"                   ,   UserID                ),
                            new SqlParameter("@CompanyID"	             ,   CompanyID             ),
                            new SqlParameter("@Action"                   ,   Mode                  ) 
                        };

                DataSet ds = objSql.ExecuteDataSet("PurchaseItemMasterGet", objParams);

                if (ds != null)
                {
                    clsPurchaseItemMasterMember objPurchaseItems = new clsPurchaseItemMasterMember();

                    #region PurchaseItemMaster
                    if (ds.Tables.Count > 0)
                    {
                        foreach (DataRow r in ds.Tables[0].Rows)
                        {
                            objPurchaseItems.PurchaseItemMasterKey = Convert.ToInt32(r["PurchaseItemMasterKey"] ?? -1);
                            objPurchaseItems.PurchaseItemMasterName = (r["PurchaseItemMasterName"] ?? "").ToString();
                            objPurchaseItems.PurchaseItemMasterGroupFKey = Convert.ToInt32(r["PurchaseItemMasterGroupFKey"] ?? -1);
                            objPurchaseItems.PurchaseItemMasterRate = Convert.ToDecimal(r["PurchaseItemMasterRate"] ?? -1);
                            objPurchaseItems.PurchaseItemMasterDescription = (r["PurchaseItemMasterDescription"] ?? "").ToString();
                            objPurchaseItems.PurchaseItemMasterStock = Convert.ToDecimal(r["PurchaseItemMasterStock"] ?? -1);
                            objPurchaseItems.PurchaseItemMasterImage = (r["PurchaseItemMasterImage"] ?? "").ToString();
                            objPurchaseItems.PurchaseItemMasterJobRate = Convert.ToDecimal(r["PurchaseItemMasterJobRate"] ?? -1);
                            objPurchaseItems.PurchaseItemMasterType    = (r["PurchaseItemMasterType"] ?? "").ToString();
                            objPurchaseItems.PurchaseItemMasterHsnCode = (r["PurchaseItemMasterHsnCode"] ?? "").ToString();
                            objList.Add(objPurchaseItems);
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

        public DataSet GetAllPurchaseItems()
        {
            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[] 
                        {
                            new SqlParameter("@PurchaseItemMasterKey"	 ,   PurchaseItemMasterKey         ),
                                                                        
                            new SqlParameter("@UserID"                   ,   UserID                ),
                            new SqlParameter("@CompanyID"	             ,   CompanyID             ),
                            new SqlParameter("@Action"                   ,   Mode                  ) 
                        };
                DataSet ds = objSql.ExecuteDataSet("PurchaseItemMasterGet", objParams);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet GetSearchPurchaseItems()
        {
            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[] 
                                {
                                    new SqlParameter("@PurchaseItemMasterGroupFKey"   ,   PurchaseItemMasterGroupFKey      ),
                                    new SqlParameter("@PurchaseItemMasterName"		  ,   PurchaseItemMasterName		   ),
                                    new SqlParameter("@PurchaseItemMasterRate"		  ,   PurchaseItemMasterRate		   ),

                                    new SqlParameter("@UserID"                        ,   UserID                   ),
                                    new SqlParameter("@CompanyID"	                  ,   CompanyID                ),
                                    new SqlParameter("@Action"                        ,   Mode                     ) 
                                };
                DataSet ds = objSql.ExecuteDataSet("PurchaseItemMasterSearch", objParams);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet GetPurchaseItemGroupPurchaseItems()
        {
            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[] 
                        {
                            new SqlParameter("@PurchaseItemMasterGroupFKey"	 ,   PurchaseItemMasterGroupFKey         ),
                            new SqlParameter("@UserID"                       ,   UserID                      ),
                            new SqlParameter("@CompanyID"	                 ,   CompanyID                   ),
                            new SqlParameter("@Action"                       ,   "SELECTALL"                 ) 
                        };
                DataSet ds = objSql.ExecuteDataSet("PurchaseItemGroupPurchaseItemMasterGet", objParams);
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
                //if (PurchaseItemMasterGroupFKeyName.Equals("Please Select PurchaseItem Group") || PurchaseItemMasterGroupFKeyName.Length == 0)
                //{
                //    msg = "Please Select the PurchaseItem Group";
                //}
                if (PurchaseItemMasterName.Length.Equals(0))
                {
                    msg = msg.Length > 0 ? msg + "\n Please Enter the PurchaseItem Name" : msg + "Please Enter the PurchaseItem Name";
                }
                //if (PurchaseItemMasterType.Equals("Select Type"))
                //{
                //    msg = msg.Length > 0 ? msg + "\n Please Enter the Purchase Item Type" : msg + "Please Enter the Purchase Item Type";
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
