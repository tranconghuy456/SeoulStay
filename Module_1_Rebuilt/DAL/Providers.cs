using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Module_1_Rebuilt.Context;

namespace Module_1_Rebuilt.DAL
{
    public class Providers
    {
        // VARIABLES //
        public SqlConnection Connection;
        public string connectionStr = ConfigurationManager.ConnectionStrings["Session1_Rebuilt"].ConnectionString.ToString();

        public bool Connect()
        {
            try
            {
                Connection = new SqlConnection(connectionStr);
                if (Connection.State == ConnectionState.Broken || Connection.State == ConnectionState.Closed)
                {
                    Connection.Open();
                    return true;
                }
                    return false;
            } catch (Exception ex)
            {
                throw;
            }
        }

        public void Disconnect()
        {
            Connection.Dispose();
            Connection.Close();
        }
        // Command method using SqlCommand //
        // - In: queryOrSpName, Parameters, Values, isStored
        // - Out: return command result
        public SqlCommand Command(string queryOrSpName, string[] Parameters, object[] Values, bool isStored)
        {
            try
            {
                SqlCommand query = new SqlCommand(queryOrSpName, Connection);
                if (isStored)
                {
                    query.CommandText = queryOrSpName;
                    query.CommandType = CommandType.StoredProcedure;
                    query.Connection = Connection;
                }

                if (Parameters != null)
                    for (int i = 0; i < Parameters.Length; i++)
                        query.Parameters.AddWithValue(Parameters[i], Values[i]);
                return query;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}