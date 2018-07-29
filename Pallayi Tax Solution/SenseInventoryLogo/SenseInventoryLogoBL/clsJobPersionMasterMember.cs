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
    public class clsJobPersionMasterMember
    {
        public int JobPersionID { get; set; }
        public String JobPersionName { get; set; }
        public String JobPersionAddress { get; set; }
        public int JobPersionStateFKey { get; set; }
        public int JobPersionCityFKey { get; set; }
        public int JobPersionAreaFKey { get; set; }
        public String JobPersionContactNo { get; set; }
        public String JobPersionEmail { get; set; }
        public String JobPersionGSTNo { get; set; }
        public String JobPersionGSTDate { get; set; }
        public String JobPersionCSTDate { get; set; }
        public String JobPersionCSTNo { get; set; }
        public int JobPersionIsActive { get; set; }
        public int CompanyID { get; set; }
        public int UserID { get; set; }
        public String Mode { get; set; }
        public String JobPersionContactPerson { get; set; }
        public String JobPersionDetai { get; set; }
    }
    public class clsJobPersionMaster : clsJobPersionMasterMember
    {
        public int AddUpdateDelete()
        {
            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.CRUDConnString);
                SqlParameter[] objParam = new SqlParameter[]
                {
                    new SqlParameter("@JobPersionID"              ,   JobPersionID            ),
                    new SqlParameter("@JobPersionName"            ,   JobPersionName          ),
                    new SqlParameter("@JobPersionAddress"         ,   JobPersionAddress       ),
                    new SqlParameter("@JobPersionStateFKey"       ,   JobPersionStateFKey     ),
                    new SqlParameter("@JobPersionCityFKey"        ,   JobPersionCityFKey      ),
                    new SqlParameter("@JobPersionAreaFKey"        ,   JobPersionAreaFKey      ),
                    new SqlParameter("@JobPersionContactNo"       ,   JobPersionContactNo     ),
                    new SqlParameter("@JobPersionEmail"           ,   JobPersionEmail         ),
                    new SqlParameter("@JobPersionGSTNo"           ,   JobPersionGSTNo         ),
                    new SqlParameter("@JobPersionCSTNo"           ,   JobPersionCSTNo         ),
                    new SqlParameter("@JobPersionIsActive"        ,   JobPersionIsActive      ),
                    new SqlParameter("@JobPersionGSTDate"         ,   JobPersionGSTDate       ),
                    new SqlParameter("@JobPersionCSTDate"         ,   JobPersionCSTDate       ),
                    new SqlParameter("@JobPersionContactPerson"   ,   JobPersionContactPerson ),

                    new SqlParameter("@UserID"		            ,   UserID	              ), 
                    new SqlParameter("@CompanyID"		        ,   CompanyID	          ),
                    new SqlParameter("@Action"                  ,	Mode	              )
                };

                int result = objSql.ExecuteNonQuery("JobPersionMasterSave", objParam);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<clsJobPersionMasterMember> GetJobPersion()
        {
            List<clsJobPersionMasterMember> objList = new List<clsJobPersionMasterMember>();

            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[] 
                        {
                            new SqlParameter("@JobPersionID"	 ,   JobPersionID  ),
                                                                        
                            new SqlParameter("@UserID"       ,   UserID       ),
                            new SqlParameter("@CompanyID"	 ,   CompanyID    ),
                            new SqlParameter("@Action"       ,   Mode       ) 
                        };

                DataSet ds = objSql.ExecuteDataSet("JobPersionMasterGet", objParams);

                if (ds != null)
                {
                    clsJobPersionMasterMember objJobPersion = new clsJobPersionMasterMember();

                    #region JobPersion
                    if (ds.Tables.Count > 0)
                    {
                        foreach (DataRow r in ds.Tables[1].Rows)
                        {
                            objJobPersion.JobPersionID = Convert.ToInt32(r["JobPersionID"] ?? -1);
                            objJobPersion.JobPersionName = (r["JobPersionName"] ?? "").ToString();
                            objJobPersion.JobPersionAddress = (r["JobPersionAddress"] ?? "").ToString();
                            objJobPersion.JobPersionStateFKey = Convert.ToInt32(r["JobPersionStateFKey"] ?? -1);
                            objJobPersion.JobPersionCityFKey = Convert.ToInt32(r["JobPersionCityFKey"] ?? -1);
                            objJobPersion.JobPersionAreaFKey = Convert.ToInt32(r["JobPersionAreaFKey"] ?? -1);
                            objJobPersion.JobPersionContactNo = (r["JobPersionContactNo"] ?? "").ToString();
                            objJobPersion.JobPersionEmail = (r["JobPersionEmail"] ?? "").ToString();
                            objJobPersion.JobPersionGSTNo = (r["JobPersionGSTNo"] ?? "").ToString();
                            objJobPersion.JobPersionCSTNo = (r["JobPersionCSTNo"] ?? "").ToString();
                            objJobPersion.JobPersionIsActive = Convert.ToInt32(r["JobPersionActive"] ?? 0);
                            objJobPersion.CompanyID = Convert.ToInt32(r["CompanyID"] ?? 0);
                            objJobPersion.JobPersionGSTDate = (r["JobPersionGSTDate"] ?? "").ToString();
                            objJobPersion.JobPersionCSTDate = (r["JobPersionCSTDate"] ?? "").ToString();
                            objJobPersion.JobPersionDetai = (r["JobPersionDetai"] ?? "").ToString();
                            objList.Add(objJobPersion);
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

        public List<clsJobPersionMasterMember> GetJobPersionDetail()
        {
            List<clsJobPersionMasterMember> objList = new List<clsJobPersionMasterMember>();

            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[] 
                                {
                                    new SqlParameter("@JobPersionID"	 ,   JobPersionID  ),
                                                                                
                                    new SqlParameter("@UserID"       ,   UserID      ),
                                    new SqlParameter("@CompanyID"	 ,   CompanyID   ),
                                    new SqlParameter("@Action"       ,   Mode        ) 
                                };

                DataSet ds = objSql.ExecuteDataSet("JobPersionMasterGet", objParams);

                if (ds != null)
                {
                    clsJobPersionMasterMember objJobPersion = new clsJobPersionMasterMember();

                    #region JobPersion
                    if (ds.Tables.Count > 0)
                    {
                        foreach (DataRow r in ds.Tables[0].Rows)
                        {
                            objJobPersion.JobPersionDetai = (r["JobPersionDetai"] ?? "").ToString();
                            objList.Add(objJobPersion);
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

        public DataSet GetAllJobPersion()
        {
            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[] 
                                {
                                    new SqlParameter("@JobPersionID"	 ,   JobPersionID   ),
                                    new SqlParameter("@UserID"       ,   UserID       ),
                                    new SqlParameter("@CompanyID"	 ,   CompanyID    ),
                                    new SqlParameter("@Action"       ,   Mode         ) 
                                };

                DataSet ds = objSql.ExecuteDataSet("JobPersionMasterGet", objParams);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet GetSearchJobPersion()
        {
            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[] 
                                {
                                    new SqlParameter("@JobPersionName"	     ,   JobPersionName		   ),
                                    new SqlParameter("@JobPersionContactNo"	 ,   JobPersionContactNo     ),
                                    new SqlParameter("@JobPersionAddress"	     ,   JobPersionAddress       ),

                                    new SqlParameter("@UserID"               ,   UserID                ),
                                    new SqlParameter("@CompanyID"	         ,   CompanyID             ),
                                    new SqlParameter("@Action"               ,   Mode                  ) 
                                };

                DataSet ds = objSql.ExecuteDataSet("JobPersionMasterSearch", objParams);
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
                if (JobPersionName.Length.Equals(0))
                {
                    msg = "Please Enter the JobPersion Name";
                }
                if (JobPersionAddress.Length.Equals(0))
                {
                    msg = msg.Length > 0 ? msg + "\nPlease Enter the JobPersion Address" : msg + "Please Enter the JobPersion Address";
                }
                //if (JobPersionCSTDate.Length.Equals(0))
                //{
                //    msg = msg.Length > 0 ? msg + "\nPlease Enter the JobPersion CST Date" : msg + "Please Enter the JobPersion CST Date";
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
