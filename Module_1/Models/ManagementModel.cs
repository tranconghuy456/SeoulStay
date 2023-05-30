using Module_1.Context;
using Module_1.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1.Models
{
    class ManagementModel
    {
        // Init Providers //
        Providers providers = new Providers();

        // Connection Method //
        public SqlConnection Connection()
        {
            return providers.connection;
        }

        // Connect method //
        public bool Connect()
        {
            return providers.Connect();
        }

        // Disconnect method //
        public void Disconnect()
        {
            providers.Disconnect();
        }

        public DataTable GetUserData(int UID)
        {
            try
            {
                if (Connect())
                {
                    DataTable table = new DataTable();
                    SqlCommand query = new SqlCommand("Usp_GetUserData", Connection());
                    SqlDataAdapter adapter = new SqlDataAdapter();

                    query.CommandType = CommandType.StoredProcedure;
                    query.Parameters.AddWithValue("@UID", UID);
                    query.ExecuteNonQuery();
                    adapter.SelectCommand = query;
                    adapter.Fill(table);
                    Disconnect();
                    return table;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return null;
        }

        public DataTable GetTravellerData()
        {
            try
            {
                if (Connect())
                {
                    DataTable table = new DataTable();
                    SqlCommand query = new SqlCommand("Usp_GetTravellerData", providers.connection);
                    SqlDataAdapter adapter = new SqlDataAdapter();

                    query.CommandType = CommandType.StoredProcedure;
                    query.Parameters.AddWithValue("@UID", UserContext.UID);
                    query.ExecuteNonQuery();
                    adapter.SelectCommand = query;
                    adapter.Fill(table);
                    providers.Disconnect();
                    return table;
                }
            } catch (Exception ex)
            {
                throw;
            }
            return null;
        }

        public DataTable GetEmpData()
        {
            try
            {
                if (Connect())
                {
                    DataTable table = new DataTable();
                    SqlCommand query = new SqlCommand("Usp_GetEmpData", providers.connection);
                    SqlDataAdapter adapter = new SqlDataAdapter();

                    query.CommandType = CommandType.StoredProcedure;
                    query.Parameters.AddWithValue("@UID", UserContext.UID);
                    query.ExecuteNonQuery();
                    adapter.SelectCommand = query;
                    adapter.Fill(table);
                    providers.Disconnect();
                    return table;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return null;
        }
    }
}