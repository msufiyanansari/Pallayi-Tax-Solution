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
    public class clsPurchaseMasterMember
    {
        public int PurchaseMasterKey            { get; set; }
        public String PurchaseMasterDate { get; set; }
        public int PurchaseMasterSupplierFKey { get; set; }
        public String PurchaseMasterBillBookNo { get; set; }
        public String PurchaseMasterInvoiceNo { get; set; }
        public String PurchaseMasterInvoiceDate { get; set; }
        public String PurchaseMasterChlnNo { get; set; }
        public String PurchaseMasterChlnDate { get; set; }
        public Decimal PurchaseMasterGrossTotal { get; set; }
        public Decimal PurchaseMasterCartage { get; set; }
        public Decimal PurchaseMasterSubTotal { get; set; }
        public Decimal PurchaseMasterVatPerc { get; set; }
        public Decimal PurchaseMasterVatAmount { get; set; }
        public int UserID { get; set; }
        public int CompanyID { get; set; }
        public String Mode { get; set; }
        public List<clsPurchaseTransactionMember> lstPurchaseTransaction { get; set; }
        public String PurchaseTransactionXML { get; set; }
        public Decimal PurchaseMasterMainTotal { get; set; }
        public String PurchaseMasterSupplierDetail { get; set; }
        public String PurchaseMasterSupplierFKeyName { get; set; }
        public String PurchaseMasterSupplierFKeyAddress { get; set; }
        public String FromDate { get; set; }
        public String ToDate { get; set; }
        public Decimal PurchaseMasterAddTaxPer { get; set; }
        public Decimal PurchaseMasterAddTaxAmt { get; set; }
        public Decimal PurchaseMasterDiscPer { get; set; }
        public Decimal PurchaseMasterDiscAmount { get; set; }
        public Decimal PurchaseMasterItemAmt { get; set; }
        public String PurchaseMasterType { get; set; }
        public int PurchaseMasterDiscountCalculate { get; set; }
        public List<clsPurchaseTransactionPaymentMember> lstPurchasePayment { get; set; }
        public String PurchaseMasterPaymentXML { get; set; }
        public Decimal PurchaseMasterPaidAmount { get; set; }
        public Decimal PurchaseMasterPendingAmount { get; set; }
        public String PurchaseMasterPoNo { get; set; }
        public String TranMasterTransportDetail { get; set; }
        public String PurchaseMasterNoofKey { get; set; }
        public Decimal PurchaseMasterISGTPer { get; set; }
        public Decimal PurchaseMasterISGTAmount { get; set; }
        public String PurchaseMasterReverseCharge { get; set; }
        public String PurchaseMasterVehicleNo { get; set; }
        public String PurchaseMasterActualDate { get; set; }
        public Decimal PurchaseMasterRoundoff { get; set; }
        public String  PurchaseMasterRoundoffOption {get;set;}
        public String PurchaseDetail { get; set; }
    }
    public class clsPurchaseMaster : clsPurchaseMasterMember
    {
        public DataSet Report_PurchaseRegister()
        {
            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[] 
                                {
                                    new SqlParameter("@PurchaseMasterSupplierFKeyName"	     ,   PurchaseMasterSupplierFKeyName	  ),
                                    new SqlParameter("@PurchaseMasterSupplierFKeyAddress"	 ,   PurchaseMasterSupplierFKeyAddress),
                                    new SqlParameter("@FromDate"	                         ,   FromDate						  ),
                                    new SqlParameter("@ToDate"	                             ,   ToDate							  ),

                                    new SqlParameter("@UserID"                               ,   UserID                           ),
                                    new SqlParameter("@CompanyID"	                         ,   CompanyID                        ),
                                    new SqlParameter("@Action"                               ,   Mode                             ) 
                                };
                DataSet ds = objSql.ExecuteDataSet("Report_PurchaseRegister", objParams);
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
                    new SqlParameter("@PurchaseMasterKey"            ,   PurchaseMasterKey              ),
                    new SqlParameter("@PurchaseMasterDate"           ,   PurchaseMasterDate             ),
                    new SqlParameter("@PurchaseMasterSupplierFKey"   ,   PurchaseMasterSupplierFKey     ),
                    new SqlParameter("@PurchaseMasterBillBookNo"     ,   PurchaseMasterBillBookNo       ),
                    new SqlParameter("@PurchaseMasterInvoiceNo"      ,   PurchaseMasterInvoiceNo        ),
                    new SqlParameter("@PurchaseMasterInvoiceDate"    ,   PurchaseMasterInvoiceDate      ),
                    new SqlParameter("@PurchaseMasterChlnNo"         ,   PurchaseMasterChlnNo           ),
                    new SqlParameter("@PurchaseMasterChlnDate"       ,   PurchaseMasterChlnDate         ),
                    new SqlParameter("@PurchaseMasterGrossTotal"     ,   PurchaseMasterGrossTotal       ),
                    new SqlParameter("@PurchaseMasterCartage"        ,   PurchaseMasterCartage          ),
                    new SqlParameter("@PurchaseMasterSubTotal"       ,   PurchaseMasterSubTotal         ),
                    new SqlParameter("@PurchaseMasterVatPerc"        ,   PurchaseMasterVatPerc          ),
                    new SqlParameter("@PurchaseMasterVatAmount"       ,   PurchaseMasterVatAmount       ),
                    new SqlParameter("@PurchaseTransactionXML"       ,   PurchaseTransactionXML         ),
                    new SqlParameter("@PurchaseMasterMainTotal"      ,   PurchaseMasterMainTotal        ),
                    new SqlParameter("@PurchaseMasterSupplierDetail" ,   PurchaseMasterSupplierDetail   ),
                    new SqlParameter("@PurchaseMasterAddTaxPer" ,        PurchaseMasterAddTaxPer        ),
                    new SqlParameter("@PurchaseMasterAddTaxAmt" ,        PurchaseMasterAddTaxAmt        ),
                    new SqlParameter("@PurchaseMasterDiscPer" ,          PurchaseMasterDiscPer          ),
                    new SqlParameter("@PurchaseMasterDiscAmount" ,       PurchaseMasterDiscAmount       ),
                    new SqlParameter("@PurchaseMasterItemAmt"    ,       PurchaseMasterItemAmt          ),
                    new SqlParameter("@PurchaseMasterType"       ,       PurchaseMasterType             ),
                    new SqlParameter("@PurchaseMasterDiscountCalculate", PurchaseMasterDiscountCalculate),
                    new SqlParameter("@PurchaseMasterPaymentXML"       , PurchaseMasterPaymentXML       ),
                    new SqlParameter("@PurchaseMasterPaidAmount"       , PurchaseMasterPaidAmount       ),
                    new SqlParameter("@PurchaseMasterPendingAmount"    , PurchaseMasterPendingAmount    ),
                    new SqlParameter("@PurchaseMasterPoNo"             , PurchaseMasterPoNo             ),
                    new SqlParameter("@TranMasterTransportDetail"      , TranMasterTransportDetail      ),
                    new SqlParameter("@PurchaseMasterISGTPer"          , PurchaseMasterISGTPer          ),
                    new SqlParameter("@PurchaseMasterISGTAmount"       , PurchaseMasterISGTAmount       ),
                    new SqlParameter("@PurchaseMasterReverseCharge"    , PurchaseMasterReverseCharge    ),
                    new SqlParameter("@PurchaseMasterVehicleNo"        , PurchaseMasterVehicleNo        ),
                    new SqlParameter("@PurchaseMasterRoundoff"         , PurchaseMasterRoundoff         ),
                    new SqlParameter("@PurchaseMasterRoundoffOption"   , PurchaseMasterRoundoffOption   ),

                    
                    new SqlParameter("@UserID"		                    ,   UserID	                     ), 
                    new SqlParameter("@CompanyID"		                ,   CompanyID	                  ),
                    new SqlParameter("@Action"                          ,	  Mode	                      )
                };
                int result = objSql.ExecuteNonQuery("PurchaseMasterSave", objParam);
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
        public List<clsPurchaseMasterMember> GetPurchaseMaster()
        {
            List<clsPurchaseMasterMember> objList = new List<clsPurchaseMasterMember>();
            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[] 
                {
                    new SqlParameter("@PurchaseMasterKey"	 ,   PurchaseMasterKey  ),
                                                                
                    new SqlParameter("@UserID"           ,   UserID          ),
                    new SqlParameter("@CompanyID"	     ,   CompanyID       ),
                    new SqlParameter("@Action"           ,   Mode            ) 
                };

                DataSet ds = objSql.ExecuteDataSet("PurchaseMasterGet", objParams);

                if (ds != null)
                {
                    clsPurchaseMasterMember objPurchaseMaster = new clsPurchaseMasterMember();
                    #region PurchaseMaster
                    if (ds.Tables.Count > 0)
                    {
                        foreach (DataRow r in ds.Tables[0].Rows)
                        {
                            objPurchaseMaster.PurchaseMasterKey = Convert.ToInt32(r["PurchaseMasterKey"] ?? -1);
                            objPurchaseMaster.PurchaseMasterDate = (r["PurchaseMasterDate"] ?? "").ToString();
                            objPurchaseMaster.PurchaseMasterActualDate = (r["PurchaseMasterActualDate"] ?? "").ToString();
                            objPurchaseMaster.PurchaseMasterSupplierFKey = Convert.ToInt32(r["PurchaseMasterSupplierFKey"] ?? -1);
                            objPurchaseMaster.PurchaseMasterBillBookNo = (r["PurchaseMasterBillBookNo"] ?? "").ToString();
                            objPurchaseMaster.PurchaseMasterInvoiceNo = (r["PurchaseMasterInvoiceNo"] ?? "").ToString();
                            objPurchaseMaster.PurchaseMasterChlnNo = (r["PurchaseMasterChlnNo"] ?? "").ToString();
                            objPurchaseMaster.PurchaseMasterChlnDate = (r["PurchaseMasterChlnDate"] ?? "").ToString();
                            objPurchaseMaster.PurchaseMasterGrossTotal = Convert.ToDecimal(r["PurchaseMasterGrossTotal"] ?? -1);
                            objPurchaseMaster.PurchaseMasterCartage = Convert.ToDecimal(r["PurchaseMasterCartage"] ?? -1);
                            objPurchaseMaster.PurchaseMasterSubTotal = Convert.ToDecimal(r["PurchaseMasterSubTotal"] ?? -1);
                            objPurchaseMaster.PurchaseMasterVatPerc = Convert.ToDecimal(r["PurchaseMasterVatPerc"] ?? -1);
                            objPurchaseMaster.PurchaseMasterVatAmount = Convert.ToDecimal(r["PurchaseMasterVatAmount"] ?? -1);
                            objPurchaseMaster.PurchaseMasterMainTotal = Convert.ToDecimal(r["PurchaseMasterMainTotal"] ?? -1);
                            objPurchaseMaster.PurchaseMasterSupplierDetail = (r["PurchaseMasterSupplierDetail"] ?? "").ToString();
                            objPurchaseMaster.PurchaseMasterAddTaxPer = Convert.ToDecimal(r["PurchaseMasterAddTaxPer"] ?? -1);
                            objPurchaseMaster.PurchaseMasterAddTaxAmt = Convert.ToDecimal(r["PurchaseMasterAddTaxAmt"] ?? -1);
                            objPurchaseMaster.PurchaseMasterDiscPer = Convert.ToDecimal(r["PurchaseMasterDiscPer"] ?? -1);
                            objPurchaseMaster.PurchaseMasterDiscAmount = Convert.ToDecimal(r["PurchaseMasterDiscAmount"] ?? -1);
                            objPurchaseMaster.PurchaseMasterItemAmt = Convert.ToDecimal(r["PurchaseMasterItemAmt"] ?? -1);
                            objPurchaseMaster.PurchaseMasterType = (r["PurchaseMasterType"] ?? "").ToString();
                            objPurchaseMaster.PurchaseMasterDiscountCalculate = Convert.ToInt32(r["PurchaseMasterDiscountCalculate"] ?? -1);
                            objPurchaseMaster.PurchaseMasterPaidAmount = Convert.ToDecimal(r["PurchaseMasterPaidAmount"] ?? -1);
                            objPurchaseMaster.PurchaseMasterPendingAmount = Convert.ToDecimal(r["PurchaseMasterPendingAmount"] ?? -1);
                            objPurchaseMaster.PurchaseMasterPoNo = (r["PurchaseMasterPoNo"] ?? "").ToString();
                            objPurchaseMaster.TranMasterTransportDetail = (r["TranMasterTransportDetail"] ?? "").ToString();
                            objPurchaseMaster.PurchaseMasterISGTPer = Convert.ToDecimal(r["PurchaseMasterISGTPer"] ?? -1);
                            objPurchaseMaster.PurchaseMasterISGTAmount = Convert.ToDecimal(r["PurchaseMasterISGTAmount"] ?? -1);
                            objPurchaseMaster.PurchaseMasterReverseCharge = (r["PurchaseMasterReverseCharge"] ?? "").ToString();
                            objPurchaseMaster.PurchaseMasterVehicleNo = (r["PurchaseMasterVehicleNo"] ?? "").ToString();
                            objPurchaseMaster.PurchaseMasterRoundoff = Convert.ToDecimal(r["PurchaseMasterRoundoff"] ?? -1);
                            objPurchaseMaster.PurchaseMasterRoundoffOption = (r["PurchaseMasterRoundoffOption"] ?? "").ToString();
                        }
                    }
                    objList.Add(objPurchaseMaster);

                    #endregion

                    #region PurchaseMaster2PurchaseTransaction
                    if (ds.Tables.Count > 1)
                    {
                        List<clsPurchaseTransactionMember> objPurchaseMaster2PurchaseTransaction = new List<clsPurchaseTransactionMember>();
                        //int RowIndex = 1;
                        foreach (DataRow r in ds.Tables[1].Rows)
                        {
                            objPurchaseMaster2PurchaseTransaction.Add(new clsPurchaseTransactionMember
                            {
                                PurchaseTransactionKey = Convert.ToInt32((r["PurchaseTransactionKey"] ?? -1)),
                                PurchaseTransactionItemFKey = Convert.ToInt32((r["PurchaseTransactionItemFKey"] ?? -1)),
                                PurchaseTransactionItemGroupFKey = Convert.ToInt32((r["PurchaseTransactionItemGroupFKey"] ?? -1)),
                                PurchaseTransactionQty = Convert.ToInt32((r["PurchaseTransactionQty"] ?? -1)),
                                PurchaseTransactionRate = Convert.ToDecimal((r["PurchaseTransactionRate"] ?? 0)),
                                PurchaseTransactionTotal = Convert.ToDecimal((r["PurchaseTransactionTotal"] ?? 0)),
                                PurchaseTransactionSaleMasterFKey = Convert.ToInt32((r["PurchaseTransactionSaleMasterFKey"] ?? -1)),
                                PurchaseTransactionItemGroupFKeyName = (r["PurchaseTransactionItemGroupFKeyName"] ?? "").ToString(),
                                PurchaseTransactionItemFKeyName = (r["PurchaseTransactionItemFKeyName"] ?? "").ToString(),
                                Mode = (r["Mode"] ?? "").ToString(),
                                Index = Convert.ToInt32((r["Index"] ?? -1)),
                                PurchaseTransactionPoNo = (r["PurchaseTransactionPoNo"] ?? "").ToString(),
                                PurchaseTransactionHsnCode      = (r["PurchaseTransactionHsnCode"] ?? "").ToString(),
                                PurchaseTransactionCGSTPer      = Convert.ToDecimal((r["PurchaseTransactionCGSTPer"] ?? -1)),
                                PurchaseTransactionCGSTAmt      = Convert.ToDecimal((r["PurchaseTransactionCGSTAmt"] ?? -1)),
                                PurchaseTransactionTaxableAmt   = Convert.ToDecimal((r["PurchaseTransactionTaxableAmt"] ?? -1)),
                                PurchaseTransactionSGSTPer      = Convert.ToDecimal((r["PurchaseTransactionSGSTPer"] ?? -1)),
                                PurchaseTransactionSGSTAmt      = Convert.ToDecimal((r["PurchaseTransactionSGSTAmt"] ?? -1)),
                                PurchaseTransactionIGSTPer      = Convert.ToDecimal((r["PurchaseTransactionIGSTPer"] ?? -1)),
                                PurchaseTransactionIGSTAmt      = Convert.ToDecimal((r["PurchaseTransactionIGSTAmt"] ?? -1)),
                                PurchaseTransactionDiscPer      = Convert.ToDecimal((r["PurchaseTransactionDiscPer"] ?? -1)),
                                PurchaseTransactionDiscAmt      = Convert.ToDecimal((r["PurchaseTransactionDiscAmt"] ?? -1)),
                            });
                        }
                        objPurchaseMaster.lstPurchaseTransaction = objPurchaseMaster2PurchaseTransaction;
                    }
                    #endregion

                    #region PurchaseMaster2PurchasePayment
                    if (ds.Tables.Count > 2)
                    {
                        List<clsPurchaseTransactionPaymentMember> objPurchaseMaster2PurchasePayment = new List<clsPurchaseTransactionPaymentMember>();
                        //int RowIndex = 1;
                        foreach (DataRow r in ds.Tables[2].Rows)
                        {
                            objPurchaseMaster2PurchasePayment.Add(new clsPurchaseTransactionPaymentMember
                            {
                                PurchaseTransactionPayKey = Convert.ToInt32((r["PurchaseTransactionPayKey"] ?? -1)),
                                PurchaseTransactionPayType = (r["PurchaseTransactionPayType"] ?? "").ToString(),
                                PurchaseTransactionPayDate = (r["PurchaseTransactionPayDate"] ?? "").ToString(),
                                PurchaseTransactionPayBankFKey = Convert.ToInt32((r["PurchaseTransactionPayBankFKey"] ?? -1)),
                                PurchaseTransactionPayBankFKeyName = (r["PurchaseTransactionPayBankFKeyName"] ?? "").ToString(),
                                PurchaseTransactionPayBankChequeNo = (r["PurchaseTransactionPayBankChequeNo"] ?? "").ToString(),
                                PurchaseTransactionPayAmount = Convert.ToDecimal((r["PurchaseTransactionPayAmount"] ?? -1)),
                                PurchaseTransactionPayChequeDate = (r["PurchaseTransactionPayChequeDate"] ?? "").ToString(),
                                Mode = (r["Mode"] ?? "").ToString(),
                                Index = Convert.ToInt32((r["Index"] ?? -1)),
                            });
                        }
                        objPurchaseMaster.lstPurchasePayment = objPurchaseMaster2PurchasePayment;
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

        public DataSet GetPurchaseMasterReport()
        {
            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[] 
                {
                    new SqlParameter("@PurchaseMasterKey"	 ,   PurchaseMasterKey      ),

                    new SqlParameter("@PurchaseMasterNoofKey",  PurchaseMasterNoofKey  ),
                    new SqlParameter("@UserID"           ,   UserID              ),
                    new SqlParameter("@CompanyID"	     ,   CompanyID           ),
                    new SqlParameter("@Action"           ,   Mode                ) 
                };
                DataSet ds = objSql.ExecuteDataSet("PurchaseMasterReport", objParams);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet PurchaseInvoiceList()
        {
            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[] 
                {
                    new SqlParameter("@PurchaseMasterKey"	 ,   PurchaseMasterKey      ),

                    new SqlParameter("@UserID"               ,   UserID                 ),
                    new SqlParameter("@CompanyID"	         ,   CompanyID              ),
                    new SqlParameter("@Action"               ,   Mode                   ) 
                };
                DataSet ds = objSql.ExecuteDataSet("PurchaseMasterGet", objParams);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet SearchPurchaseMaster()
        {
            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[] 
                                {
                                    new SqlParameter("@PurchaseMasterSupplierFKeyName"	     ,   PurchaseMasterSupplierFKeyName	  ),
                                    new SqlParameter("@PurchaseMasterSupplierFKeyAddress"	 ,   PurchaseMasterSupplierFKeyAddress	  ),
                                    new SqlParameter("@FromDate"	                     ,   FromDate						  ),
                                    new SqlParameter("@ToDate"	                         ,   ToDate							  ),
                                    new SqlParameter("@PurchaseMasterType"	                 ,   PurchaseMasterType				  ),

                                    new SqlParameter("@UserID"                           ,   UserID                           ),
                                    new SqlParameter("@CompanyID"	                     ,   CompanyID                        ),
                                    new SqlParameter("@Action"                           ,   Mode                             ) 
                                };

                DataSet ds = objSql.ExecuteDataSet("PurchaseMasterSearch", objParams);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet SearchPurchaseMasterItemPurchasePaymentReport()
        {
            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[] 
                                {
                                    new SqlParameter("@PurchaseMasterSupplierFKey"	         ,   PurchaseMasterSupplierFKey	          ),
                                    new SqlParameter("@PurchaseMasterSupplierFKeyAddress"	 ,   PurchaseMasterSupplierFKeyAddress	  ),
                                    new SqlParameter("@FromDate"	                         ,   FromDate						      ),
                                    new SqlParameter("@ToDate"	                             ,   ToDate							      ),
                                    new SqlParameter("@PurchaseMasterType"	                 ,   PurchaseMasterType				      ),

                                    new SqlParameter("@UserID"                               ,   UserID                               ),
                                    new SqlParameter("@CompanyID"	                         ,   CompanyID                            ),
                                    new SqlParameter("@Action"                               ,   Mode                                 ) 
                                };
                DataSet ds = objSql.ExecuteDataSet("PurchaseMasterItemPurchasePaymentReport", objParams);
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

    public class clsPurchaseTransactionMember : clsPurchaseMasterMember
    {
        public int PurchaseTransactionKey { get; set; }
        public int PurchaseTransactionItemFKey { get; set; }
        public Decimal PurchaseTransactionQty { get; set; }
        public Decimal PurchaseTransactionRate { get; set; }
        public Decimal PurchaseTransactionTotal { get; set; }
        public int PurchaseTransactionSaleMasterFKey { get; set; }
        public int Index { get; set; }
        public String PurchaseTransactionItemFKeyName { get; set; }
        public int PurchaseTransactionItemGroupFKey { get; set; }
        public String PurchaseTransactionItemGroupFKeyName { get; set; }
        public String PurchaseTransactionPoNo { get; set; }
        public String PurchaseTransactionHsnCode { get; set; }
        public Decimal PurchaseTransactionCGSTPer       {get;set;}
        public Decimal PurchaseTransactionCGSTAmt       {get;set;}
        public Decimal PurchaseTransactionSGSTPer       {get;set;}
        public Decimal PurchaseTransactionSGSTAmt       {get;set;}
        public Decimal PurchaseTransactionIGSTPer       {get;set;}
        public Decimal PurchaseTransactionIGSTAmt       {get;set;}
        public Decimal PurchaseTransactionTaxableAmt    {get;set;}
        public Decimal PurchaseTransactionDiscPer       {get;set;}
        public Decimal PurchaseTransactionDiscAmt       {get;set;}
        public int PurchaseTransactionUnitFKey { get; set; }
        public static List<clsPurchaseTransactionMember> AddUpdateDeletePurchaseTransaction(clsPurchaseTransactionMember objPurchaseTransaction, List<clsPurchaseTransactionMember> lstTranSaction)
        {
            //List<clsPurchaseTransactionMember> lstTranSaction = new List<clsPurchaseTransactionMember>();
            try
            {
                int listIndex = 0;
                //if ((List<clsPurchaseTransactionMember>)HttpContext.Current.Cache[clsCacheKeys.Supplier2ProductCacheKey] != null)
                //{
                //    lstTranSaction = (List<clsPurchaseTransactionMember>)HttpContext.Current.Cache[clsCacheKeys.Supplier2ProductCacheKey];
                //    listIndex = lstTranSaction.Count;
                //}

                //var query = lstTranSaction.FindAll(x => x.SupplierFirstName.Equals(objPurchaseTransaction.SupplierFirstName) && x.Mode != "DELETE"
                //    && x.Index != objPurchaseTransaction.Index);
                //if (query.Count > 0)
                //{
                //    throw new Exception(SetMessageFormatLI("duplicate entry not allowed"));
                //}
                if (lstTranSaction != null)
                {
                    listIndex = lstTranSaction.Count;
                }

                if (objPurchaseTransaction.PurchaseTransactionKey == 0 && "ADD" == objPurchaseTransaction.Mode)
                {
                    lstTranSaction.Add(new clsPurchaseTransactionMember
                    {
                        PurchaseTransactionKey = objPurchaseTransaction.PurchaseTransactionKey,
                        PurchaseTransactionItemFKey = objPurchaseTransaction.PurchaseTransactionItemFKey,
                        PurchaseTransactionQty = objPurchaseTransaction.PurchaseTransactionQty,
                        PurchaseTransactionRate = objPurchaseTransaction.PurchaseTransactionRate,
                        PurchaseTransactionTotal = objPurchaseTransaction.PurchaseTransactionTotal,
                        PurchaseTransactionItemFKeyName = objPurchaseTransaction.PurchaseTransactionItemFKeyName,
                        PurchaseTransactionItemGroupFKey = objPurchaseTransaction.PurchaseTransactionItemGroupFKey,
                        PurchaseTransactionItemGroupFKeyName = objPurchaseTransaction.PurchaseTransactionItemGroupFKeyName,
                        Mode = objPurchaseTransaction.Mode,
                        Index = listIndex + 1,
                        PurchaseTransactionPoNo = objPurchaseTransaction.PurchaseTransactionPoNo,
                        PurchaseTransactionHsnCode = objPurchaseTransaction.PurchaseTransactionHsnCode,
                        PurchaseTransactionCGSTPer = objPurchaseTransaction.PurchaseTransactionCGSTPer,
                        PurchaseTransactionCGSTAmt = objPurchaseTransaction.PurchaseTransactionCGSTAmt,
                        PurchaseTransactionTaxableAmt = objPurchaseTransaction.PurchaseTransactionTaxableAmt,
                        PurchaseTransactionSGSTPer = objPurchaseTransaction.PurchaseTransactionSGSTPer,
                        PurchaseTransactionSGSTAmt = objPurchaseTransaction.PurchaseTransactionSGSTAmt,
                        PurchaseTransactionIGSTPer = objPurchaseTransaction.PurchaseTransactionIGSTPer,
                        PurchaseTransactionIGSTAmt = objPurchaseTransaction.PurchaseTransactionIGSTAmt,
                        PurchaseTransactionDiscPer = objPurchaseTransaction.PurchaseTransactionDiscPer,
                        PurchaseTransactionDiscAmt = objPurchaseTransaction.PurchaseTransactionDiscAmt,
                        PurchaseTransactionUnitFKey = objPurchaseTransaction.PurchaseTransactionUnitFKey
                    });
                    listIndex += 1;
                }

                if (objPurchaseTransaction.PurchaseTransactionKey == 0 && "UPDATE" == objPurchaseTransaction.Mode)
                {
                    var EditList = lstTranSaction.Where(x => x.Index.Equals(objPurchaseTransaction.Index)).FirstOrDefault();

                    if (EditList != null)
                    {
                        EditList.PurchaseTransactionKey = objPurchaseTransaction.PurchaseTransactionKey;
                        EditList.PurchaseTransactionItemFKey = objPurchaseTransaction.PurchaseTransactionItemFKey;
                        EditList.PurchaseTransactionQty = objPurchaseTransaction.PurchaseTransactionQty;
                        EditList.PurchaseTransactionRate = objPurchaseTransaction.PurchaseTransactionRate;
                        EditList.PurchaseTransactionTotal = objPurchaseTransaction.PurchaseTransactionTotal;
                        EditList.PurchaseTransactionItemFKeyName = objPurchaseTransaction.PurchaseTransactionItemFKeyName;
                        EditList.PurchaseTransactionItemGroupFKey = objPurchaseTransaction.PurchaseTransactionItemGroupFKey;
                        EditList.PurchaseTransactionItemGroupFKeyName = objPurchaseTransaction.PurchaseTransactionItemGroupFKeyName;
                        EditList.PurchaseTransactionPoNo = objPurchaseTransaction.PurchaseTransactionPoNo;
                        EditList.PurchaseTransactionHsnCode = objPurchaseTransaction.PurchaseTransactionHsnCode;
                        EditList.PurchaseTransactionCGSTPer         =     objPurchaseTransaction.PurchaseTransactionCGSTPer ;   
                        EditList.PurchaseTransactionCGSTAmt         =     objPurchaseTransaction.PurchaseTransactionCGSTAmt ;  
                        EditList.PurchaseTransactionSGSTPer         =     objPurchaseTransaction.PurchaseTransactionSGSTPer ;  
                        EditList.PurchaseTransactionSGSTAmt         =     objPurchaseTransaction.PurchaseTransactionSGSTAmt ;  
                        EditList.PurchaseTransactionIGSTPer         =     objPurchaseTransaction.PurchaseTransactionIGSTPer ;  
                        EditList.PurchaseTransactionIGSTAmt         =     objPurchaseTransaction.PurchaseTransactionIGSTAmt ;  
                        EditList.PurchaseTransactionTaxableAmt      =     objPurchaseTransaction.PurchaseTransactionTaxableAmt;
                        EditList.PurchaseTransactionDiscPer = objPurchaseTransaction.PurchaseTransactionDiscPer;
                        EditList.PurchaseTransactionDiscAmt = objPurchaseTransaction.PurchaseTransactionDiscAmt;
                        EditList.PurchaseTransactionUnitFKey        = objPurchaseTransaction.PurchaseTransactionUnitFKey;
                        //Index  =  listIndex + 1
                    }
                    //listIndex += 1;
                }
                if (objPurchaseTransaction.PurchaseTransactionKey == 0 && "DELETE" == objPurchaseTransaction.Mode)
                {
                    var EditList = lstTranSaction.Where(x => x.Index.Equals(objPurchaseTransaction.Index)).FirstOrDefault();
                    if (EditList != null)
                    {
                        EditList.Mode = objPurchaseTransaction.Mode;
                    }
                    //Index = listIndex + 1
                }

                if (objPurchaseTransaction.PurchaseTransactionKey > 0)
                {
                    var EditList = lstTranSaction.Where(x => x.Index.Equals(objPurchaseTransaction.Index)).FirstOrDefault();

                    if (EditList != null)
                    {
                        EditList.PurchaseTransactionKey = objPurchaseTransaction.PurchaseTransactionKey;
                        EditList.PurchaseTransactionItemFKey = objPurchaseTransaction.PurchaseTransactionItemFKey;
                        EditList.PurchaseTransactionQty = objPurchaseTransaction.PurchaseTransactionQty;
                        EditList.PurchaseTransactionRate = objPurchaseTransaction.PurchaseTransactionRate;
                        EditList.PurchaseTransactionTotal = objPurchaseTransaction.PurchaseTransactionTotal;
                        EditList.PurchaseTransactionItemFKeyName = objPurchaseTransaction.PurchaseTransactionItemFKeyName;
                        EditList.PurchaseTransactionItemGroupFKeyName = objPurchaseTransaction.PurchaseTransactionItemGroupFKeyName;
                        EditList.PurchaseTransactionItemGroupFKey = objPurchaseTransaction.PurchaseTransactionItemGroupFKey;
                        EditList.Mode = objPurchaseTransaction.Mode;
                        EditList.PurchaseTransactionPoNo = objPurchaseTransaction.PurchaseTransactionPoNo;
                        EditList.PurchaseTransactionHsnCode = objPurchaseTransaction.PurchaseTransactionHsnCode;
                        EditList.PurchaseTransactionCGSTPer = objPurchaseTransaction.PurchaseTransactionCGSTPer;
                        EditList.PurchaseTransactionCGSTAmt = objPurchaseTransaction.PurchaseTransactionCGSTAmt;
                        EditList.PurchaseTransactionSGSTPer = objPurchaseTransaction.PurchaseTransactionSGSTPer;
                        EditList.PurchaseTransactionSGSTAmt = objPurchaseTransaction.PurchaseTransactionSGSTAmt;
                        EditList.PurchaseTransactionIGSTPer = objPurchaseTransaction.PurchaseTransactionIGSTPer;
                        EditList.PurchaseTransactionIGSTAmt = objPurchaseTransaction.PurchaseTransactionIGSTAmt;
                        EditList.PurchaseTransactionTaxableAmt = objPurchaseTransaction.PurchaseTransactionTaxableAmt;
                        EditList.PurchaseTransactionDiscPer = objPurchaseTransaction.PurchaseTransactionDiscPer;
                        EditList.PurchaseTransactionDiscAmt = objPurchaseTransaction.PurchaseTransactionDiscAmt;
                        EditList.PurchaseTransactionUnitFKey = objPurchaseTransaction.PurchaseTransactionUnitFKey;
                    }
                    //listIndex += 1;
                }

                var templist = new List<clsPurchaseTransactionMember>();
                listIndex = 1;
                foreach (var item in lstTranSaction)
                {
                    templist.Add(new clsPurchaseTransactionMember
                    {
                        PurchaseTransactionKey = item.PurchaseTransactionKey,
                        PurchaseTransactionItemFKey = item.PurchaseTransactionItemFKey,
                        PurchaseTransactionQty = item.PurchaseTransactionQty,
                        PurchaseTransactionRate = item.PurchaseTransactionRate,
                        PurchaseTransactionTotal = item.PurchaseTransactionTotal,
                        PurchaseTransactionItemFKeyName = item.PurchaseTransactionItemFKeyName,
                        PurchaseTransactionItemGroupFKey = item.PurchaseTransactionItemGroupFKey,
                        PurchaseTransactionItemGroupFKeyName = item.PurchaseTransactionItemGroupFKeyName,
                        Mode = item.Mode,
                        Index = listIndex,
                        PurchaseTransactionPoNo             =   item.PurchaseTransactionPoNo,
                        PurchaseTransactionHsnCode          =   item.PurchaseTransactionHsnCode,
                        PurchaseTransactionCGSTPer          =   item.PurchaseTransactionCGSTPer     ,     
                        PurchaseTransactionCGSTAmt          =   item.PurchaseTransactionCGSTAmt     ,
                        PurchaseTransactionSGSTPer          =   item.PurchaseTransactionSGSTPer     ,
                        PurchaseTransactionSGSTAmt          =   item.PurchaseTransactionSGSTAmt     ,
                        PurchaseTransactionIGSTPer          =   item.PurchaseTransactionIGSTPer     ,
                        PurchaseTransactionIGSTAmt          =   item.PurchaseTransactionIGSTAmt     ,
                        PurchaseTransactionTaxableAmt       =   item.PurchaseTransactionTaxableAmt  ,
                        PurchaseTransactionDiscPer          =   item.PurchaseTransactionDiscPer,
                        PurchaseTransactionDiscAmt          =   item.PurchaseTransactionDiscAmt,
                        PurchaseTransactionUnitFKey         =   item.PurchaseTransactionUnitFKey
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
        public static string GetPurchaseTransactionXML(List<clsPurchaseTransactionMember> lstPurchaseTransaction)
        {
            try
            {
                StringBuilder sbXML = new StringBuilder();
                sbXML.Append("<PurchaseMaster>");

                //var objList = (List<clsSupplier2ProductMember>)HttpContext.Current.Cache[clsCacheKeys.SupplierContactKey];

                if (lstPurchaseTransaction == null)
                {
                    throw new Exception("Technical Error Saving Records");
                }
                foreach (var item in lstPurchaseTransaction)
                {
                    if (item.Mode != "Edit")
                    {
                        sbXML.AppendFormat(@"<PurchaseTransaction   
                                                    PurchaseTransactionKey    =""{0}""          PurchaseTransactionItemFKey         =""{1}""  
                                                    PurchaseTransactionQty    =""{2}""          PurchaseTransactionRate             =""{3}""
                                                    PurchaseTransactionTotal  =""{4}""          PurchaseTransactionItemGroupFKey    =""{5}""
                                                    Mode                   =""{6}""             PurchaseTransactionPoNo             =""{7}""
                                                    PurchaseTransactionHsnCode=""{8}""          PurchaseTransactionCGSTPer          =""{9}""  
                                                    PurchaseTransactionCGSTAmt=""{10}""         PurchaseTransactionTaxableAmt       =""{11}"" 
                                                    PurchaseTransactionSGSTPer=""{12}""         PurchaseTransactionSGSTAmt          =""{13}"" 
                                                    PurchaseTransactionIGSTPer=""{14}""         PurchaseTransactionIGSTAmt          =""{15}"" 
                                                    PurchaseTransactionDiscPer=""{16}""         PurchaseTransactionDiscAmt          =""{17}""
                                                    PurchaseTransactionUnitFKey=""{18}""
                                                    />",    
                                                    item.PurchaseTransactionKey, item.PurchaseTransactionItemFKey,
                                                    item.PurchaseTransactionQty, item.PurchaseTransactionRate,
                                                    item.PurchaseTransactionTotal, item.PurchaseTransactionItemGroupFKey,
                                                    item.Mode, item.PurchaseTransactionPoNo,
                                                    item.PurchaseTransactionHsnCode,
                                                    item.PurchaseTransactionCGSTPer,
                                                    item.PurchaseTransactionCGSTAmt,
                                                    item.PurchaseTransactionTaxableAmt,
                                                    item.PurchaseTransactionSGSTPer,
                                                    item.PurchaseTransactionSGSTAmt,
                                                    item.PurchaseTransactionIGSTPer,
                                                    item.PurchaseTransactionIGSTAmt,
                                                    item.PurchaseTransactionDiscPer,
                                                    item.PurchaseTransactionDiscAmt,
                                                    item.PurchaseTransactionUnitFKey
                                                    );
                    }
                }
                sbXML.Append("</PurchaseMaster>");
                return sbXML.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

    public class clsPurchaseTransactionPaymentMember : clsPurchaseMasterMember
    {
        public int PurchaseTransactionPayKey { get; set; }
        public String PurchaseTransactionPayType { get; set; }
        public String PurchaseTransactionPayDate { get; set; }
        public int PurchaseTransactionPayBankFKey { get; set; }
        public String PurchaseTransactionPayBankChequeNo { get; set; }
        public Decimal PurchaseTransactionPayAmount { get; set; }
        public int PurchaseTransactionPayPurchaseMasterFKey { get; set; }
        public int Index { get; set; }
        public String PurchaseTransactionPayBankFKeyName { get; set; }
        public String PurchaseTransactionPayChequeDate { get; set; }
        public String PurchaseActualTransactionPayDate { get; set; }
        public String PurchaseActualTransactionCheckDate { get; set; }

        public static List<clsPurchaseTransactionPaymentMember> AddUpdateDeletePurchaseTransactionPayments(clsPurchaseTransactionPaymentMember objPurchaseTransactionPayments, List<clsPurchaseTransactionPaymentMember> lstTranSactionPayments)
        {
            //List<clsPurchaseTransactionPaymentMember> lstTranSactionPayments = new List<clsPurchaseTransactionPaymentMember>();
            try
            {
                int listIndex = 0;
                //if ((List<clsPurchaseTransactionPaymentMember>)HttpContext.Current.Cache[clsCacheKeys.Supplier2ProductCacheKey] != null)
                //{
                //    lstTranSactionPayments = (List<clsPurchaseTransactionPaymentMember>)HttpContext.Current.Cache[clsCacheKeys.Supplier2ProductCacheKey];
                //    listIndex = lstTranSactionPayments.Count;
                //}

                //var query = lstTranSactionPayments.FindAll(x => x.SupplierFirstName.Equals(objPurchaseTransactionPayments.SupplierFirstName) && x.Mode != "DELETE"
                //    && x.Index != objPurchaseTransactionPayments.Index);
                //if (query.Count > 0)
                //{
                //    throw new Exception(SetMessageFormatLI("duplicate entry not allowed"));
                //}
                if (lstTranSactionPayments != null)
                {
                    listIndex = lstTranSactionPayments.Count;
                }

                if (objPurchaseTransactionPayments.PurchaseTransactionPayKey == 0 && "ADD" == objPurchaseTransactionPayments.Mode)
                {
                    lstTranSactionPayments.Add(new clsPurchaseTransactionPaymentMember
                    {
                        PurchaseTransactionPayKey = objPurchaseTransactionPayments.PurchaseTransactionPayKey,
                        PurchaseTransactionPayType = objPurchaseTransactionPayments.PurchaseTransactionPayType,
                        PurchaseTransactionPayDate = objPurchaseTransactionPayments.PurchaseTransactionPayDate,
                        PurchaseTransactionPayBankFKey = objPurchaseTransactionPayments.PurchaseTransactionPayBankFKey,
                        PurchaseTransactionPayBankFKeyName = objPurchaseTransactionPayments.PurchaseTransactionPayBankFKeyName,
                        PurchaseTransactionPayBankChequeNo = objPurchaseTransactionPayments.PurchaseTransactionPayBankChequeNo,
                        PurchaseTransactionPayAmount = objPurchaseTransactionPayments.PurchaseTransactionPayAmount,
                        Mode = objPurchaseTransactionPayments.Mode,
                        PurchaseTransactionPayChequeDate = objPurchaseTransactionPayments.PurchaseTransactionPayChequeDate,
                        PurchaseActualTransactionPayDate = objPurchaseTransactionPayments.PurchaseActualTransactionPayDate,
                        PurchaseActualTransactionCheckDate = objPurchaseTransactionPayments.PurchaseActualTransactionCheckDate,
                        Index = listIndex + 1
                    });
                    listIndex += 1;
                }

                if (objPurchaseTransactionPayments.PurchaseTransactionPayKey == 0 && "UPDATE" == objPurchaseTransactionPayments.Mode)
                {
                    var EditList = lstTranSactionPayments.Where(x => x.Index.Equals(objPurchaseTransactionPayments.Index)).FirstOrDefault();

                    if (EditList != null)
                    {
                        EditList.PurchaseTransactionPayKey = objPurchaseTransactionPayments.PurchaseTransactionPayKey;
                        EditList.PurchaseTransactionPayType = objPurchaseTransactionPayments.PurchaseTransactionPayType;
                        EditList.PurchaseTransactionPayDate = objPurchaseTransactionPayments.PurchaseTransactionPayDate;
                        EditList.PurchaseTransactionPayBankFKey = objPurchaseTransactionPayments.PurchaseTransactionPayBankFKey;
                        EditList.PurchaseTransactionPayBankChequeNo = objPurchaseTransactionPayments.PurchaseTransactionPayBankChequeNo;
                        EditList.PurchaseTransactionPayAmount = objPurchaseTransactionPayments.PurchaseTransactionPayAmount;
                        EditList.PurchaseTransactionPayBankFKeyName = objPurchaseTransactionPayments.PurchaseTransactionPayBankFKeyName;
                        EditList.PurchaseTransactionPayChequeDate = objPurchaseTransactionPayments.PurchaseTransactionPayChequeDate;
                        EditList.PurchaseActualTransactionPayDate = objPurchaseTransactionPayments.PurchaseActualTransactionPayDate;
                        EditList.PurchaseActualTransactionCheckDate = objPurchaseTransactionPayments.PurchaseActualTransactionCheckDate;
                        //Index  =  listIndex + 1
                    }
                    //listIndex += 1;
                }
                if (objPurchaseTransactionPayments.PurchaseTransactionPayKey == 0 && "DELETE" == objPurchaseTransactionPayments.Mode)
                {
                    var EditList = lstTranSactionPayments.Where(x => x.Index.Equals(objPurchaseTransactionPayments.Index)).FirstOrDefault();
                    if (EditList != null)
                    {
                        EditList.Mode = objPurchaseTransactionPayments.Mode;
                    }
                    //Index = listIndex + 1
                }

                if (objPurchaseTransactionPayments.PurchaseTransactionPayKey > 0)
                {
                    var EditList = lstTranSactionPayments.Where(x => x.Index.Equals(objPurchaseTransactionPayments.Index)).FirstOrDefault();

                    if (EditList != null)
                    {
                        EditList.PurchaseTransactionPayKey = objPurchaseTransactionPayments.PurchaseTransactionPayKey;
                        EditList.PurchaseTransactionPayType = objPurchaseTransactionPayments.PurchaseTransactionPayType;
                        EditList.PurchaseTransactionPayDate = objPurchaseTransactionPayments.PurchaseTransactionPayDate;
                        EditList.PurchaseTransactionPayBankFKey = objPurchaseTransactionPayments.PurchaseTransactionPayBankFKey;
                        EditList.PurchaseTransactionPayBankChequeNo = objPurchaseTransactionPayments.PurchaseTransactionPayBankChequeNo;
                        EditList.PurchaseTransactionPayAmount = objPurchaseTransactionPayments.PurchaseTransactionPayAmount;
                        EditList.PurchaseTransactionPayBankFKeyName = objPurchaseTransactionPayments.PurchaseTransactionPayBankFKeyName;
                        EditList.Mode = objPurchaseTransactionPayments.Mode;
                        EditList.PurchaseTransactionPayChequeDate = objPurchaseTransactionPayments.PurchaseTransactionPayChequeDate;
                        EditList.PurchaseActualTransactionPayDate = objPurchaseTransactionPayments.PurchaseActualTransactionPayDate;
                        EditList.PurchaseActualTransactionCheckDate = objPurchaseTransactionPayments.PurchaseActualTransactionCheckDate;
                    }
                    //listIndex += 1;
                }

                var templist = new List<clsPurchaseTransactionPaymentMember>();
                listIndex = 1;
                foreach (var item in lstTranSactionPayments)
                {
                    templist.Add(new clsPurchaseTransactionPaymentMember
                    {
                        PurchaseTransactionPayKey = item.PurchaseTransactionPayKey,
                        PurchaseTransactionPayType = item.PurchaseTransactionPayType,
                        PurchaseTransactionPayDate = item.PurchaseTransactionPayDate,
                        PurchaseTransactionPayBankFKey = item.PurchaseTransactionPayBankFKey,
                        PurchaseTransactionPayBankFKeyName = item.PurchaseTransactionPayBankFKeyName,
                        PurchaseTransactionPayBankChequeNo = item.PurchaseTransactionPayBankChequeNo,
                        PurchaseTransactionPayAmount = item.PurchaseTransactionPayAmount,
                        PurchaseTransactionPayChequeDate = item.PurchaseTransactionPayChequeDate,
                        PurchaseActualTransactionPayDate = item.PurchaseActualTransactionPayDate ,
                        PurchaseActualTransactionCheckDate = item.PurchaseActualTransactionCheckDate,
                        Mode  = item.Mode,
                        Index = listIndex,
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

        public static string GetPurchasePaymentXML(List<clsPurchaseTransactionPaymentMember> lstPurchaseTransactionPayments)
        {
            try
            {
                StringBuilder sbXML = new StringBuilder();
                sbXML.Append("<PurchaseMaster>");

                //var objList = (List<clsSupplier2ProductMember>)HttpContext.Current.Cache[clsCacheKeys.SupplierContactKey];

                if (lstPurchaseTransactionPayments == null)
                {
                    throw new Exception("Technical Error Saving Records");
                }
                foreach (var item in lstPurchaseTransactionPayments)
                {
                    if (item.Mode != "Edit")
                    {
                        sbXML.AppendFormat(@"<PurchasePayment   
                                                    PurchaseTransactionPayKey    =""{0}""          PurchaseTransactionPayType         =""{1}""  
                                                    PurchaseTransactionPayDate   =""{2}""          PurchaseTransactionPayBankFKey     =""{3}""
                                                    PurchaseTransactionPayAmount =""{4}""          PurchaseTransactionPayBankChequeNo =""{5}""
                                                    Mode                         =""{6}""          PurchaseTransactionPayChequeDate   =""{7}""/>",
                                                    item.PurchaseTransactionPayKey, item.PurchaseTransactionPayType,
                                                    Convert.ToDateTime(item.PurchaseTransactionPayDate).ToString("MM/dd/yyyy"), item.PurchaseTransactionPayBankFKey,
                                                    item.PurchaseTransactionPayAmount, item.PurchaseTransactionPayBankChequeNo,
                                                    item.Mode, item.PurchaseTransactionPayType.Equals("Bank") ? Convert.ToDateTime(item.PurchaseTransactionPayChequeDate).ToString("MM/dd/yyyy") : String.Empty);
                    }
                }
                sbXML.Append("</PurchaseMaster>");
                return sbXML.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}








