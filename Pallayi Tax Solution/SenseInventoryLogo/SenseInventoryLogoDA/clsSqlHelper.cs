using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;
using SenseInventoryLogoDA;

namespace SenseInventoryLogoDA
{
    public class clsSqlHelper
    {
        string dbConnectionKey = "";
        string strConnString = string.Empty;
        int i;

        public clsSqlHelper()
        {
            strConnString = ConfigurationManager.ConnectionStrings["GetConnString"].ToString();

        }

        public clsSqlHelper(clsHelper.DBCONNTYPE ConnString)
        {
            switch (ConnString)
            {
                case clsHelper.DBCONNTYPE.GetConnString:
                    strConnString = ConfigurationManager.ConnectionStrings["GetConnString"].ToString();
                    dbConnectionKey = ConnString.ToString();
                    break;
                case clsHelper.DBCONNTYPE.CRUDConnString:
                    strConnString = ConfigurationManager.ConnectionStrings["CRUDConnString"].ToString();
                    dbConnectionKey = ConnString.ToString();
                    break;
            };
        }


        public int ExecuteNonQuery(string pinQuery)
        {
            int retVal = 0;
            Database db = DatabaseFactory.CreateDatabase(dbConnectionKey);
            System.Data.Common.DbCommand dbCommand = null;

            if (pinQuery.StartsWith("insert") | pinQuery.StartsWith("INSERT") | pinQuery.StartsWith("update") | pinQuery.StartsWith("UPDATE") | pinQuery.StartsWith("delete") | pinQuery.StartsWith("DELETE"))
            {
                dbCommand = db.GetSqlStringCommand(pinQuery);
            }
            else
            {
                dbCommand = db.GetStoredProcCommand(pinQuery);
            }

            try
            {
                retVal = db.ExecuteNonQuery(dbCommand);
                return retVal;
            }
            catch (SqlException SqlEx)
            {
                throw SqlEx;
            }
        }


        public int ExecuteNonQuery(string pinQuery, params SqlParameter[] pinParams)
        {
            bool IsOutParams = false;
            int OutParamIndex;
            int retVal = 0;
            Database db = DatabaseFactory.CreateDatabase(dbConnectionKey);
            System.Data.Common.DbCommand dbCommand = null;

            if (pinQuery.StartsWith("insert") | pinQuery.StartsWith("INSERT") | pinQuery.StartsWith("update") | pinQuery.StartsWith("UPDATE") | pinQuery.StartsWith("delete") | pinQuery.StartsWith("DELETE"))
            {
                dbCommand = db.GetSqlStringCommand(pinQuery);
            }
            else
            {
                dbCommand = db.GetStoredProcCommand(pinQuery);
            }
            for (i = 0; i <= pinParams.Length - 1; i++)
            {
                if (pinParams[i].Direction == ParameterDirection.Input)
                {
                    db.AddInParameter(dbCommand, pinParams[i].ParameterName, pinParams[i].DbType, pinParams[i].Value);
                }
                else
                {
                   IsOutParams = true;
                   db.AddOutParameter(dbCommand,pinParams[i].ParameterName,pinParams[i].DbType,pinParams[i].Size);
                   retVal = Convert.ToInt32(pinParams[i].Value);
                }
            }
            try
            {
                if (IsOutParams == false)
                {
                    return retVal = db.ExecuteNonQuery(dbCommand);
                }
                else
                {
                  OutParamIndex =  db.ExecuteNonQuery(dbCommand);
                  retVal = Convert.ToInt32(db.GetParameterValue(dbCommand, pinParams[OutParamIndex].ToString()));
                  return retVal;
                }
            }
            catch (SqlException SqlEx)
            {
                throw SqlEx;
            }
        }

        public SqlDataReader ExecuteDataReader(string pinQuery)
        {
            Database db = DatabaseFactory.CreateDatabase(dbConnectionKey);
            System.Data.Common.DbCommand dbCommand = null;

            if (pinQuery.StartsWith("select") | pinQuery.StartsWith("SELECT"))
            {
                dbCommand = db.GetSqlStringCommand(pinQuery);
            }
            else
            {
                dbCommand = db.GetStoredProcCommand(pinQuery);
            }
            
            try
            {
                return (SqlDataReader)db.ExecuteReader(dbCommand);
            }
            catch (SqlException SqlEx)
            {
                throw SqlEx;
            }
        }

