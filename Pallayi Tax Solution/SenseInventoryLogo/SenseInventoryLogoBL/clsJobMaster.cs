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
    public class clsJobMasterMember
    {
        public int JobMasterKey { get; set; }
        public String  JobMasterDate { get; set; }
        public int JobMasterJobPersionFKey { get; set; }
        public String JobMasterBillBookNo { get; set; }
        public String JobMasterInvoiceNo { get; set; }
        public String JobMasterInvoiceDate { get; set; }
        public String JobMasterChlnNo { get; set; }
        public String JobMasterChlnDate { get; set; }
        public Decimal JobMasterGrossTotal { get; set; }
        public Decimal JobMasterCartage { get; set; }
        public Decimal JobMasterSubTotal { get; set; }
        public Decimal JobMasterVatPerc { get; set; }
        public Decimal JobMasterVatAmount { get; set; }
        public int UserID { get; set; }
        public int CompanyID { get; set; }
        public String Mode { get; set; }
        public List<clsJobTransactionMember> lstJobTransaction { get; set; }
        public String JobTransactionXML { get; set; }
        public Decimal JobMasterMainTotal { get; set; }
        public String JobMasterJobPersionDetail { get; set; }
        public String JobMasterJobPersionFKeyName { get; set; }
        public String JobMasterJobPersionFKeyAddress { get; set; }
        public String FromDate { get; set; }
        public String ToDate { get; set; }
        public Decimal JobMasterAddTaxPer { get; set; }
        public Decimal JobMasterAddTaxAmt { get; set; }
        public Decimal JobMasterDiscPer { get; set; }
        public Decimal JobMasterDiscAmount { get; set; }
        public Decimal JobMasterItemAmt { get; set; }
        public String JobMasterType { get; set; }
        public int JobMasterDiscountCalculate { get; set; }
        public List<clsJobTransactionPaymentMember> lstJobPayment { get; set; }
        public String JobMasterPaymentXML { get; set; }
        public Decimal JobMasterPaidAmount { get; set; }
        public Decimal JobMasterPendingAmount { get; set; }
        public String JobMasterPoNo { get; set; }
        public String TranMasterTransportDetail { get; set; }
        public String JobMasterNoofKey { get; set; }
        public Decimal JobMasterISGTPer { get; set; }
        public Decimal JobMasterISGTAmount { get; set; }
        public String JobMasterReverseCharge { get; set; }
        public String JobMasterVehicleNo { get; set; }
        public String JobMasterActualDate { get; set; }
    }
    public class clsJobMaster : clsJobMasterMember
    {
        public DataSet Report_JobRegister()
        {
            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[] 
                                {
                                    new SqlParameter("@JobMasterJobPersionFKeyName"	     ,   JobMasterJobPersionFKeyName	  ),
                                    new SqlParameter("@JobMasterJobPersionFKeyAddress"	 ,   JobMasterJobPersionFKeyAddress),
                                    new SqlParameter("@FromDate"	                         ,   FromDate						  ),
                                    new SqlParameter("@ToDate"	                             ,   ToDate							  ),

                                    new SqlParameter("@UserID"                               ,   UserID                           ),
                                    new SqlParameter("@CompanyID"	                         ,   CompanyID                        ),
                                    new SqlParameter("@Action"                               ,   Mode                             ) 
                                };
                DataSet ds = objSql.ExecuteDataSet("Report_JobRegister", objParams);
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
                    new SqlParameter("@JobMasterKey"            ,   JobMasterKey              ),
                    new SqlParameter("@JobMasterDate"           ,   JobMasterDate             ),
                    new SqlParameter("@JobMasterJobPersionFKey"   ,   JobMasterJobPersionFKey     ),
                    new SqlParameter("@JobMasterBillBookNo"     ,   JobMasterBillBookNo       ),
                    new SqlParameter("@JobMasterInvoiceNo"      ,   JobMasterInvoiceNo        ),
                    new SqlParameter("@JobMasterInvoiceDate"    ,   JobMasterInvoiceDate      ),
                    new SqlParameter("@JobMasterChlnNo"         ,   JobMasterChlnNo           ),
                    new SqlParameter("@JobMasterChlnDate"       ,   JobMasterChlnDate         ),
                    new SqlParameter("@JobMasterGrossTotal"     ,   JobMasterGrossTotal       ),
                    new SqlParameter("@JobMasterCartage"        ,   JobMasterCartage          ),
                    new SqlParameter("@JobMasterSubTotal"       ,   JobMasterSubTotal         ),
                    new SqlParameter("@JobMasterVatPerc"        ,   JobMasterVatPerc          ),
                    new SqlParameter("@JobMasterVatAmount"       ,   JobMasterVatAmount       ),
                    new SqlParameter("@JobTransactionXML"       ,   JobTransactionXML         ),
                    new SqlParameter("@JobMasterMainTotal"      ,   JobMasterMainTotal        ),
                    new SqlParameter("@JobMasterJobPersionDetail" ,   JobMasterJobPersionDetail   ),
                    new SqlParameter("@JobMasterAddTaxPer" ,        JobMasterAddTaxPer        ),
                    new SqlParameter("@JobMasterAddTaxAmt" ,        JobMasterAddTaxAmt        ),
                    new SqlParameter("@JobMasterDiscPer" ,          JobMasterDiscPer          ),
                    new SqlParameter("@JobMasterDiscAmount" ,       JobMasterDiscAmount       ),
                    new SqlParameter("@JobMasterItemAmt"    ,       JobMasterItemAmt          ),
                    new SqlParameter("@JobMasterType"       ,       JobMasterType             ),
                    new SqlParameter("@JobMasterDiscountCalculate", JobMasterDiscountCalculate),
                    new SqlParameter("@JobMasterPaymentXML"       , JobMasterPaymentXML       ),
                    new SqlParameter("@JobMasterPaidAmount"       , JobMasterPaidAmount       ),
                    new SqlParameter("@JobMasterPendingAmount"    , JobMasterPendingAmount    ),
                    new SqlParameter("@JobMasterPoNo"             , JobMasterPoNo             ),
                    new SqlParameter("@TranMasterTransportDetail"      , TranMasterTransportDetail      ),
                    new SqlParameter("@JobMasterISGTPer"          , JobMasterISGTPer          ),
                    new SqlParameter("@JobMasterISGTAmount"       , JobMasterISGTAmount       ),
                    new SqlParameter("@JobMasterReverseCharge"    , JobMasterReverseCharge    ),
                    new SqlParameter("@JobMasterVehicleNo"        , JobMasterVehicleNo        ),
                    
                    new SqlParameter("@UserID"		              ,   UserID	                  ), 
                    new SqlParameter("@CompanyID"		          ,   CompanyID	                  ),
                    new SqlParameter("@Action"                    ,	  Mode	                      )
                };
                int result = objSql.ExecuteNonQuery("JobMasterSave", objParam);
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
                            new SqlParameter("@Action"                   ,   "SELECTONE"                  ) 
                        };

                DataSet ds = objSql.ExecuteDataSet("BillBookInvoiceNoGet", objParams);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<clsJobMasterMember> GetJobMaster()
        {
            List<clsJobMasterMember> objList = new List<clsJobMasterMember>();
            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[] 
                {
                    new SqlParameter("@JobMasterKey"	 ,   JobMasterKey  ),
                                                                
                    new SqlParameter("@UserID"           ,   UserID          ),
                    new SqlParameter("@CompanyID"	     ,   CompanyID       ),
                    new SqlParameter("@Action"           ,   Mode            ) 
                };

                DataSet ds = objSql.ExecuteDataSet("JobMasterGet", objParams);

                if (ds != null)
                {
                    clsJobMasterMember objJobMaster = new clsJobMasterMember();
                    #region JobMaster
                    if (ds.Tables.Count > 0)
                    {
                        foreach (DataRow r in ds.Tables[0].Rows)
                        {
                            objJobMaster.JobMasterKey = Convert.ToInt32(r["JobMasterKey"] ?? -1);
                            objJobMaster.JobMasterDate = (r["JobMasterDate"] ?? "").ToString();
                            objJobMaster.JobMasterActualDate = (r["JobMasterActualDate"] ?? "").ToString();
                            objJobMaster.JobMasterJobPersionFKey = Convert.ToInt32(r["JobMasterJobPersionFKey"] ?? -1);
                            objJobMaster.JobMasterBillBookNo = (r["JobMasterBillBookNo"] ?? "").ToString();
                            objJobMaster.JobMasterInvoiceNo = (r["JobMasterInvoiceNo"] ?? "").ToString();
                            objJobMaster.JobMasterChlnNo = (r["JobMasterChlnNo"] ?? "").ToString();
                            objJobMaster.JobMasterChlnDate = (r["JobMasterChlnDate"] ?? "").ToString();
                            objJobMaster.JobMasterGrossTotal = Convert.ToDecimal(r["JobMasterGrossTotal"] ?? -1);
                            objJobMaster.JobMasterCartage = Convert.ToDecimal(r["JobMasterCartage"] ?? -1);
                            objJobMaster.JobMasterSubTotal = Convert.ToDecimal(r["JobMasterSubTotal"] ?? -1);
                            objJobMaster.JobMasterVatPerc = Convert.ToDecimal(r["JobMasterVatPerc"] ?? -1);
                            objJobMaster.JobMasterVatAmount = Convert.ToDecimal(r["JobMasterVatAmount"] ?? -1);
                            objJobMaster.JobMasterMainTotal = Convert.ToDecimal(r["JobMasterMainTotal"] ?? -1);
                            objJobMaster.JobMasterJobPersionDetail = (r["JobMasterJobPersionDetail"] ?? "").ToString();
                            objJobMaster.JobMasterAddTaxPer = Convert.ToDecimal(r["JobMasterAddTaxPer"] ?? -1);
                            objJobMaster.JobMasterAddTaxAmt = Convert.ToDecimal(r["JobMasterAddTaxAmt"] ?? -1);
                            objJobMaster.JobMasterDiscPer = Convert.ToDecimal(r["JobMasterDiscPer"] ?? -1);
                            objJobMaster.JobMasterDiscAmount = Convert.ToDecimal(r["JobMasterDiscAmount"] ?? -1);
                            objJobMaster.JobMasterItemAmt = Convert.ToDecimal(r["JobMasterItemAmt"] ?? -1);
                            objJobMaster.JobMasterType = (r["JobMasterType"] ?? "").ToString();
                            objJobMaster.JobMasterDiscountCalculate = Convert.ToInt32(r["JobMasterDiscountCalculate"] ?? -1);
                            objJobMaster.JobMasterPaidAmount = Convert.ToDecimal(r["JobMasterPaidAmount"] ?? -1);
                            objJobMaster.JobMasterPendingAmount = Convert.ToDecimal(r["JobMasterPendingAmount"] ?? -1);
                            objJobMaster.JobMasterPoNo = (r["JobMasterPoNo"] ?? "").ToString();
                            objJobMaster.TranMasterTransportDetail = (r["TranMasterTransportDetail"] ?? "").ToString();
                            objJobMaster.JobMasterISGTPer = Convert.ToDecimal(r["JobMasterISGTPer"] ?? -1);
                            objJobMaster.JobMasterISGTAmount = Convert.ToDecimal(r["JobMasterISGTAmount"] ?? -1);
                            objJobMaster.JobMasterReverseCharge = (r["JobMasterReverseCharge"] ?? "").ToString();
                            objJobMaster.JobMasterVehicleNo = (r["JobMasterVehicleNo"] ?? "").ToString();
                        }
                    }
                    objList.Add(objJobMaster);

                    #endregion

                    #region JobMaster2JobTransaction
                    if (ds.Tables.Count > 1)
                    {
                        List<clsJobTransactionMember> objJobMaster2JobTransaction = new List<clsJobTransactionMember>();
                        //int RowIndex = 1;
                        foreach (DataRow r in ds.Tables[1].Rows)
                        {
                            objJobMaster2JobTransaction.Add(new clsJobTransactionMember
                            {
                                JobTransactionKey = Convert.ToInt32((r["JobTransactionKey"] ?? -1)),
                                JobTransactionItemFKey = Convert.ToInt32((r["JobTransactionItemFKey"] ?? -1)),
                                JobTransactionItemGroupFKey = Convert.ToInt32((r["JobTransactionItemGroupFKey"] ?? -1)),
                                JobTransactionQty = Convert.ToInt32((r["JobTransactionQty"] ?? -1)),
                                JobTransactionRate = Convert.ToDecimal((r["JobTransactionRate"] ?? 0)),
                                JobTransactionTotal = Convert.ToDecimal((r["JobTransactionTotal"] ?? 0)),
                                JobTransactionSaleMasterFKey = Convert.ToInt32((r["JobTransactionSaleMasterFKey"] ?? -1)),
                                JobTransactionItemGroupFKeyName = (r["JobTransactionItemGroupFKeyName"] ?? "").ToString(),
                                JobTransactionItemFKeyName = (r["JobTransactionItemFKeyName"] ?? "").ToString(),
                                Mode = (r["Mode"] ?? "").ToString(),
                                Index = Convert.ToInt32((r["Index"] ?? -1)),
                                JobTransactionPoNo = (r["JobTransactionPoNo"] ?? "").ToString(),
                                JobTransactionHsnCode = (r["JobTransactionHsnCode"] ?? "").ToString(),
                                JobTransactionCGSTPer = Convert.ToDecimal((r["JobTransactionCGSTPer"] ?? -1)),
                                JobTransactionCGSTAmt = Convert.ToDecimal((r["JobTransactionCGSTAmt"] ?? -1)),
                                JobTransactionTaxableAmt = Convert.ToDecimal((r["JobTransactionTaxableAmt"] ?? -1)),
                                JobTransactionSGSTPer = Convert.ToDecimal((r["JobTransactionSGSTPer"] ?? -1)),
                                JobTransactionSGSTAmt = Convert.ToDecimal((r["JobTransactionSGSTAmt"] ?? -1)),
                                JobTransactionIGSTPer = Convert.ToDecimal((r["JobTransactionIGSTPer"] ?? -1)),
                                JobTransactionIGSTAmt = Convert.ToDecimal((r["JobTransactionIGSTAmt"] ?? -1)),
                            });
                        }
                        objJobMaster.lstJobTransaction = objJobMaster2JobTransaction;
                    }
                    #endregion

                    #region JobMaster2JobPayment
                    if (ds.Tables.Count > 2)
                    {
                        List<clsJobTransactionPaymentMember> objJobMaster2JobPayment = new List<clsJobTransactionPaymentMember>();
                        //int RowIndex = 1;
                        foreach (DataRow r in ds.Tables[2].Rows)
                        {
                            objJobMaster2JobPayment.Add(new clsJobTransactionPaymentMember
                            {
                                JobTransactionPayKey = Convert.ToInt32((r["JobTransactionPayKey"] ?? -1)),
                                JobTransactionPayType = (r["JobTransactionPayType"] ?? "").ToString(),
                                JobTransactionPayDate = (r["JobTransactionPayDate"] ?? "").ToString(),
                                JobTransactionPayBankFKey = Convert.ToInt32((r["JobTransactionPayBankFKey"] ?? -1)),
                                JobTransactionPayBankFKeyName = (r["JobTransactionPayBankFKeyName"] ?? "").ToString(),
                                JobTransactionPayBankChequeNo = (r["JobTransactionPayBankChequeNo"] ?? "").ToString(),
                                JobTransactionPayAmount = Convert.ToDecimal((r["JobTransactionPayAmount"] ?? -1)),
                                JobTransactionPayChequeDate = (r["JobTransactionPayChequeDate"] ?? "").ToString(),
                                Mode = (r["Mode"] ?? "").ToString(),
                                Index = Convert.ToInt32((r["Index"] ?? -1)),
                            });
                        }
                        objJobMaster.lstJobPayment = objJobMaster2JobPayment;
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

        public DataSet GetJobMasterReport()
        {
            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[] 
                {
                    new SqlParameter("@JobMasterKey"	 ,   JobMasterKey      ),

                    new SqlParameter("@JobMasterNoofKey",  JobMasterNoofKey  ),
                    new SqlParameter("@UserID"           ,   UserID              ),
                    new SqlParameter("@CompanyID"	     ,   CompanyID           ),
                    new SqlParameter("@Action"           ,   Mode                ) 
                };
                DataSet ds = objSql.ExecuteDataSet("JobMasterReport", objParams);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet SearchJobMaster()
        {
            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[] 
                                {
                                    new SqlParameter("@JobMasterJobPersionFKeyName"	     ,   JobMasterJobPersionFKeyName	  ),
                                    new SqlParameter("@JobMasterJobPersionFKeyAddress"	 ,   JobMasterJobPersionFKeyAddress	  ),
                                    new SqlParameter("@FromDate"	                     ,   FromDate						  ),
                                    new SqlParameter("@ToDate"	                         ,   ToDate							  ),
                                    new SqlParameter("@JobMasterType"	                 ,   JobMasterType				  ),

                                    new SqlParameter("@UserID"                           ,   UserID                           ),
                                    new SqlParameter("@CompanyID"	                     ,   CompanyID                        ),
                                    new SqlParameter("@Action"                           ,   Mode                             ) 
                                };

                DataSet ds = objSql.ExecuteDataSet("JobMasterSearch", objParams);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet SearchJobMasterItemJobPaymentReport()
        {
            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[] 
                                {
                                    new SqlParameter("@JobMasterJobPersionFKey"	        ,   JobMasterJobPersionFKey	          ),
                                    new SqlParameter("@JobMasterJobPersionFKeyAddress"	 ,   JobMasterJobPersionFKeyAddress	  ),
                                    new SqlParameter("@FromDate"	                     ,   FromDate						  ),
                                    new SqlParameter("@ToDate"	                         ,   ToDate							  ),
                                    new SqlParameter("@JobMasterType"	                 ,   JobMasterType				      ),

                                    new SqlParameter("@UserID"                           ,   UserID                           ),
                                    new SqlParameter("@CompanyID"	                     ,   CompanyID                        ),
                                    new SqlParameter("@Action"                           ,   Mode                             ) 
                                };
                DataSet ds = objSql.ExecuteDataSet("JobMasterItemJobPaymentReport", objParams);
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

    public class clsJobTransactionMember : clsJobMasterMember
    {
        public int JobTransactionKey { get; set; }
        public int JobTransactionItemFKey { get; set; }
        public Decimal JobTransactionQty { get; set; }
        public Decimal JobTransactionRate { get; set; }
        public Decimal JobTransactionTotal { get; set; }
        public int JobTransactionSaleMasterFKey { get; set; }
        public int Index { get; set; }
        public String JobTransactionItemFKeyName { get; set; }
        public int JobTransactionItemGroupFKey { get; set; }
        public String JobTransactionItemGroupFKeyName { get; set; }
        public String JobTransactionPoNo { get; set; }
        public String JobTransactionHsnCode { get; set; }
        public Decimal JobTransactionCGSTPer { get; set; }
        public Decimal JobTransactionCGSTAmt { get; set; }
        public Decimal JobTransactionSGSTPer { get; set; }
        public Decimal JobTransactionSGSTAmt { get; set; }
        public Decimal JobTransactionIGSTPer { get; set; }
        public Decimal JobTransactionIGSTAmt { get; set; }
        public Decimal JobTransactionTaxableAmt { get; set; }
        public static List<clsJobTransactionMember> AddUpdateDeleteJobTransaction(clsJobTransactionMember objJobTransaction, List<clsJobTransactionMember> lstTranSaction)
        {
            //List<clsJobTransactionMember> lstTranSaction = new List<clsJobTransactionMember>();
            try
            {
                int listIndex = 0;
                //if ((List<clsJobTransactionMember>)HttpContext.Current.Cache[clsCacheKeys.JobPersion2ProductCacheKey] != null)
                //{
                //    lstTranSaction = (List<clsJobTransactionMember>)HttpContext.Current.Cache[clsCacheKeys.JobPersion2ProductCacheKey];
                //    listIndex = lstTranSaction.Count;
                //}

                //var query = lstTranSaction.FindAll(x => x.JobPersionFirstName.Equals(objJobTransaction.JobPersionFirstName) && x.Mode != "DELETE"
                //    && x.Index != objJobTransaction.Index);
                //if (query.Count > 0)
                //{
                //    throw new Exception(SetMessageFormatLI("duplicate entry not allowed"));
                //}
                if (lstTranSaction != null)
                {
                    listIndex = lstTranSaction.Count;
                }

                if (objJobTransaction.JobTransactionKey == 0 && "ADD" == objJobTransaction.Mode)
                {
                    lstTranSaction.Add(new clsJobTransactionMember
                    {
                        JobTransactionKey = objJobTransaction.JobTransactionKey,
                        JobTransactionItemFKey = objJobTransaction.JobTransactionItemFKey,
                        JobTransactionQty = objJobTransaction.JobTransactionQty,
                        JobTransactionRate = objJobTransaction.JobTransactionRate,
                        JobTransactionTotal = objJobTransaction.JobTransactionTotal,
                        JobTransactionItemFKeyName = objJobTransaction.JobTransactionItemFKeyName,
                        JobTransactionItemGroupFKey = objJobTransaction.JobTransactionItemGroupFKey,
                        JobTransactionItemGroupFKeyName = objJobTransaction.JobTransactionItemGroupFKeyName,
                        Mode = objJobTransaction.Mode,
                        Index = listIndex + 1,
                        JobTransactionPoNo = objJobTransaction.JobTransactionPoNo,
                        JobTransactionHsnCode = objJobTransaction.JobTransactionHsnCode,
                        JobTransactionCGSTPer = objJobTransaction.JobTransactionCGSTPer,
                        JobTransactionCGSTAmt = objJobTransaction.JobTransactionCGSTAmt,
                        JobTransactionTaxableAmt = objJobTransaction.JobTransactionTaxableAmt,
                        JobTransactionSGSTPer = objJobTransaction.JobTransactionSGSTPer,
                        JobTransactionSGSTAmt = objJobTransaction.JobTransactionSGSTAmt,
                        JobTransactionIGSTPer = objJobTransaction.JobTransactionIGSTPer,
                        JobTransactionIGSTAmt = objJobTransaction.JobTransactionIGSTAmt,
                    });
                    listIndex += 1;
                }

                if (objJobTransaction.JobTransactionKey == 0 && "UPDATE" == objJobTransaction.Mode)
                {
                    var EditList = lstTranSaction.Where(x => x.Index.Equals(objJobTransaction.Index)).FirstOrDefault();

                    if (EditList != null)
                    {
                        EditList.JobTransactionKey = objJobTransaction.JobTransactionKey;
                        EditList.JobTransactionItemFKey = objJobTransaction.JobTransactionItemFKey;
                        EditList.JobTransactionQty = objJobTransaction.JobTransactionQty;
                        EditList.JobTransactionRate = objJobTransaction.JobTransactionRate;
                        EditList.JobTransactionTotal = objJobTransaction.JobTransactionTotal;
                        EditList.JobTransactionItemFKeyName = objJobTransaction.JobTransactionItemFKeyName;
                        EditList.JobTransactionItemGroupFKey = objJobTransaction.JobTransactionItemGroupFKey;
                        EditList.JobTransactionItemGroupFKeyName = objJobTransaction.JobTransactionItemGroupFKeyName;
                        EditList.JobTransactionPoNo = objJobTransaction.JobTransactionPoNo;
                        EditList.JobTransactionHsnCode = objJobTransaction.JobTransactionHsnCode;
                        EditList.JobTransactionCGSTPer = objJobTransaction.JobTransactionCGSTPer;
                        EditList.JobTransactionCGSTAmt = objJobTransaction.JobTransactionCGSTAmt;
                        EditList.JobTransactionSGSTPer = objJobTransaction.JobTransactionSGSTPer;
                        EditList.JobTransactionSGSTAmt = objJobTransaction.JobTransactionSGSTAmt;
                        EditList.JobTransactionIGSTPer = objJobTransaction.JobTransactionIGSTPer;
                        EditList.JobTransactionIGSTAmt = objJobTransaction.JobTransactionIGSTAmt;
                        EditList.JobTransactionTaxableAmt = objJobTransaction.JobTransactionTaxableAmt;
                        //Index  =  listIndex + 1
                    }
                    //listIndex += 1;
                }
                if (objJobTransaction.JobTransactionKey == 0 && "DELETE" == objJobTransaction.Mode)
                {
                    var EditList = lstTranSaction.Where(x => x.Index.Equals(objJobTransaction.Index)).FirstOrDefault();
                    if (EditList != null)
                    {
                        EditList.Mode = objJobTransaction.Mode;
                    }
                    //Index = listIndex + 1
                }

                if (objJobTransaction.JobTransactionKey > 0)
                {
                    var EditList = lstTranSaction.Where(x => x.Index.Equals(objJobTransaction.Index)).FirstOrDefault();

                    if (EditList != null)
                    {
                        EditList.JobTransactionKey = objJobTransaction.JobTransactionKey;
                        EditList.JobTransactionItemFKey = objJobTransaction.JobTransactionItemFKey;
                        EditList.JobTransactionQty = objJobTransaction.JobTransactionQty;
                        EditList.JobTransactionRate = objJobTransaction.JobTransactionRate;
                        EditList.JobTransactionTotal = objJobTransaction.JobTransactionTotal;
                        EditList.JobTransactionItemFKeyName = objJobTransaction.JobTransactionItemFKeyName;
                        EditList.JobTransactionItemGroupFKeyName = objJobTransaction.JobTransactionItemGroupFKeyName;
                        EditList.JobTransactionItemGroupFKey = objJobTransaction.JobTransactionItemGroupFKey;
                        EditList.Mode = objJobTransaction.Mode;
                        EditList.JobTransactionPoNo = objJobTransaction.JobTransactionPoNo;
                        EditList.JobTransactionHsnCode = objJobTransaction.JobTransactionHsnCode;
                        EditList.JobTransactionCGSTPer = objJobTransaction.JobTransactionCGSTPer;
                        EditList.JobTransactionCGSTAmt = objJobTransaction.JobTransactionCGSTAmt;
                        EditList.JobTransactionSGSTPer = objJobTransaction.JobTransactionSGSTPer;
                        EditList.JobTransactionSGSTAmt = objJobTransaction.JobTransactionSGSTAmt;
                        EditList.JobTransactionIGSTPer = objJobTransaction.JobTransactionIGSTPer;
                        EditList.JobTransactionIGSTAmt = objJobTransaction.JobTransactionIGSTAmt;
                        EditList.JobTransactionTaxableAmt = objJobTransaction.JobTransactionTaxableAmt;
                    }
                    //listIndex += 1;
                }

                var templist = new List<clsJobTransactionMember>();
                listIndex = 1;
                foreach (var item in lstTranSaction)
                {
                    templist.Add(new clsJobTransactionMember
                    {
                        JobTransactionKey = item.JobTransactionKey,
                        JobTransactionItemFKey = item.JobTransactionItemFKey,
                        JobTransactionQty = item.JobTransactionQty,
                        JobTransactionRate = item.JobTransactionRate,
                        JobTransactionTotal = item.JobTransactionTotal,
                        JobTransactionItemFKeyName = item.JobTransactionItemFKeyName,
                        JobTransactionItemGroupFKey = item.JobTransactionItemGroupFKey,
                        JobTransactionItemGroupFKeyName = item.JobTransactionItemGroupFKeyName,
                        Mode = item.Mode,
                        Index = listIndex,
                        JobTransactionPoNo = item.JobTransactionPoNo,
                        JobTransactionHsnCode = item.JobTransactionHsnCode,
                        JobTransactionCGSTPer = item.JobTransactionCGSTPer,
                        JobTransactionCGSTAmt = item.JobTransactionCGSTAmt,
                        JobTransactionSGSTPer = item.JobTransactionSGSTPer,
                        JobTransactionSGSTAmt = item.JobTransactionSGSTAmt,
                        JobTransactionIGSTPer = item.JobTransactionIGSTPer,
                        JobTransactionIGSTAmt = item.JobTransactionIGSTAmt,
                        JobTransactionTaxableAmt = item.JobTransactionTaxableAmt,
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
        public static string GetJobTransactionXML(List<clsJobTransactionMember> lstJobTransaction)
        {
            try
            {
                StringBuilder sbXML = new StringBuilder();
                sbXML.Append("<JobMaster>");

                //var objList = (List<clsJobPersion2ProductMember>)HttpContext.Current.Cache[clsCacheKeys.JobPersionContactKey];

                if (lstJobTransaction == null)
                {
                    throw new Exception("Technical Error Saving Records");
                }
                foreach (var item in lstJobTransaction)
                {
                    if (item.Mode != "Edit")
                    {
                        sbXML.AppendFormat(@"<JobTransaction   
                                                    JobTransactionKey    =""{0}""          JobTransactionItemFKey         =""{1}""  
                                                    JobTransactionQty    =""{2}""          JobTransactionRate             =""{3}""
                                                    JobTransactionTotal  =""{4}""          JobTransactionItemGroupFKey    =""{5}""
                                                    Mode                   =""{6}""             JobTransactionPoNo             =""{7}""
                                                    JobTransactionHsnCode=""{8}""          JobTransactionCGSTPer          =""{9}""  
                                                    JobTransactionCGSTAmt=""{10}""         JobTransactionTaxableAmt       =""{11}"" 
                                                    JobTransactionSGSTPer=""{12}""         JobTransactionSGSTAmt          =""{13}"" 
                                                    JobTransactionIGSTPer=""{14}""         JobTransactionIGSTAmt          =""{15}"" 
                                                    />",
                                                    item.JobTransactionKey, item.JobTransactionItemFKey,
                                                    item.JobTransactionQty, item.JobTransactionRate,
                                                    item.JobTransactionTotal, item.JobTransactionItemGroupFKey,
                                                    item.Mode, item.JobTransactionPoNo,
                                                    item.JobTransactionHsnCode,
                                                    item.JobTransactionCGSTPer,
                                                    item.JobTransactionCGSTAmt,
                                                    item.JobTransactionTaxableAmt,
                                                    item.JobTransactionSGSTPer,
                                                    item.JobTransactionSGSTAmt,
                                                    item.JobTransactionIGSTPer,
                                                    item.JobTransactionIGSTAmt
                                                    );
                    }
                }
                sbXML.Append("</JobMaster>");
                return sbXML.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

    public class clsJobTransactionPaymentMember : clsJobMasterMember
    {
        public int JobTransactionPayKey { get; set; }
        public String JobTransactionPayType { get; set; }
        public String JobTransactionPayDate { get; set; }
        public int JobTransactionPayBankFKey { get; set; }
        public String JobTransactionPayBankChequeNo { get; set; }
        public Decimal JobTransactionPayAmount { get; set; }
        public int JobTransactionPayJobMasterFKey { get; set; }
        public int Index { get; set; }
        public String JobTransactionPayBankFKeyName { get; set; }
        public String JobTransactionPayChequeDate { get; set; }
        public String JobActualTransactionPayDate { get; set; }
        public String JobActualTransactionCheckDate { get; set; }

        public static List<clsJobTransactionPaymentMember> AddUpdateDeleteJobTransactionPayments(clsJobTransactionPaymentMember objJobTransactionPayments, List<clsJobTransactionPaymentMember> lstTranSactionPayments)
        {
            //List<clsJobTransactionPaymentMember> lstTranSactionPayments = new List<clsJobTransactionPaymentMember>();
            try
            {
                int listIndex = 0;
                //if ((List<clsJobTransactionPaymentMember>)HttpContext.Current.Cache[clsCacheKeys.JobPersion2ProductCacheKey] != null)
                //{
                //    lstTranSactionPayments = (List<clsJobTransactionPaymentMember>)HttpContext.Current.Cache[clsCacheKeys.JobPersion2ProductCacheKey];
                //    listIndex = lstTranSactionPayments.Count;
                //}

                //var query = lstTranSactionPayments.FindAll(x => x.JobPersionFirstName.Equals(objJobTransactionPayments.JobPersionFirstName) && x.Mode != "DELETE"
                //    && x.Index != objJobTransactionPayments.Index);
                //if (query.Count > 0)
                //{
                //    throw new Exception(SetMessageFormatLI("duplicate entry not allowed"));
                //}
                if (lstTranSactionPayments != null)
                {
                    listIndex = lstTranSactionPayments.Count;
                }

                if (objJobTransactionPayments.JobTransactionPayKey == 0 && "ADD" == objJobTransactionPayments.Mode)
                {
                    lstTranSactionPayments.Add(new clsJobTransactionPaymentMember
                    {
                        JobTransactionPayKey = objJobTransactionPayments.JobTransactionPayKey,
                        JobTransactionPayType = objJobTransactionPayments.JobTransactionPayType,
                        JobTransactionPayDate = objJobTransactionPayments.JobTransactionPayDate,
                        JobTransactionPayBankFKey = objJobTransactionPayments.JobTransactionPayBankFKey,
                        JobTransactionPayBankFKeyName = objJobTransactionPayments.JobTransactionPayBankFKeyName,
                        JobTransactionPayBankChequeNo = objJobTransactionPayments.JobTransactionPayBankChequeNo,
                        JobTransactionPayAmount = objJobTransactionPayments.JobTransactionPayAmount,
                        Mode = objJobTransactionPayments.Mode,
                        JobTransactionPayChequeDate = objJobTransactionPayments.JobTransactionPayChequeDate,
                        JobActualTransactionPayDate = objJobTransactionPayments.JobActualTransactionPayDate,
                        JobActualTransactionCheckDate = objJobTransactionPayments.JobActualTransactionCheckDate,
                        Index = listIndex + 1
                    });
                    listIndex += 1;
                }

                if (objJobTransactionPayments.JobTransactionPayKey == 0 && "UPDATE" == objJobTransactionPayments.Mode)
                {
                    var EditList = lstTranSactionPayments.Where(x => x.Index.Equals(objJobTransactionPayments.Index)).FirstOrDefault();

                    if (EditList != null)
                    {
                        EditList.JobTransactionPayKey = objJobTransactionPayments.JobTransactionPayKey;
                        EditList.JobTransactionPayType = objJobTransactionPayments.JobTransactionPayType;
                        EditList.JobTransactionPayDate = objJobTransactionPayments.JobTransactionPayDate;
                        EditList.JobTransactionPayBankFKey = objJobTransactionPayments.JobTransactionPayBankFKey;
                        EditList.JobTransactionPayBankChequeNo = objJobTransactionPayments.JobTransactionPayBankChequeNo;
                        EditList.JobTransactionPayAmount = objJobTransactionPayments.JobTransactionPayAmount;
                        EditList.JobTransactionPayBankFKeyName = objJobTransactionPayments.JobTransactionPayBankFKeyName;
                        EditList.JobTransactionPayChequeDate = objJobTransactionPayments.JobTransactionPayChequeDate;
                        EditList.JobActualTransactionPayDate = objJobTransactionPayments.JobActualTransactionPayDate;
                        EditList.JobActualTransactionCheckDate = objJobTransactionPayments.JobActualTransactionCheckDate;
                        //Index  =  listIndex + 1
                    }
                    //listIndex += 1;
                }
                if (objJobTransactionPayments.JobTransactionPayKey == 0 && "DELETE" == objJobTransactionPayments.Mode)
                {
                    var EditList = lstTranSactionPayments.Where(x => x.Index.Equals(objJobTransactionPayments.Index)).FirstOrDefault();
                    if (EditList != null)
                    {
                        EditList.Mode = objJobTransactionPayments.Mode;
                    }
                    //Index = listIndex + 1
                }

                if (objJobTransactionPayments.JobTransactionPayKey > 0)
                {
                    var EditList = lstTranSactionPayments.Where(x => x.Index.Equals(objJobTransactionPayments.Index)).FirstOrDefault();

                    if (EditList != null)
                    {
                        EditList.JobTransactionPayKey = objJobTransactionPayments.JobTransactionPayKey;
                        EditList.JobTransactionPayType = objJobTransactionPayments.JobTransactionPayType;
                        EditList.JobTransactionPayDate = objJobTransactionPayments.JobTransactionPayDate;
                        EditList.JobTransactionPayBankFKey = objJobTransactionPayments.JobTransactionPayBankFKey;
                        EditList.JobTransactionPayBankChequeNo = objJobTransactionPayments.JobTransactionPayBankChequeNo;
                        EditList.JobTransactionPayAmount = objJobTransactionPayments.JobTransactionPayAmount;
                        EditList.JobTransactionPayBankFKeyName = objJobTransactionPayments.JobTransactionPayBankFKeyName;
                        EditList.Mode = objJobTransactionPayments.Mode;
                        EditList.JobTransactionPayChequeDate = objJobTransactionPayments.JobTransactionPayChequeDate;
                        EditList.JobActualTransactionPayDate = objJobTransactionPayments.JobActualTransactionPayDate;
                        EditList.JobActualTransactionCheckDate = objJobTransactionPayments.JobActualTransactionCheckDate;
                    }
                    //listIndex += 1;
                }

                var templist = new List<clsJobTransactionPaymentMember>();
                listIndex = 1;
                foreach (var item in lstTranSactionPayments)
                {
                    templist.Add(new clsJobTransactionPaymentMember
                    {
                        JobTransactionPayKey = item.JobTransactionPayKey,
                        JobTransactionPayType = item.JobTransactionPayType,
                        JobTransactionPayDate = item.JobTransactionPayDate,
                        JobTransactionPayBankFKey = item.JobTransactionPayBankFKey,
                        JobTransactionPayBankFKeyName = item.JobTransactionPayBankFKeyName,
                        JobTransactionPayBankChequeNo = item.JobTransactionPayBankChequeNo,
                        JobTransactionPayAmount = item.JobTransactionPayAmount,
                        JobTransactionPayChequeDate = item.JobTransactionPayChequeDate,
                        JobActualTransactionPayDate = item.JobActualTransactionPayDate,
                        JobActualTransactionCheckDate = item.JobActualTransactionCheckDate,
                        Mode = item.Mode,
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

        public static string GetJobPaymentXML(List<clsJobTransactionPaymentMember> lstJobTransactionPayments)
        {
            try
            {
                StringBuilder sbXML = new StringBuilder();
                sbXML.Append("<JobMaster>");

                //var objList = (List<clsJobPersion2ProductMember>)HttpContext.Current.Cache[clsCacheKeys.JobPersionContactKey];

                if (lstJobTransactionPayments == null)
                {
                    throw new Exception("Technical Error Saving Records");
                }
                foreach (var item in lstJobTransactionPayments)
                {
                    if (item.Mode != "Edit")
                    {
                        sbXML.AppendFormat(@"<JobPayment   
                                                    JobTransactionPayKey    =""{0}""          JobTransactionPayType         =""{1}""  
                                                    JobTransactionPayDate   =""{2}""          JobTransactionPayBankFKey     =""{3}""
                                                    JobTransactionPayAmount =""{4}""          JobTransactionPayBankChequeNo =""{5}""
                                                    Mode                      =""{6}""          JobTransactionPayChequeDate   =""{7}""/>",
                                                    item.JobTransactionPayKey, item.JobTransactionPayType,
                                                    Convert.ToDateTime(item.JobTransactionPayDate).ToString("MM/dd/yyyy"), item.JobTransactionPayBankFKey,
                                                    item.JobTransactionPayAmount, item.JobTransactionPayBankChequeNo,
                                                    item.Mode, item.JobTransactionPayType.Equals("Bank") ? Convert.ToDateTime(item.JobTransactionPayChequeDate).ToString("MM/dd/yyyy") : String.Empty);
                    }
                }
                sbXML.Append("</JobMaster>");
                return sbXML.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}








