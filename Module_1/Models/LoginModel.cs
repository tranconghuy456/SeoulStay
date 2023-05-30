using Module_1.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_1.Context;

namespace Module_1.Models
{
    class LoginModel
    {
        private Providers providers = new Providers();

        // Connection Method //
        // return connection string //
        public SqlConnection Connection()
        {
            return providers.connection;
        }

        // Connect method //
        // return connection state //
        public bool Connect()
        {
            return providers.Connect();
        }

        // Disconnect method //
        public void Disconnect()
        {
            providers.Disconnect();
        }

        // Checkpoint method //
        // In: username, password
        // Out: 0 -> invalid; 1 -> user; 2 -> admin
        public int LoginCheckPoint()
        {
            try
            {
                if (Connect()) { 
                    SqlCommand query = new SqlCommand("Usp_LoginCheckPoint", Connection());

                    query.CommandType = CommandType.StoredProcedure;
                    query.Parameters.AddWithValue("@Username", UserContext.Username);
                    query.Parameters.AddWithValue("@Password", UserContext.Password);
                    query.Parameters.AddWithValue("@Role", UserContext.isEmp);

                    query.Parameters.Add("@IsValid", SqlDbType.Int);
                    query.Parameters.Add("@UID", SqlDbType.Int);
                    query.Parameters["@IsValid"].Direction = ParameterDirection.Output;
                    query.Parameters["@UID"].Direction = ParameterDirection.Output;
                    query.ExecuteNonQuery();
                    UserContext.UID = (int)query.Parameters["@UID"].Value;
                    
                    return (int)query.Parameters["@IsValid"].Value;
                }
            } catch(Exception ex)
            {
                throw;
            } finally
            {
                Disconnect();
            }
            return -1;
        }

    }
}
