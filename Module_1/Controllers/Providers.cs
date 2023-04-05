using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module_1.Controllers
{
    class Providers
    {
        // VARIABLES //
        public SqlConnection connection;
        private SqlCommand command;
        private string connectionStr;

        //*** Connect Method ***//
        // - Get connection string from app.config
        // - return true if connection is opened
        // - else .. false
        public bool Connect()
        {
            connectionStr = ConfigurationManager.ConnectionStrings["connectionStr"].ConnectionString.ToString();
            try
            {
                connection = new SqlConnection(connectionStr);
                if (connection.State == ConnectionState.Broken || connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    return true;
                }
            } catch(Exception ex)
            {
                throw;
            }
            return false;
        }

        // Disconnect method //
        public void Disconnect()
        {
            try
            {
                connection.Close();
                connection.Dispose();
            } catch(Exception ex)
            {
                throw;
            }
        }

        // Command method using SqlCommand //
        // - In: queryOrSpName, Parameters, Values, isStored
        // - Out: return command result
        public SqlCommand Command(string queryOrSpName, string[] Parameters, object[] Values, bool isStored)
        {
            try
            {
                connection.Open();
                command = new SqlCommand(queryOrSpName, connection);
                if (isStored)
                {
                    command.CommandText = queryOrSpName;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;
                }
                
                if (Parameters != null)
                {
                    for (int i = 0; i < Parameters.Length; i++)
                        command.Parameters.AddWithValue(Parameters[i], Values[i]);
                }
                return command;
            } catch(Exception ex)
            {
                throw;
            }
            finally
            {
                Disconnect();
            }
        }

        // ExecuteNonQuery method //
        // - In: queryOrSpName, Parameters, Values, isStored
        // - Out: return record result
        public int ExecuteNonQuery(string queryOrSpName, string[] Parameters, object[] Values, bool isStored)
        {
           try { 
                int rec = Command(queryOrSpName, Parameters, Values, isStored).ExecuteNonQuery();
                return rec;
            } catch(Exception ex)
            {
                throw;
            } finally
            {
                Disconnect();
            }
        }
    }
}
