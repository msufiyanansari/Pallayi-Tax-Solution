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
    public class clsItemMasterMember
    {
        public int              ItemMasterKey               {get;set;}
        public String           ItemMasterName              {get;set;}
        public int              ItemMasterGroupFKey         {get;set;}
        public Decimal          ItemMasterRate              {get;set;}
        public String           ItemMasterDescription       {get;set;}
        public int              CompanyID                   {get;set;}
        public String           Mode                        {get;set;}
        public int              UserID                      {get;set;}
        public String           ItemMasterGroupFKeyName     {get;set;}
        public Decimal          ItemMasterStock             {get;set;}
        public String           ItemMasterImage             {get;set;}
        public Decimal          ItemWeight                  {get;set;}
        public String           ItemMasterHsnCode           {get;set;}
    }
    public class clsItemMaster : clsItemMasterMember
    {
        public int AddUpdateDelete()
        {
            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.CRUDConnString);
                SqlParameter[] objParam = new SqlParameter[]
                        {
                            new SqlParameter("@ItemMasterKey"                ,   ItemMasterKey           ),
                            new SqlParameter("@ItemMasterName"               ,   ItemMasterName          ),
                            new SqlParameter("@ItemMasterGroupFKey"          ,   ItemMasterGroupFKey     ),
                            new SqlParameter("@ItemMasterRate"               ,   ItemMasterRate          ),
                            new SqlParameter("@ItemMasterDescription"        ,   ItemMasterDescription   ),
                            new SqlParameter("@ItemMasterStock"              ,   ItemMasterStock         ),
                            new SqlParameter("@ItemMasterImage"              ,   ItemMasterImage         ),
                            new SqlParameter("@ItemWeight"                   ,   ItemWeight              ),
                            new SqlParameter("@ItemMasterHsnCode"            ,   ItemMasterHsnCode              ),

        
                            new SqlParameter("@CompanyID"                    ,   CompanyID               ),
                            new SqlParameter("@UserID"		                 ,   UserID	                 ), 
                            new SqlParameter("@Action"                       ,	 Mode	                 )
                        };
                int result = Convert.ToInt32(objSql.ExecuteScalar("ItemMasterSave", objParam));
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<clsItemMasterMember> GetItemMaster()
        {
            List<clsItemMasterMember> objList = new List<clsItemMasterMember>();

            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[] 
                        {
                            new SqlParameter("@ItemMasterKey"	         ,   ItemMasterKey        ),

                            new SqlParameter("@UserID"                   ,   UserID                ),
                            new SqlParameter("@CompanyID"	             ,   CompanyID             ),
                            new SqlParameter("@Action"                   ,   Mode                  ) 
                        };

                DataSet ds = objSql.ExecuteDataSet("ItemMasterGet", objParams);

                if (ds != null)
                {
                    clsItemMasterMember objItems = new clsItemMasterMember();

                    #region ItemMaster
                    if (ds.Tables.Count > 0)
                    {
                        foreach (DataRow r in ds.Tables[0].Rows)
                        {
                            objItems.ItemMasterKey           = Convert.ToInt32(r["ItemMasterKey"] ?? -1);
                            objItems.ItemMasterName          = (r["ItemMasterName"] ?? "").ToString();
                            objItems.ItemMasterGroupFKey     = Convert.ToInt32(r["ItemMasterGroupFKey"] ?? -1);
                            objItems.ItemMasterRate          = Convert.ToDecimal(r["ItemMasterRate"] ?? -1);
                            objItems.ItemMasterDescription   = (r["ItemMasterDescription"] ?? "").ToString();
                            objItems.ItemMasterStock         = Convert.ToDecimal(r["ItemMasterStock"] ?? -1);
                            objItems.ItemMasterImage         = (r["ItemMasterImage"] ?? "").ToString();
                            objItems.ItemWeight              = Convert.ToDecimal(r["ItemWeight"] ?? -1);
                            objItems.ItemMasterHsnCode       = (r["ItemMasterHsnCode"] ?? "").ToString();
                            objList.Add(objItems);
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

        public DataSet GetAllItems()
        {
            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[] 
                        {
                            new SqlParameter("@ItemMasterKey"	         ,   ItemMasterKey         ),
                                                                        
                            new SqlParameter("@UserID"                   ,   UserID                ),
                            new SqlParameter("@CompanyID"	             ,   CompanyID             ),
                            new SqlParameter("@Action"                   ,   Mode                  ) 
                        };

                DataSet ds = objSql.ExecuteDataSet("ItemMasterGet", objParams);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet GetSearchItems()
        {
            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[] 
                                {
                                    new SqlParameter("@ItemMasterGroupFKey"   ,   ItemMasterGroupFKey      ),
                                    new SqlParameter("@ItemMasterName"		  ,   ItemMasterName		   ),
                                    new SqlParameter("@ItemMasterRate"		  ,   ItemMasterRate		   ),

                                    new SqlParameter("@UserID"                ,   UserID                   ),
                                    new SqlParameter("@CompanyID"	          ,   CompanyID                ),
                                    new SqlParameter("@Action"                ,   Mode                     ) 
                                };

                DataSet ds = objSql.ExecuteDataSet("ItemMasterSearch", objParams);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet GetItemGroupItems()
        {
            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[] 
                        {
                            new SqlParameter("@ItemMasterGroupFKey"	         ,   ItemMasterGroupFKey         ),
                            new SqlParameter("@UserID"                       ,   UserID                      ),
                            new SqlParameter("@CompanyID"	                 ,   CompanyID                   ),
                            new SqlParameter("@Action"                       ,   "SELECTALL"                 ) 
                        };
                DataSet ds = objSql.ExecuteDataSet("ItemGroupItemMasterGet", objParams);
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
                //if (ItemMasterGroupFKeyName.Equals("Please Select Item Group") || ItemMasterGroupFKeyName.Length==0)
                //{
                //    msg = "Please Select the Item Group";
                //}
                if (ItemMasterName.Length.Equals(0))
                {
                    msg = msg.Length > 0 ? msg + "\n Please Enter the Item Name" : msg + "Please Enter the Item Name";
                }
                //if (ItemWeight.Equals(0))
                //{
                //    msg = msg.Length > 0 ? msg + "\n Please Enter the Item Weight" : msg + "Please Enter the Item Weight";
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
