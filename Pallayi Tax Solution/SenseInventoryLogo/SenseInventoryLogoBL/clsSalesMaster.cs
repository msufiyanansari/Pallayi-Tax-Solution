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
    public class clsSalesMasterMember
    {
        public int      SalesMasterKey                              {get;set;}
        public String   SalesMasterDate                             {get;set;}
        public int      SalesMasterCustomerFKey                     {get;set;}
        public String   SalesMasterBillBookNo                       {get;set;}
        public String   SalesMasterInvoiceNo                        {get;set;}
        public String   SalesMasterInvoiceDate                      {get;set;}
        public String   SalesMasterChlnNo                           {get;set;}
        public String   SalesMasterChlnDate                         {get;set;}
        public Decimal  SalesMasterGrossTotal                       {get;set;}
        public Decimal  SalesMasterCartage                          {get;set;}
        public Decimal  SalesMasterSubTotal                         {get;set;}
        public Decimal  SalesMasterVatPerc                          {get;set;}
        public Decimal  SalesMasterVatAmount                        {get;set;}
        public int      UserID                                      {get;set;}
        public int      CompanyID                                   {get;set;}
        public String   Mode                                        {get;set;}
        public List<clsSalesTransactionMember> lstSalesTransaction  {get;set;}
        public String  SalesTransactionXML                          {get;set;}
        public Decimal SalesMasterMainTotal                         {get;set;}
        public String  SalesMasterCustomerDetail                    {get;set;}
        public String  SalesMasterCustomerFKeyName                  {get;set;}
        public String  SalesMasterCustomerFKeyAddress               {get;set;}
        public String  FromDate                                     {get;set;}
        public String  ToDate                                       {get;set;}
        public Decimal SalesMasterAddTaxPer                         {get;set;}
        public Decimal SalesMasterAddTaxAmt                         {get;set;}
        public Decimal SalesMasterDiscPer                           {get;set;}
        public Decimal SalesMasterDiscAmount                        {get;set;}
        public Decimal SalesMasterItemAmt                           {get;set;}
        public String  SalesMasterType                              {get;set;}
        public int     SalesMasterDiscountCalculate                 {get;set;}
        public List<clsSalesTransactionPaymentMember> lstSalesPayment { get; set; }
        public String SalesMasterPaymentXML                         {get;set;}
        public Decimal  SalesMasterPaidAmount                       {get;set;}
        public Decimal  SalesMasterPendingAmount                    {get;set;}
        public String   SalesMasterPoNo                             {get;set;}
        public String   TranMasterTransportDetail                   {get;set;}
        public String   SalesMasterNoofKey                          {get;set;}
        public Decimal  SalesMasterISGTPer                          {get;set;}
        public Decimal SalesMasterISGTAmount                        {get;set;}
        public String  SalesMasterReverseCharge                     {get;set;}
        public String  SalesMasterVehicleNo                         {get;set;}
        public String  SalesMasterActualDate                        {get;set;}
        public Decimal SalesMasterRoundoff                          {get;set;}
        public String SalesMasterRoundoffOption                     {get;set;}
        public String SalesMasterDelieveryNote	                    {get;set;}		
        public String SalesMasterSupplierRefNo			            {get;set;}
        public String SalesMasterOtherRefNo			                {get;set;}
        public String SalesMasterDispatchDocumentNo	                {get;set;}
        public String SalesMasterDispatchthrought		            {get;set;}
        public String SalesMasterDestination			            {get;set;}
        public String SalesMasterBillingofLading		            {get;set;}
       }
    public class clsSalesMaster : clsSalesMasterMember
    {
        public int AddUpdateDelete()
        {
            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.CRUDConnString);
                SqlParameter[] objParam = new SqlParameter[]
                {
                    new SqlParameter("@SalesMasterKey"            ,   SalesMasterKey              ),
                    new SqlParameter("@SalesMasterDate"           ,   SalesMasterDate             ),
                    new SqlParameter("@SalesMasterCustomerFKey"   ,   SalesMasterCustomerFKey     ),
                    new SqlParameter("@SalesMasterBillBookNo"     ,   SalesMasterBillBookNo       ),
                    new SqlParameter("@SalesMasterInvoiceNo"      ,   SalesMasterInvoiceNo        ),
                    new SqlParameter("@SalesMasterInvoiceDate"    ,   SalesMasterInvoiceDate      ),
                    new SqlParameter("@SalesMasterChlnNo"         ,   SalesMasterChlnNo           ),
                    new SqlParameter("@SalesMasterChlnDate"       ,   SalesMasterChlnDate         ),
                    new SqlParameter("@SalesMasterGrossTotal"     ,   SalesMasterGrossTotal       ),
                    new SqlParameter("@SalesMasterCartage"        ,   SalesMasterCartage          ),
                    new SqlParameter("@SalesMasterSubTotal"       ,   SalesMasterSubTotal         ),
                    new SqlParameter("@SalesMasterVatPerc"        ,   SalesMasterVatPerc          ),
                    new SqlParameter("@SalesMasterVatAmount"       ,   SalesMasterVatAmount       ),
                    new SqlParameter("@SalesTransactionXML"       ,   SalesTransactionXML         ),
                    new SqlParameter("@SalesMasterMainTotal"      ,   SalesMasterMainTotal        ),
                    new SqlParameter("@SalesMasterCustomerDetail" ,   SalesMasterCustomerDetail   ),
                    new SqlParameter("@SalesMasterAddTaxPer" ,        SalesMasterAddTaxPer        ),
                    new SqlParameter("@SalesMasterAddTaxAmt" ,        SalesMasterAddTaxAmt        ),
                    new SqlParameter("@SalesMasterDiscPer" ,          SalesMasterDiscPer          ),
                    new SqlParameter("@SalesMasterDiscAmount" ,       SalesMasterDiscAmount       ),
                    new SqlParameter("@SalesMasterItemAmt"    ,       SalesMasterItemAmt            ),
                    new SqlParameter("@SalesMasterType"       ,       SalesMasterType               ),
                    new SqlParameter("@SalesMasterDiscountCalculate", SalesMasterDiscountCalculate  ),
                    new SqlParameter("@SalesMasterPaymentXML"       , SalesMasterPaymentXML         ),
                    new SqlParameter("@SalesMasterPaidAmount"       , SalesMasterPaidAmount         ),
                    new SqlParameter("@SalesMasterPendingAmount"    , SalesMasterPendingAmount      ),
                    new SqlParameter("@SalesMasterPoNo"             , SalesMasterPoNo               ),
                    new SqlParameter("@TranMasterTransportDetail"   , TranMasterTransportDetail     ),
                    new SqlParameter("@SalesMasterISGTPer"          , SalesMasterISGTPer            ),
                    new SqlParameter("@SalesMasterISGTAmount"       , SalesMasterISGTAmount         ),
                    new SqlParameter("@SalesMasterReverseCharge"    , SalesMasterReverseCharge      ),
                    new SqlParameter("@SalesMasterVehicleNo"        , SalesMasterVehicleNo          ),
                    new SqlParameter("@SalesMasterRoundoff"        , SalesMasterRoundoff            ),
                    new SqlParameter("@SalesMasterRoundoffOption"  , SalesMasterRoundoffOption            ),
                    new SqlParameter("@SalesMasterDelieveryNote"  , SalesMasterDelieveryNote	    ),
                    new SqlParameter("@SalesMasterSupplierRefNo"  , SalesMasterSupplierRefNo		),
                    new SqlParameter("@SalesMasterOtherRefNo"  , SalesMasterOtherRefNo			),
                    new SqlParameter("@SalesMasterDispatchDocumentNo"  , SalesMasterDispatchDocumentNo	),
                    new SqlParameter("@SalesMasterDispatchthrought"  , SalesMasterDispatchthrought	),
                    new SqlParameter("@SalesMasterDestination"  , SalesMasterDestination		    ),
                    new SqlParameter("@SalesMasterBillingofLading"  , SalesMasterBillingofLading	    ),


                    new SqlParameter("@UserID"		              ,   UserID	                    ), 
                    new SqlParameter("@CompanyID"		          ,   CompanyID	                    ),
                    new SqlParameter("@Action"                    ,	  Mode	                        )
                };
                int result = Convert.ToInt32(objSql.ExecuteScalar("SalesMasterSave", objParam));
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet GetBillBookNoInvoiceNo()
        {
            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[] 
                        {
                            new SqlParameter("@Action"                   ,   "SELECTONE"                  ), 
                            new SqlParameter("@CompanyID"                ,   CompanyID                    ) 
                        };

                DataSet ds = objSql.ExecuteDataSet("BillBookInvoiceNoGet", objParams);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<clsSalesMasterMember> GetSalesMaster()
        {
            List<clsSalesMasterMember> objList = new List<clsSalesMasterMember>();
            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[] 
                {
                    new SqlParameter("@SalesMasterKey"	 ,   SalesMasterKey  ),
                                                                
                    new SqlParameter("@UserID"           ,   UserID          ),
                    new SqlParameter("@CompanyID"	     ,   CompanyID       ),
                    new SqlParameter("@Action"           ,   Mode            ) 
                };

                DataSet ds = objSql.ExecuteDataSet("SalesMasterGet", objParams);

                if (ds != null)
                {
                    clsSalesMasterMember objSalesMaster = new clsSalesMasterMember();
                    #region SalesMaster
                    if (ds.Tables.Count > 0)
                    {
                        foreach (DataRow r in ds.Tables[0].Rows)
                        {
                            objSalesMaster.SalesMasterKey             = Convert.ToInt32(r["SalesMasterKey"] ?? -1);
                            objSalesMaster.SalesMasterDate            = (r["SalesMasterDate"] ?? "").ToString();
                            objSalesMaster.SalesMasterCustomerFKey    = Convert.ToInt32(r["SalesMasterCustomerFKey"] ?? -1);
                            objSalesMaster.SalesMasterBillBookNo      = (r["SalesMasterBillBookNo"] ?? "").ToString();
                            objSalesMaster.SalesMasterInvoiceNo       = (r["SalesMasterInvoiceNo"] ?? "").ToString();
                            objSalesMaster.SalesMasterChlnNo          = (r["SalesMasterChlnNo"] ?? "").ToString();
                            objSalesMaster.SalesMasterChlnDate        = (r["SalesMasterChlnDate"] ?? "").ToString();
                            objSalesMaster.SalesMasterGrossTotal      = Convert.ToDecimal(r["SalesMasterGrossTotal"] ?? -1);
                            objSalesMaster.SalesMasterCartage         = Convert.ToDecimal(r["SalesMasterCartage"] ?? -1);
                            objSalesMaster.SalesMasterSubTotal        = Convert.ToDecimal(r["SalesMasterSubTotal"] ?? -1);
                            objSalesMaster.SalesMasterVatPerc         = Convert.ToDecimal(r["SalesMasterVatPerc"] ?? -1);
                            objSalesMaster.SalesMasterVatAmount        = Convert.ToDecimal(r["SalesMasterVatAmount"] ?? -1);
                            objSalesMaster.SalesMasterMainTotal       = Convert.ToDecimal(r["SalesMasterMainTotal"] ?? -1);
                            objSalesMaster.SalesMasterCustomerDetail  = (r["SalesMasterCustomerDetail"] ?? "").ToString();
                            objSalesMaster.SalesMasterAddTaxPer       = Convert.ToDecimal(r["SalesMasterAddTaxPer"] ?? -1);
                            objSalesMaster.SalesMasterAddTaxAmt       = Convert.ToDecimal(r["SalesMasterAddTaxAmt"] ?? -1);
                            objSalesMaster.SalesMasterDiscPer         = Convert.ToDecimal(r["SalesMasterDiscPer"] ?? -1);
                            objSalesMaster.SalesMasterDiscAmount      = Convert.ToDecimal(r["SalesMasterDiscAmount"] ?? -1);
                            objSalesMaster.SalesMasterItemAmt         = Convert.ToDecimal(r["SalesMasterItemAmt"] ?? -1);
                            objSalesMaster.SalesMasterType            = (r["SalesMasterType"] ?? "").ToString();
                            objSalesMaster.SalesMasterDiscountCalculate = Convert.ToInt32(r["SalesMasterDiscountCalculate"] ?? -1);
                            objSalesMaster.SalesMasterPaidAmount         = Convert.ToDecimal(r["SalesMasterPaidAmount"] ?? -1);
                            objSalesMaster.SalesMasterPendingAmount    = Convert.ToDecimal(r["SalesMasterPendingAmount"] ?? -1);
                            objSalesMaster.SalesMasterPoNo             = (r["SalesMasterPoNo"] ?? "").ToString();
                            objSalesMaster.TranMasterTransportDetail   = (r["TranMasterTransportDetail"] ?? "").ToString();
                            objSalesMaster.SalesMasterISGTPer          = Convert.ToDecimal(r["SalesMasterISGTPer"] ?? -1);
                            objSalesMaster.SalesMasterISGTAmount       = Convert.ToDecimal(r["SalesMasterISGTAmount"] ?? -1);
                            objSalesMaster.SalesMasterReverseCharge    = (r["SalesMasterReverseCharge"] ?? "").ToString();
                            objSalesMaster.SalesMasterVehicleNo        = (r["SalesMasterVehicleNo"] ?? "").ToString();
                            objSalesMaster.SalesMasterActualDate       = (r["SalesMasterActualDate"] ?? "").ToString();
                            objSalesMaster.SalesMasterRoundoff         = Convert.ToDecimal(r["SalesMasterRoundoff"] ?? -1);
                            objSalesMaster.SalesMasterRoundoffOption   = (r["SalesMasterRoundoffOption"] ?? "").ToString();
                            objSalesMaster.SalesMasterDelieveryNote	    = (r["SalesMasterDelieveryNote"] ?? "").ToString();
                            objSalesMaster.SalesMasterSupplierRefNo		= (r["SalesMasterSupplierRefNo"] ?? "").ToString();
                            objSalesMaster.SalesMasterOtherRefNo		= (r["SalesMasterOtherRefNo"] ?? "").ToString();
                            objSalesMaster.SalesMasterDispatchDocumentNo= (r["SalesMasterDispatchDocumentNo"] ?? "").ToString();
                            objSalesMaster.SalesMasterDispatchthrought	   = (r["SalesMasterDispatchthrought"] ?? "").ToString();
                            objSalesMaster.SalesMasterDestination		   = (r["SalesMasterDestination"] ?? "").ToString();
                            objSalesMaster.SalesMasterBillingofLading	   = (r["SalesMasterBillingofLading"] ?? "").ToString();
                        }
                    }
                    objList.Add(objSalesMaster);

                    #endregion

                    #region SalesMaster2SalesTransaction
                    if (ds.Tables.Count > 1)
                    {
                        List<clsSalesTransactionMember> objSalesMaster2SalesTransaction = new List<clsSalesTransactionMember>();
                        //int RowIndex = 1;
                        foreach (DataRow r in ds.Tables[1].Rows)
                        {
                            objSalesMaster2SalesTransaction.Add(new clsSalesTransactionMember
                            {
                                SalesTransactionKey                   = Convert.ToInt32((r["SalesTransactionKey"] ?? -1)),
                                SalesTransactionItemFKey              = Convert.ToInt32((r["SalesTransactionItemFKey"] ?? -1)),
                                SalesTransactionItemGroupFKey         = Convert.ToInt32((r["SalesTransactionItemGroupFKey"] ?? -1)),
                                SalesTransactionQty                   = Convert.ToInt32((r["SalesTransactionQty"] ?? -1)),
                                SalesTransactionRate                  = Convert.ToDecimal((r["SalesTransactionRate"] ?? 0)),
                                SalesTransactionTotal                 = Convert.ToDecimal((r["SalesTransactionTotal"] ?? 0)),
                                SalesTransactionSaleMasterFKey        = Convert.ToInt32((r["SalesTransactionSaleMasterFKey"] ?? -1)),
                                SalesTransactionItemGroupFKeyName     = (r["SalesTransactionItemGroupFKeyName"] ?? "").ToString(),
                                SalesTransactionItemFKeyName          = (r["SalesTransactionItemFKeyName"] ?? "").ToString(),
                                Mode                                  = (r["Mode"] ?? "").ToString(),
                                Index                                 = Convert.ToInt32((r["Index"] ?? -1)),
                                SalesTransactionPoNo                  = (r["SalesTransactionPoNo"] ?? "").ToString(),
                                SalesTransactionHsnCode               = (r["SalesTransactionHsnCode"] ?? "").ToString(),
                                SalesTransactionCGSTPer                 = Convert.ToDecimal((r["SalesTransactionCGSTPer"] ?? 0)),
                                SalesTransactionCGSTAmt                 = Convert.ToDecimal((r["SalesTransactionCGSTAmt"] ?? 0)),
                                SalesTransactionSGSTPer                 = Convert.ToDecimal((r["SalesTransactionSGSTPer"] ?? 0)),
                                SalesTransactionSGSTAmt                 = Convert.ToDecimal((r["SalesTransactionSGSTAmt"] ?? 0)),
                                SalesTransactionIGSTPer                 = Convert.ToDecimal((r["SalesTransactionIGSTPer"] ?? 0)),
                                SalesTransactionIGSTAmt                 = Convert.ToDecimal((r["SalesTransactionIGSTAmt"] ?? 0)),
                                SalesTransactionTaxableAmt              = Convert.ToDecimal((r["SalesTransactionTaxableAmt"] ?? 0)),
                            });
                        }
                        objSalesMaster.lstSalesTransaction            = objSalesMaster2SalesTransaction;
                    }
                    #endregion

                    #region SalesMaster2SalesPayment
                    if (ds.Tables.Count > 2)
                    {
                        List<clsSalesTransactionPaymentMember> objSalesMaster2SalesPayment = new List<clsSalesTransactionPaymentMember>();
                        //int RowIndex = 1;
                        foreach (DataRow r in ds.Tables[2].Rows)
                        {
                            objSalesMaster2SalesPayment.Add(new clsSalesTransactionPaymentMember
                            {
                                SalesTransactionPayKey            = Convert.ToInt32((r["SalesTransactionPayKey"] ?? -1)),
                                SalesTransactionPayType           = (r["SalesTransactionPayType"] ?? "").ToString(),
                                SalesTransactionPayDate           = (r["SalesTransactionPayDate"] ?? "").ToString(),
                                SalesTransactionPayBankFKey       = Convert.ToInt32((r["SalesTransactionPayBankFKey"] ?? -1)),
                                SalesTransactionPayBankFKeyName   = (r["SalesTransactionPayBankFKeyName"] ?? "").ToString(),
                                SalesTransactionPayBankChequeNo   = (r["SalesTransactionPayBankChequeNo"] ?? "").ToString(),
                                SalesTransactionPayAmount         = Convert.ToDecimal((r["SalesTransactionPayAmount"] ?? -1)),
                                SalesTransactionPayChequeDate     = (r["SalesTransactionPayChequeDate"] ?? "").ToString(),
                                Mode                              = (r["Mode"] ?? "").ToString(),
                                Index                             = Convert.ToInt32((r["Index"] ?? -1)),
                                SalesActualTransactionPayDate     = (r["SalesActualTransactionPayDate"] ?? "").ToString(),
                                SalesActualTransactionCheckDate   = (r["SalesActualTransactionCheckDate"] ?? "").ToString(),
                            });
                        }
                        objSalesMaster.lstSalesPayment            = objSalesMaster2SalesPayment;
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

        public DataSet GetSalesMasterReport()
        {
            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[] 
                {
                    new SqlParameter("@SalesMasterKey"	 ,   SalesMasterKey      ),

                    new SqlParameter("@SalesMasterNoofKey",  SalesMasterNoofKey  ),
                    new SqlParameter("@UserID"           ,   UserID              ),
                    new SqlParameter("@CompanyID"	     ,   CompanyID           ),
                    new SqlParameter("@Action"           ,   Mode                ) 
                };
                DataSet ds = objSql.ExecuteDataSet("SalesMasterReport", objParams);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet SearchSalesMaster()
        {
            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[] 
                                {
                                    new SqlParameter("@SalesMasterCustomerFKeyName"	     ,   SalesMasterCustomerFKeyName	  ),
                                    new SqlParameter("@SalesMasterCustomerFKeyAddress"	 ,   SalesMasterCustomerFKeyAddress	  ),
                                    new SqlParameter("@FromDate"	                     ,   FromDate						  ),
                                    new SqlParameter("@ToDate"	                         ,   ToDate							  ),
                                    new SqlParameter("@SalesMasterType"	                 ,   SalesMasterType				  ),

                                    new SqlParameter("@UserID"                           ,   UserID                           ),
                                    new SqlParameter("@CompanyID"	                     ,   CompanyID                        ),
                                    new SqlParameter("@Action"                           ,   Mode                             ) 
                                };

                DataSet ds = objSql.ExecuteDataSet("SalesMasterSearch", objParams);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet SearchSalesMasterItemSalesPaymentReport()
        {
            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[] 
                                {
                                    new SqlParameter("@SalesMasterCustomerFKey"	        ,   SalesMasterCustomerFKey	          ),
                                    new SqlParameter("@SalesMasterCustomerFKeyAddress"	 ,   SalesMasterCustomerFKeyAddress	  ),
                                    new SqlParameter("@FromDate"	                     ,   FromDate						  ),
                                    new SqlParameter("@ToDate"	                         ,   ToDate							  ),
                                    new SqlParameter("@SalesMasterType"	                 ,   SalesMasterType				  ),

                                    new SqlParameter("@UserID"                           ,   UserID                           ),
                                    new SqlParameter("@CompanyID"	                     ,   CompanyID                        ),
                                    new SqlParameter("@Action"                           ,   Mode                             ) 
                                };
                DataSet ds  = objSql.ExecuteDataSet("SalesMasterItemSalesPaymentReport", objParams);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataSet Report_SalesRegister()
        {
            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[] 
                                {
                                    new SqlParameter("@SalesMasterCustomerFKeyName"	     ,   SalesMasterCustomerFKeyName	  ),
                                    new SqlParameter("@SalesMasterCustomerFKeyAddress"	 ,   SalesMasterCustomerFKeyAddress	  ),
                                    new SqlParameter("@FromDate"	                     ,   FromDate						  ),
                                    new SqlParameter("@ToDate"	                         ,   ToDate							  ),

                                    new SqlParameter("@UserID"                           ,   UserID                           ),
                                    new SqlParameter("@CompanyID"	                     ,   CompanyID                        ),
                                    new SqlParameter("@Action"                           ,   Mode                             ) 
                                };
                DataSet ds = objSql.ExecuteDataSet("Report_SalesRegister", objParams);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet Report_SalesGSTReport()
        {
            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[] 
                                {
                                    new SqlParameter("@SalesMasterCustomerFKey"	         ,   SalesMasterCustomerFKey	      ),
                                    new SqlParameter("@FromDate"	                     ,   FromDate						  ),
                                    new SqlParameter("@ToDate"	                         ,   ToDate							  ),

                                    new SqlParameter("@UserID"                           ,   UserID                           ),
                                    new SqlParameter("@CompanyID"	                     ,   CompanyID                        ),
                                    new SqlParameter("@Action"                           ,   Mode                             ) 
                                };
                DataSet ds = objSql.ExecuteDataSet("Report_SalesGSTReport", objParams);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public String GetDateInddMMYYYY(String date)
        {
            return date.Length > 0 ? Convert.ToDateTime(date).ToString("MM/dd/yyyy") : String.Empty;
        }
    }

    public class clsSalesTransactionMember : clsSalesMasterMember
    {
        public int      SalesTransactionKey                 {get;set;}
        public int      SalesTransactionItemFKey            {get;set;}
        public Decimal  SalesTransactionQty { get; set; }
        public Decimal  SalesTransactionRate                {get;set;}
        public Decimal  SalesTransactionTotal               {get;set;}
        public int      SalesTransactionSaleMasterFKey      {get;set;}
        public int      Index                               {get;set;}
        public String   SalesTransactionItemFKeyName        {get;set;}
        public int      SalesTransactionItemGroupFKey       {get;set;}
        public String   SalesTransactionItemGroupFKeyName   {get;set;}
        public String   SalesTransactionPoNo                {get;set;}
        public String   SalesTransactionHsnCode             {get;set;}
        public Decimal SalesTransactionCGSTPer { get; set; }
        public Decimal SalesTransactionCGSTAmt { get; set; }
        public Decimal SalesTransactionSGSTPer { get; set; }
        public Decimal SalesTransactionSGSTAmt { get; set; }
        public Decimal SalesTransactionIGSTPer { get; set; }
        public Decimal SalesTransactionIGSTAmt { get; set; }
        public Decimal SalesTransactionTaxableAmt { get; set; }
        public int SalesTransactionUnitFKey { get; set; }
        public static List<clsSalesTransactionMember> AddUpdateDeleteSalesTransaction(clsSalesTransactionMember objSalesTransaction,List<clsSalesTransactionMember> lstTranSaction)
        {
            //List<clsSalesTransactionMember> lstTranSaction = new List<clsSalesTransactionMember>();
            try
            {
                int listIndex = 0;
                //if ((List<clsSalesTransactionMember>)HttpContext.Current.Cache[clsCacheKeys.Customer2ProductCacheKey] != null)
                //{
                //    lstTranSaction = (List<clsSalesTransactionMember>)HttpContext.Current.Cache[clsCacheKeys.Customer2ProductCacheKey];
                //    listIndex = lstTranSaction.Count;
                //}

                //var query = lstTranSaction.FindAll(x => x.CustomerFirstName.Equals(objSalesTransaction.CustomerFirstName) && x.Mode != "DELETE"
                //    && x.Index != objSalesTransaction.Index);
                //if (query.Count > 0)
                //{
                //    throw new Exception(SetMessageFormatLI("duplicate entry not allowed"));
                //}
                if (lstTranSaction != null)
                {
                    listIndex       =   lstTranSaction.Count;
                }

                if (objSalesTransaction.SalesTransactionKey == 0 && "ADD" == objSalesTransaction.Mode)
                {
                    lstTranSaction.Add(new clsSalesTransactionMember
                    {
                        SalesTransactionKey                     = objSalesTransaction.SalesTransactionKey       ,    
                        SalesTransactionItemFKey                = objSalesTransaction.SalesTransactionItemFKey  ,
                        SalesTransactionQty                     = objSalesTransaction.SalesTransactionQty       ,
                        SalesTransactionRate                    = objSalesTransaction.SalesTransactionRate      ,
                        SalesTransactionTotal                   = objSalesTransaction.SalesTransactionTotal     ,
                        SalesTransactionItemFKeyName            = objSalesTransaction.SalesTransactionItemFKeyName,
                        SalesTransactionItemGroupFKey           = objSalesTransaction.SalesTransactionItemGroupFKey,
                        SalesTransactionItemGroupFKeyName       = objSalesTransaction.SalesTransactionItemGroupFKeyName,
                        Mode                                    = objSalesTransaction.Mode,
                        Index                                   = listIndex + 1,
                        SalesTransactionPoNo                    = objSalesTransaction.SalesTransactionPoNo,
                        SalesTransactionHsnCode                 = objSalesTransaction.SalesTransactionHsnCode,
                        SalesTransactionCGSTPer                 = objSalesTransaction.SalesTransactionCGSTPer,
                        SalesTransactionCGSTAmt                 = objSalesTransaction.SalesTransactionCGSTAmt,
                        SalesTransactionTaxableAmt              = objSalesTransaction.SalesTransactionTaxableAmt,
                        SalesTransactionSGSTPer                 = objSalesTransaction.SalesTransactionSGSTPer,
                        SalesTransactionSGSTAmt                 = objSalesTransaction.SalesTransactionSGSTAmt,
                        SalesTransactionIGSTPer                 = objSalesTransaction.SalesTransactionIGSTPer,
                        SalesTransactionIGSTAmt                 = objSalesTransaction.SalesTransactionIGSTAmt,
                        SalesTransactionUnitFKey                = objSalesTransaction.SalesTransactionUnitFKey
                    });
                    listIndex += 1;
                }

                if (objSalesTransaction.SalesTransactionKey == 0 && "UPDATE" == objSalesTransaction.Mode)
                {
                    var EditList = lstTranSaction.Where(x => x.Index.Equals(objSalesTransaction.Index)).FirstOrDefault();

                    if (EditList != null)
                    {
                        EditList.SalesTransactionKey                = objSalesTransaction.SalesTransactionKey       ;       
                        EditList.SalesTransactionItemFKey           = objSalesTransaction.SalesTransactionItemFKey  ;
                        EditList.SalesTransactionQty                = objSalesTransaction.SalesTransactionQty       ;
                        EditList.SalesTransactionRate               = objSalesTransaction.SalesTransactionRate      ;
                        EditList.SalesTransactionTotal              = objSalesTransaction.SalesTransactionTotal     ;
                        EditList.SalesTransactionItemFKeyName       = objSalesTransaction.SalesTransactionItemFKeyName;
                        EditList.SalesTransactionItemGroupFKey      = objSalesTransaction.SalesTransactionItemGroupFKey;
                        EditList.SalesTransactionItemGroupFKeyName  = objSalesTransaction.SalesTransactionItemGroupFKeyName;
                        EditList.SalesTransactionPoNo               = objSalesTransaction.SalesTransactionPoNo;
                        EditList.SalesTransactionHsnCode            = objSalesTransaction.SalesTransactionHsnCode;
                        EditList.SalesTransactionCGSTPer            = objSalesTransaction.SalesTransactionCGSTPer;
                        EditList.SalesTransactionCGSTAmt            = objSalesTransaction.SalesTransactionCGSTAmt;
                        EditList.SalesTransactionSGSTPer            = objSalesTransaction.SalesTransactionSGSTPer;
                        EditList.SalesTransactionSGSTAmt            = objSalesTransaction.SalesTransactionSGSTAmt;
                        EditList.SalesTransactionIGSTPer            = objSalesTransaction.SalesTransactionIGSTPer;
                        EditList.SalesTransactionIGSTAmt            = objSalesTransaction.SalesTransactionIGSTAmt;
                        EditList.SalesTransactionTaxableAmt         = objSalesTransaction.SalesTransactionTaxableAmt;
                        EditList.SalesTransactionUnitFKey           = objSalesTransaction.SalesTransactionUnitFKey;
                        //Index  =  listIndex + 1
                    }
                    //listIndex += 1;
                }
                if (objSalesTransaction.SalesTransactionKey == 0 && "DELETE" == objSalesTransaction.Mode)
                {
                    var EditList = lstTranSaction.Where(x => x.Index.Equals(objSalesTransaction.Index)).FirstOrDefault();
                    if (EditList != null)
                    {
                        EditList.Mode = objSalesTransaction.Mode;
                    }
                    //Index = listIndex + 1
                }

                if (objSalesTransaction.SalesTransactionKey > 0)
                {
                    var EditList = lstTranSaction.Where(x => x.Index.Equals(objSalesTransaction.Index)).FirstOrDefault();

                    if (EditList != null)
                    {
                        EditList.SalesTransactionKey                    = objSalesTransaction.SalesTransactionKey       ;      
                        EditList.SalesTransactionItemFKey               = objSalesTransaction.SalesTransactionItemFKey  ;
                        EditList.SalesTransactionQty                    = objSalesTransaction.SalesTransactionQty       ;
                        EditList.SalesTransactionRate                   = objSalesTransaction.SalesTransactionRate      ;
                        EditList.SalesTransactionTotal                  = objSalesTransaction.SalesTransactionTotal     ;
                        EditList.SalesTransactionItemFKeyName           = objSalesTransaction.SalesTransactionItemFKeyName;
                        EditList.SalesTransactionItemGroupFKeyName      = objSalesTransaction.SalesTransactionItemGroupFKeyName;
                        EditList.SalesTransactionItemGroupFKey          = objSalesTransaction.SalesTransactionItemGroupFKey;
                        EditList.Mode                                   = objSalesTransaction.Mode;
                        EditList.SalesTransactionPoNo                   = objSalesTransaction.SalesTransactionPoNo;
                        EditList.SalesTransactionHsnCode                = objSalesTransaction.SalesTransactionHsnCode;
                        EditList.SalesTransactionCGSTPer                = objSalesTransaction.SalesTransactionCGSTPer;
                        EditList.SalesTransactionCGSTAmt                = objSalesTransaction.SalesTransactionCGSTAmt;
                        EditList.SalesTransactionSGSTPer                = objSalesTransaction.SalesTransactionSGSTPer;
                        EditList.SalesTransactionSGSTAmt                = objSalesTransaction.SalesTransactionSGSTAmt;
                        EditList.SalesTransactionIGSTPer                = objSalesTransaction.SalesTransactionIGSTPer;
                        EditList.SalesTransactionIGSTAmt                = objSalesTransaction.SalesTransactionIGSTAmt;
                        EditList.SalesTransactionTaxableAmt             = objSalesTransaction.SalesTransactionTaxableAmt;
                        EditList.SalesTransactionUnitFKey               = objSalesTransaction.SalesTransactionUnitFKey;
                    }
                    //listIndex += 1;
                }

                var templist = new List<clsSalesTransactionMember>();
                listIndex = 1;
                foreach (var item in lstTranSaction)
                {
                    templist.Add(new clsSalesTransactionMember
                    {
                        SalesTransactionKey                 = item.SalesTransactionKey        ,
                        SalesTransactionItemFKey            = item.SalesTransactionItemFKey   ,
                        SalesTransactionQty                 = item.SalesTransactionQty        ,
                        SalesTransactionRate                = item.SalesTransactionRate       ,
                        SalesTransactionTotal               = item.SalesTransactionTotal      ,
                        SalesTransactionItemFKeyName        = item.SalesTransactionItemFKeyName,
                        SalesTransactionItemGroupFKey       = item.SalesTransactionItemGroupFKey,
                        SalesTransactionItemGroupFKeyName   = item.SalesTransactionItemGroupFKeyName, 
                        Mode                                = item.Mode,
                        Index                               = listIndex,
                        SalesTransactionPoNo                = item.SalesTransactionPoNo,
                        SalesTransactionHsnCode             = item.SalesTransactionHsnCode,
                        SalesTransactionCGSTPer             = item.SalesTransactionCGSTPer     ,     
                        SalesTransactionCGSTAmt             = item.SalesTransactionCGSTAmt     ,
                        SalesTransactionSGSTPer             = item.SalesTransactionSGSTPer     ,
                        SalesTransactionSGSTAmt             = item.SalesTransactionSGSTAmt     ,
                        SalesTransactionIGSTPer             = item.SalesTransactionIGSTPer     ,
                        SalesTransactionIGSTAmt             = item.SalesTransactionIGSTAmt     ,
                        SalesTransactionTaxableAmt          = item.SalesTransactionTaxableAmt   ,
                        SalesTransactionUnitFKey            = item.SalesTransactionUnitFKey
                    });
                    listIndex += 1;
                }
                return templist;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static string GetSalesTransactionXML(List<clsSalesTransactionMember> lstSalesTransaction)
        {
            try
            {
                StringBuilder sbXML = new StringBuilder();
                sbXML.Append("<SalesMaster>");

                //var objList = (List<clsCustomer2ProductMember>)HttpContext.Current.Cache[clsCacheKeys.CustomerContactKey];

                if (lstSalesTransaction == null)
                {
                    throw new Exception("Technical Error Saving Records");
                }
                foreach (var item in lstSalesTransaction)
                {
                    if (item.Mode != "Edit")
                    {
                        sbXML.AppendFormat(@"<SalesTransaction   
                                                    SalesTransactionKey    =""{0}""          SalesTransactionItemFKey         =""{1}""  
                                                    SalesTransactionQty    =""{2}""          SalesTransactionRate             =""{3}""
                                                    SalesTransactionTotal  =""{4}""          SalesTransactionItemGroupFKey    =""{5}""
                                                    Mode                   =""{6}""          SalesTransactionPoNo             =""{7}""
                                                    SalesTransactionHsnCode=""{8}""          SalesTransactionCGSTPer          =""{9}""  
                                                    SalesTransactionCGSTAmt=""{10}""         SalesTransactionTaxableAmt       =""{11}"" 
                                                    SalesTransactionSGSTPer=""{12}""         SalesTransactionSGSTAmt          =""{13}"" 
                                                    SalesTransactionIGSTPer=""{14}""         SalesTransactionIGSTAmt          =""{15}"" 
                                                    SalesTransactionUnitFKey=""{16}""
                                              />",
                                                    item.SalesTransactionKey,                item.SalesTransactionItemFKey,
                                                    item.SalesTransactionQty,                item.SalesTransactionRate,
                                                    item.SalesTransactionTotal,              item.SalesTransactionItemGroupFKey,
                                                    item.Mode,                               item.SalesTransactionPoNo,
                                                    item.SalesTransactionHsnCode,
                                                    item.SalesTransactionCGSTPer,
                                                    item.SalesTransactionCGSTAmt,
                                                    item.SalesTransactionTaxableAmt,
                                                    item.SalesTransactionSGSTPer,
                                                    item.SalesTransactionSGSTAmt,
                                                    item.SalesTransactionIGSTPer,
                                                    item.SalesTransactionIGSTAmt,
                                                    item.SalesTransactionUnitFKey
                                                    );
                    }
                }
                sbXML.Append("</SalesMaster>");
                return sbXML.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

    public class clsSalesTransactionPaymentMember : clsSalesMasterMember
    {
        public int      SalesTransactionPayKey                {get;set;}
        public String   SalesTransactionPayType               {get;set;}
        public String   SalesTransactionPayDate               {get;set;}
        public int      SalesTransactionPayBankFKey           {get;set;}
        public String   SalesTransactionPayBankChequeNo       {get;set;}
        public Decimal  SalesTransactionPayAmount             {get;set;}
        public int      SalesTransactionPaySalesMasterFKey    {get;set;}
        public int      Index                                 {get;set;}
        public String   SalesTransactionPayBankFKeyName       {get;set;}
        public String   SalesTransactionPayChequeDate         {get;set;}
        public String   SalesActualTransactionPayDate         {get;set;}
        public String   SalesActualTransactionCheckDate       {get;set;}
        public String   CompanyNameDetail                     {get;set;}

        public DataSet Report_PaymentDetail()
        {
            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[] 
                                {
                                    new SqlParameter("@SalesTransactionPayKey"	         ,   SalesTransactionPayKey	          ),

                                    new SqlParameter("@UserID"                           ,   UserID                           ),
                                    new SqlParameter("@CompanyID"	                     ,   CompanyID                        ),
                                    new SqlParameter("@Action"                           ,   "SELECTONE"                      ) 
                                };
                DataSet ds = objSql.ExecuteDataSet("Report_PaymentDetail", objParams);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<clsSalesTransactionPaymentMember> AddUpdateDeleteSalesTransactionPayments(clsSalesTransactionPaymentMember objSalesTransactionPayments, List<clsSalesTransactionPaymentMember> lstTranSactionPayments)
        {
            //List<clsSalesTransactionPaymentMember> lstTranSactionPayments = new List<clsSalesTransactionPaymentMember>();
            try
            {
                int listIndex = 0;
                //if ((List<clsSalesTransactionPaymentMember>)HttpContext.Current.Cache[clsCacheKeys.Customer2ProductCacheKey] != null)
                //{
                //    lstTranSactionPayments = (List<clsSalesTransactionPaymentMember>)HttpContext.Current.Cache[clsCacheKeys.Customer2ProductCacheKey];
                //    listIndex = lstTranSactionPayments.Count;
                //}

                //var query = lstTranSactionPayments.FindAll(x => x.CustomerFirstName.Equals(objSalesTransactionPayments.CustomerFirstName) && x.Mode != "DELETE"
                //    && x.Index != objSalesTransactionPayments.Index);
                //if (query.Count > 0)
                //{
                //    throw new Exception(SetMessageFormatLI("duplicate entry not allowed"));
                //}
                if (lstTranSactionPayments != null)
                {
                    listIndex = lstTranSactionPayments.Count;
                }

                if (objSalesTransactionPayments.SalesTransactionPayKey == 0 && "ADD" == objSalesTransactionPayments.Mode)
                {
                    lstTranSactionPayments.Add(new clsSalesTransactionPaymentMember
                    {
                        SalesTransactionPayKey                  =   objSalesTransactionPayments.SalesTransactionPayKey              ,  
                        SalesTransactionPayType                 =   objSalesTransactionPayments.SalesTransactionPayType             ,
                        SalesTransactionPayDate                 =   objSalesTransactionPayments.SalesTransactionPayDate             ,
                        SalesTransactionPayBankFKey             =   objSalesTransactionPayments.SalesTransactionPayBankFKey         ,
                        SalesTransactionPayBankFKeyName         =   objSalesTransactionPayments.SalesTransactionPayBankFKeyName,
                        SalesTransactionPayBankChequeNo         =   objSalesTransactionPayments.SalesTransactionPayBankChequeNo     ,
                        SalesTransactionPayAmount               =   objSalesTransactionPayments.SalesTransactionPayAmount           ,
                        Mode                                    =   objSalesTransactionPayments.Mode,
                        SalesTransactionPayChequeDate           =   objSalesTransactionPayments.SalesTransactionPayChequeDate,
                        SalesActualTransactionPayDate           =   objSalesTransactionPayments.SalesActualTransactionPayDate,
                        SalesActualTransactionCheckDate         =   objSalesTransactionPayments.SalesActualTransactionCheckDate,
                        Index                                   = listIndex + 1
                    });
                    listIndex += 1;
                }

                if (objSalesTransactionPayments.SalesTransactionPayKey == 0 && "UPDATE" == objSalesTransactionPayments.Mode)
                {
                    var EditList = lstTranSactionPayments.Where(x => x.Index.Equals(objSalesTransactionPayments.Index)).FirstOrDefault();

                    if (EditList != null)
                    {
                        EditList.SalesTransactionPayKey                  =   objSalesTransactionPayments.SalesTransactionPayKey             ;
                        EditList.SalesTransactionPayType                 =   objSalesTransactionPayments.SalesTransactionPayType            ;
                        EditList.SalesTransactionPayDate                 =   objSalesTransactionPayments.SalesTransactionPayDate            ;
                        EditList.SalesTransactionPayBankFKey             =   objSalesTransactionPayments.SalesTransactionPayBankFKey        ;
                        EditList.SalesTransactionPayBankChequeNo         =   objSalesTransactionPayments.SalesTransactionPayBankChequeNo    ;
                        EditList.SalesTransactionPayAmount               =   objSalesTransactionPayments.SalesTransactionPayAmount          ;
                        EditList.SalesTransactionPayBankFKeyName         =   objSalesTransactionPayments.SalesTransactionPayBankFKeyName;
                        EditList.SalesTransactionPayChequeDate           =   objSalesTransactionPayments.SalesTransactionPayChequeDate;
                        EditList.SalesActualTransactionPayDate           =   objSalesTransactionPayments.SalesActualTransactionPayDate;
                        EditList.SalesActualTransactionCheckDate         =   objSalesTransactionPayments.SalesActualTransactionCheckDate;
                        //Index  =  listIndex + 1
                    }
                    //listIndex += 1;
                }
                if (objSalesTransactionPayments.SalesTransactionPayKey == 0 && "DELETE" == objSalesTransactionPayments.Mode)
                {
                    var EditList = lstTranSactionPayments.Where(x => x.Index.Equals(objSalesTransactionPayments.Index)).FirstOrDefault();
                    if (EditList != null)
                    {
                        EditList.Mode = objSalesTransactionPayments.Mode;
                    }
                    //Index = listIndex + 1
                }

                if (objSalesTransactionPayments.SalesTransactionPayKey > 0)
                {
                    var EditList = lstTranSactionPayments.Where(x => x.Index.Equals(objSalesTransactionPayments.Index)).FirstOrDefault();

                    if (EditList != null)
                    {
                        EditList.SalesTransactionPayKey                  =   objSalesTransactionPayments.SalesTransactionPayKey             ;
                        EditList.SalesTransactionPayType                 =   objSalesTransactionPayments.SalesTransactionPayType            ;
                        EditList.SalesTransactionPayDate                 =   objSalesTransactionPayments.SalesTransactionPayDate            ;
                        EditList.SalesTransactionPayBankFKey             =   objSalesTransactionPayments.SalesTransactionPayBankFKey        ;
                        EditList.SalesTransactionPayBankChequeNo         =   objSalesTransactionPayments.SalesTransactionPayBankChequeNo    ;
                        EditList.SalesTransactionPayAmount               =   objSalesTransactionPayments.SalesTransactionPayAmount          ;
                        EditList.SalesTransactionPayBankFKeyName         =   objSalesTransactionPayments.SalesTransactionPayBankFKeyName;
                        EditList.Mode                                    =   objSalesTransactionPayments.Mode;
                        EditList.SalesTransactionPayChequeDate           =   objSalesTransactionPayments.SalesTransactionPayChequeDate;
                        EditList.SalesActualTransactionPayDate           =   objSalesTransactionPayments.SalesActualTransactionPayDate;
                        EditList.SalesActualTransactionCheckDate         =   objSalesTransactionPayments.SalesActualTransactionCheckDate;
                    }
                    //listIndex += 1;
                }

                var templist = new List<clsSalesTransactionPaymentMember>();
                listIndex = 1;
                foreach (var item in lstTranSactionPayments)
                {
                    templist.Add(new clsSalesTransactionPaymentMember
                    {
                        SalesTransactionPayKey          = item.SalesTransactionPayKey               , 
                        SalesTransactionPayType         = item.SalesTransactionPayType              ,
                        SalesTransactionPayDate         = item.SalesTransactionPayDate              ,
                        SalesTransactionPayBankFKey     = item.SalesTransactionPayBankFKey          ,
                        SalesTransactionPayBankFKeyName = item.SalesTransactionPayBankFKeyName      ,
                        SalesTransactionPayBankChequeNo = item.SalesTransactionPayBankChequeNo      ,
                        SalesTransactionPayAmount       = item.SalesTransactionPayAmount            ,
                        SalesTransactionPayChequeDate   = item.SalesTransactionPayChequeDate        ,
                        Mode                            = item.Mode,
                        Index                           = listIndex,
                        SalesActualTransactionPayDate   = item.SalesActualTransactionPayDate,
                        SalesActualTransactionCheckDate = item.SalesActualTransactionCheckDate,
                    });
                    listIndex += 1;
                }
                return templist;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string GetSalesPaymentXML(List<clsSalesTransactionPaymentMember> lstSalesTransactionPayments)
        {
            try
            {
                StringBuilder sbXML = new StringBuilder();
                sbXML.Append("<SalesMaster>");
                //var objList = (List<clsCustomer2ProductMember>)HttpContext.Current.Cache[clsCacheKeys.CustomerContactKey];
                if (lstSalesTransactionPayments == null)
                {
                    throw new Exception("Technical Error Saving Records");
                }
                foreach (var item in lstSalesTransactionPayments)
                {
                    if (item.Mode != "Edit")
                    {
                        sbXML.AppendFormat(@"<SalesPayment   
                                                    SalesTransactionPayKey    =""{0}""          SalesTransactionPayType         =""{1}""  
                                                    SalesTransactionPayDate   =""{2}""          SalesTransactionPayBankFKey     =""{3}""
                                                    SalesTransactionPayAmount =""{4}""          SalesTransactionPayBankChequeNo =""{5}""
                                                    Mode                      =""{6}""          SalesTransactionPayChequeDate   =""{7}""
                                                    />",
                                                    item.SalesTransactionPayKey,                                                                    item.SalesTransactionPayType,
                                                    Convert.ToDateTime(item.SalesTransactionPayDate).ToString("MM/dd/yyyy"), item.SalesTransactionPayBankFKey,
                                                    item.SalesTransactionPayAmount,                                                                 item.SalesTransactionPayBankChequeNo,
                                                    item.Mode, item.SalesTransactionPayType.Equals("Bank") ? Convert.ToDateTime(item.SalesTransactionPayChequeDate).ToString("MM/dd/yyyy") : String.Empty);
                    }
                }
                sbXML.Append("</SalesMaster>");
                return sbXML.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static string GetTestingSalesPaymentXML(List<clsSalesTransactionPaymentMember> lstSalesTransactionPayments)
        {
            try
            {
                StringBuilder sbXML = new StringBuilder();
                sbXML.Append("<SalesMaster>");
                //var objList = (List<clsCustomer2ProductMember>)HttpContext.Current.Cache[clsCacheKeys.CustomerContactKey];
                if (lstSalesTransactionPayments == null)
                {
                    throw new Exception("Technical Error Saving Records");
                }
                foreach (var item in lstSalesTransactionPayments)
                {
                    if (item.Mode != "Edit")
                    {
                        sbXML.AppendFormat(@"<SalesPayment   
                                                    SalesTransactionPayKey    =""{0}""          SalesTransactionPayType         =""{1}""  
                                                    SalesTransactionPayDate   =""{2}""          SalesTransactionPayBankFKey     =""{3}""
                                                    SalesTransactionPayAmount =""{4}""          SalesTransactionPayBankChequeNo =""{5}""
                                                    Mode                      =""{6}""          SalesTransactionPayChequeDate   =""{7}""
                                                    />",
                                                    item.SalesTransactionPayKey, item.SalesTransactionPayType,
                                                    Convert.ToDateTime(item.SalesTransactionPayDate).ToString("MM/dd/yyyy"), item.SalesTransactionPayBankFKey,
                                                    item.SalesTransactionPayAmount, item.SalesTransactionPayBankChequeNo,
                                                    item.Mode, item.SalesTransactionPayType.Equals("Bank") ? Convert.ToDateTime(item.SalesTransactionPayChequeDate).ToString("MM/dd/yyyy") : String.Empty);
                    }
                }
                sbXML.Append("</SalesMaster>");
                return sbXML.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
            
    
    
    
    