        public IDataReader ExecuteDataReader(string pinQuery, params SqlParameter[] pinParams)
        {
            Database db = DatabaseFactory.CreateDatabase(dbConnectionKey);
            System.Data.Common.DbCommand dbCommand = null;

            if (pinQuery.StartsWith("select") | pinQuery.StartsWith("SELECT"))
            {
                dbCommand = db.GetSqlStringCommand(pinQuery);
            }
            else
            {
                dbCommand = db.GetStoredProcCommand(pinQuery);
            }
            for (i = 0; i <= pinParams.Length - 1; i++)
            {
                if (pinParams[i].Direction == ParameterDirection.Input)
                {
                    db.AddInParameter(dbCommand, pinParams[i].ParameterName, pinParams[i].DbType, pinParams[i].Value);
                }
            }

            try
            {
                    return db.ExecuteReader(dbCommand);
            }
            catch (SqlException SqlEx)
            {
                throw SqlEx;
            }
        }

        public DataSet ExecuteDataSet(string pinQuery)
        {
            Database db = DatabaseFactory.CreateDatabase(dbConnectionKey);
            System.Data.Common.DbCommand dbCommand = null;

            if (pinQuery.StartsWith("select") | pinQuery.StartsWith("SELECT"))
            {
                dbCommand = db.GetSqlStringCommand(pinQuery);
            }
            else
            {
                dbCommand = db.GetStoredProcCommand(pinQuery);
            }
            
            try
            {
                return db.ExecuteDataSet(dbCommand);
            }
            catch (SqlException SqlEx)
            {
                throw SqlEx;
            }
        }

        public DataSet ExecuteDataSet(string pinQuery, params SqlParameter[] pinParams)
        {
            Database db = DatabaseFactory.CreateDatabase(dbConnectionKey);
            System.Data.Common.DbCommand dbCommand = null;

            if (pinQuery.StartsWith("select") | pinQuery.StartsWith("SELECT"))
            {
                dbCommand = db.GetSqlStringCommand(pinQuery);
            }
            else
            {
                dbCommand = db.GetStoredProcCommand(pinQuery);
            }
            for (i = 0; i <= pinParams.Length - 1; i++)
            {
                if (pinParams[i].Direction == ParameterDirection.Input)
                {
                    db.AddInParameter(dbCommand, pinParams[i].ParameterName, pinParams[i].DbType, pinParams[i].Value);
                }
            }

            try
            {
                return db.ExecuteDataSet(dbCommand);
            }
            catch (SqlException SqlEx)
            {
                throw SqlEx;
            }
        }

        public object ExecuteScalar(string pinQuery)
        {
            Database db = DatabaseFactory.CreateDatabase(dbConnectionKey);
            System.Data.Common.DbCommand dbCommand = null;

            if (pinQuery.StartsWith("select") | pinQuery.StartsWith("SELECT"))
            {
                dbCommand = db.GetSqlStringCommand(pinQuery);
            }
            else
            {
                dbCommand = db.GetStoredProcCommand(pinQuery);
            }

            try
            {
                return db.ExecuteScalar(dbCommand);
            }
            catch (SqlException SqlEx)
            {
                throw SqlEx;
            }
        }

        public object ExecuteScalar(string pinQuery, params SqlParameter[] pinParams)
        {
           
            Database db = DatabaseFactory.CreateDatabase(dbConnectionKey);
            System.Data.Common.DbCommand dbCommand = null;

            if (pinQuery.StartsWith("select") | pinQuery.StartsWith("SELECT"))
            {
                dbCommand = db.GetSqlStringCommand(pinQuery);
            }
            else
            {
                dbCommand = db.GetStoredProcCommand(pinQuery);
            }

            for (i = 0; i <= pinParams.Length - 1; i++)
            {
                if (pinParams[i].Direction == ParameterDirection.Input)
                {
                    db.AddInParameter(dbCommand, pinParams[i].ParameterName, pinParams[i].DbType, pinParams[i].Value);
                }
            }

            try
            {
                return db.ExecuteScalar(dbCommand);
            }
            catch (SqlException SqlEx)
            {
                throw SqlEx;
            }
        }
    }
}
