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
    class LoginModel
    {
        private string strEmp, strUsername, strPassword = null;
        private int iIsEmp = 2;
        private Providers providers = new Providers();
        public LoginModel(string Emp, string Username, string Password, int isEmp)
        {
            this.strEmp = Emp;
            this.strUsername = this.strEmp == null ? Username : Emp;
            this.strPassword = Password;
            this.iIsEmp = Emp == null ? 1 : 2;   
        }
        public LoginModel()
        {
            this.strEmp = "";
            this.strUsername = "";
            this.strPassword = "";
            this.iIsEmp = 2;
        }

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
                    query.Parameters.AddWithValue("@Username", strUsername);
                    query.Parameters.AddWithValue("@Password", strPassword);
                    query.Parameters.AddWithValue("@IsEmp", iIsEmp);

                    query.Parameters.Add("@IsValid", SqlDbType.Int);
                    query.Parameters["@IsValid"].Direction = ParameterDirection.Output;
                    query.ExecuteNonQuery();
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
