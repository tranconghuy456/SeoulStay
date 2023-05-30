using Module_1_Rebuilt.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Module_1_Rebuilt.Context;
using System.Windows.Forms;

namespace Module_1_Rebuilt.BLL
{
    class LoginRegister
    {
        Providers providers = new Providers();

        public DataTable LoginCheckPoint()
        {
            try
            {
                string[] parameters =
                {
                    "@Username",
                    "@Password",
                    "@UserTypeID"
                };
                object[] values =
                {
                    UserContext.Instance.Username,
                    UserContext.Instance.Password,
                    UserContext.Instance.UserTypeID
                };

                if (providers.Connect())
                {
                    SqlCommand query = providers.Command("[dbo].[Usp_LoginCheckPoint]", parameters, values, true);
                    DataTable result = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = query;
                    adapter.Fill(result);
                    return result;
                }
            } catch (Exception ex)
            {
                throw;
            }
            return null;
        }
    }
}
