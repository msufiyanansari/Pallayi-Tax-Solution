using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SenseInventoryLogoDA;
namespace SenseInventoryLogoBL
{
    public class clsCategoryMasterMember
    {
    public int          CategoryMasterCatKey           {get;set;}
    public String       CategoryMasterCatName          {get;set;}
    public String       CategoryMasterCatVal           {get;set;}
    public int          CategoryMasterCatIsActive      {get;set;}
    public int          CompanyID                      {get;set;}
    public String       Mode                           {get;set;}
    public int          UserID                         {get;set;}
    public String       CategoryMasterCatIsActiveValue {get;set;}
    public String       CategoryMasterHsnCode          {get;set;}
    public String       TestingVariable                {get;set;}
    }
    public class clsCategoryMaster:clsCategoryMasterMember
    {
        public int AddUpdateDelete()
        {
            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.CRUDConnString);
                SqlParameter[] objParam = new SqlParameter[]
                {
                    new SqlParameter("@CategoryMasterCatKey"            ,   CategoryMasterCatKey         ),
                    new SqlParameter("@CategoryMasterCatName"           ,   CategoryMasterCatName        ),
                    new SqlParameter("@CategoryMasterCatVal"            ,   CategoryMasterCatVal         ),
                    new SqlParameter("@CategoryMasterCatIsActive"       ,   CategoryMasterCatIsActive    ),
                    new SqlParameter("@CategoryMasterHsnCode"           ,   CategoryMasterHsnCode        ),


                    new SqlParameter("@CompanyID"                       ,   CompanyID                    ),
                    new SqlParameter("@UserID"		                    ,   UserID	                     ), 
                    new SqlParameter("@Action"                          ,	Mode	                     )
                };

                int result = objSql.ExecuteNonQuery("CategoryMasterSave", objParam);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<clsCategoryMasterMember> GetCategory()
        {
            List<clsCategoryMasterMember> objList = new List<clsCategoryMasterMember>();

            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[] 
                        {
                            new SqlParameter("@CategoryMasterCatKey"	 ,   CategoryMasterCatKey  ),
                            new SqlParameter("@CategoryMasterCatName"	 ,   CategoryMasterCatName ),

                            new SqlParameter("@UserID"                   ,   UserID                ),
                            new SqlParameter("@CompanyID"	             ,   CompanyID             ),
                            new SqlParameter("@Action"                   ,   Mode                  ) 
                        };

                DataSet ds = objSql.ExecuteDataSet("CategoryMasterGet", objParams);

                if (ds != null)
                {
                    clsCategoryMasterMember objCategory = new clsCategoryMasterMember();

                    #region Category
                    if (ds.Tables.Count > 0)
                    {
                        foreach (DataRow r in ds.Tables[0].Rows)
                        {
                            objCategory.CategoryMasterCatKey            = Convert.ToInt32(r["CategoryMasterCatKey"] ?? -1);
                            objCategory.CategoryMasterCatName           = (r["CategoryMasterCatName"] ?? "").ToString();
                            objCategory.CategoryMasterCatVal            = (r["CategoryMasterCatVal"] ?? "").ToString();
                            objCategory.CategoryMasterCatIsActive       = Convert.ToInt32(r["CategoryMasterCatIsActive"] ?? -1);
                            objCategory.CategoryMasterCatIsActiveValue  = (r["CategoryMasterCatIsActiveValue"] ?? "").ToString();
                            objCategory.CategoryMasterHsnCode           = (r["CategoryMasterHsnCode"] ?? "").ToString();
                            objList.Add(objCategory);
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

        public DataSet GetAllCategory()
        {
            try
            {
                clsSqlHelper objSql = new clsSqlHelper(clsHelper.DBCONNTYPE.GetConnString);
                SqlParameter[] objParams = new SqlParameter[] 
                        {
                            new SqlParameter("@CategoryMasterCatKey"	 ,   CategoryMasterCatKey  ),
                            new SqlParameter("@CategoryMasterCatName"	 ,   CategoryMasterCatName ),
                                                                        
                            new SqlParameter("@UserID"                   ,   UserID                ),
                            new SqlParameter("@CompanyID"	             ,   CompanyID             ),
                            new SqlParameter("@Action"                   ,   Mode                  ) 
                        };
                DataSet ds = objSql.ExecuteDataSet("CategoryMasterGet", objParams);
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
                if (CategoryMasterCatName.Equals("Please Select Category"))
                {
                    msg = "Please Select the Category Group";
                }
                if (CategoryMasterCatVal.Length.Equals(0))
                {
                    msg = msg.Length > 0 ? msg + "\n Please Enter the Category Value" : msg + "Please Enter the Category Value";
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










