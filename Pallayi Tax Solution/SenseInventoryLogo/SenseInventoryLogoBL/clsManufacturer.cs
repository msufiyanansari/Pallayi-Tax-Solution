using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SenseInventoryLogoDA;
using System.Data;
using System.Data.SqlClient;
namespace SenseInventoryLogoBL
{
    public class clsManufacturerMasterMember
    {
        public int      ManufacturerMasterKey                               { get; set; }
        public String   ManufacturerMasterDate                              { get; set; }
        public int      ManufacturerMasterPurchaseKey                       { get; set; }
        public String   ManufacturerMasterPurchaseDate                      { get; set; }
        public String   ManufacturerMasterPurchaseInvoiceNo                 { get; set; }
        public String   ManufacturerMasterPurchaseSupplierName              { get; set; }
        public String   ManufacturerMasterPurchaseSupplierAddress           { get; set; }
        public String   ManufacturerMasterXML                               { get; set; }
        public List<clsManufacturerDetailMember> lstManufacturerDetail      { get; set; }

        public int     CompanyID                                            { get; set; }
        public String  Mode                                                 { get; set; }
        public int     UserID                                               { get; set; }
    }
    public class clsManufacturerMaster : clsManufacturerMasterMember
    {
        public clsManufacturerMasterMember GetManufacturerMasterDetail()
        {
            clsManufacturerMasterMember objList = new clsManufacturerMasterMember();
            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[]
                {
                    new SqlParameter("@ManufacturerMasterKey"                      ,   ManufacturerMasterKey        ),
                    new SqlParameter("@ManufacturerMasterPurchaseKey"              ,   ManufacturerMasterPurchaseKey),

                    new SqlParameter("@UserID"                                      ,   UserID                      ),
                    new SqlParameter("@CompanyID"                                   ,   CompanyID                   ),
                    new SqlParameter("@Action"                                      ,   Mode                        )
                };
                DataSet ds = objSql.ExecuteDataSet("ManufacturerMasterGet", objParams);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            foreach (DataRow r in ds.Tables[0].Rows)
                            {
                                objList.ManufacturerMasterKey                       = Convert.ToInt32((r["ManufacturerMasterKey"] ?? -1).ToString());
                                objList.ManufacturerMasterDate                      = (r["ManufacturerMasterDate"] ?? "").ToString();
                                objList.ManufacturerMasterPurchaseKey               = Convert.ToInt32((r["ManufacturerMasterPurchaseKey"] ?? -1).ToString());
                                objList.ManufacturerMasterPurchaseDate              = (r["ManufacturerMasterPurchaseDate"] ?? "").ToString();
                                objList.ManufacturerMasterPurchaseInvoiceNo         = (r["ManufacturerMasterPurchaseInvoiceNo"] ?? "").ToString();
                                objList.ManufacturerMasterPurchaseSupplierName      = (r["ManufacturerMasterPurchaseSupplierName"] ?? "").ToString();
                                objList.ManufacturerMasterPurchaseSupplierAddress   = (r["ManufacturerMasterPurchaseSupplierAddress"] ?? "").ToString();
                            }
                        }
                    }
                    objList.lstManufacturerDetail                                   = clsManufacturerDetailMember.ManufacturerDetailList(ds.Tables[1]);
                }
                return objList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet ManufacturerMasterDetailSearch()
        {
            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[]
                {
                    new SqlParameter("@ManufacturerMasterPurchaseInvoiceNo"         ,   ManufacturerMasterPurchaseInvoiceNo                      ),
                    new SqlParameter("@UserID"                                      ,   UserID                                                   ),
                    new SqlParameter("@CompanyID"                                   ,   CompanyID                                                ),
                    new SqlParameter("@Action"                                      ,   Mode                                                     )
                };
                DataSet ds = objSql.ExecuteDataSet("ManufacturerMasterDetailSearch", objParams);
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
                            new SqlParameter("@ManufacturerMasterKey"                ,   ManufacturerMasterKey           ),
                            new SqlParameter("@ManufacturerMasterDate"               ,   ManufacturerMasterDate          ),
                            new SqlParameter("@ManufacturerMasterPurchaseKey"        ,   ManufacturerMasterPurchaseKey   ),
                            new SqlParameter("@ManufacturerMasterXML"                ,   ManufacturerMasterXML           ),
                         
                            new SqlParameter("@CompanyID"   	                     ,   CompanyID   	                 ),
                            new SqlParameter("@Action"   	                         ,   Mode   	                     ),
                            new SqlParameter("@UserID"   	                         ,   UserID   	                     )
                        };
                int result = objSql.ExecuteNonQuery("ManufacturerMasterSave", objParam);
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
                if (ManufacturerMasterPurchaseInvoiceNo.Equals("Please Select Invoice"))
                {
                    msg = "Please Select the Invoice No";
                }
                return msg;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
    public class clsManufacturerDetailMember:clsManufacturerMasterMember
        {
            public int      ManufacturerDetailKey                    {get;set;}
            public int      ManufacturerDetailPurchaseItemKey        {get;set;}
            public String   ManufacturerDetailPurchaseItemKeyName    {get;set;}
            public int      ManufacturerDetailSalesItemKey           {get;set;}
            public Decimal  ManufacturerDetailUsedQty                {get;set;}
            public Decimal  ManufacturerDetailPurchaseStock          {get;set;}
            public Decimal  ManufacturerDetailMadeQty                {get;set;}
            public Decimal  ManufacturerDetailMasterKey              {get;set;}
            public int      ManufacturerDetailSelected               {get;set;}
            public Decimal  ManufacturerDetailPurchaseQty            {get;set;}
            public Decimal  ManufacturerDetailWeight                 {get;set;}
            public static List<clsManufacturerDetailMember> ManufacturerDetailList(DataTable dtManufacturerList)
            {
                try
                {
                    List<clsManufacturerDetailMember> objManufacturerDetailList = new List<clsManufacturerDetailMember>();
                    if (dtManufacturerList.Rows.Count > 0)
                    {
                        //int RowIndex = 1;
                        foreach (DataRow r in dtManufacturerList.Rows)
                        {
                            objManufacturerDetailList.Add(new clsManufacturerDetailMember
                            {
                                ManufacturerDetailKey                   = Convert.ToInt32((r["ManufacturerDetailKey"] ?? -1)),
                                ManufacturerDetailPurchaseItemKey       = Convert.ToInt32((r["ManufacturerDetailPurchaseItemKey"] ?? -1)),
                                ManufacturerDetailPurchaseItemKeyName   = (r["ManufacturerDetailPurchaseItemKeyName"] ?? "").ToString(),
                                ManufacturerDetailSalesItemKey          = Convert.ToInt32((r["ManufacturerDetailSalesItemKey"] ?? -1)),
                                ManufacturerDetailUsedQty               = Convert.ToDecimal((r["ManufacturerDetailUsedQty"] ?? 0)),
                                ManufacturerDetailPurchaseStock         = Convert.ToDecimal((r["ManufacturerDetailPurchaseStock"] ?? 0)),
                                ManufacturerDetailMadeQty               = Convert.ToDecimal((r["ManufacturerDetailMadeQty"] ?? 0)),
                                ManufacturerDetailMasterKey             = Convert.ToInt32((r["ManufacturerDetailMasterKey"] ?? -1)),
                                ManufacturerDetailSelected              = Convert.ToInt32((r["ManufacturerDetailSelected"] ?? -1)),
                                ManufacturerDetailPurchaseQty           = Convert.ToDecimal((r["ManufacturerDetailPurchaseQty"] ?? 0)),
                                ManufacturerDetailWeight                = Convert.ToDecimal((r["ManufacturerDetailWeight"] ?? 0)),
                            });
                        }
                    }
                    return objManufacturerDetailList;
                }
                catch (Exception ex)
                {
                    return null;
                    throw ex;
                }
            }

        }
}
