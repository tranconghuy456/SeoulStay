using Module_1_Rebuilt.Context;
using Module_1_Rebuilt.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1_Rebuilt.BLL
{
    internal class ManagementModel
    {
        Providers providers = new Providers();

        public DataTable LoadUserData(int opt)
        {
            string sp = opt == 2 ? "[dbo].[Usp_LoadTravelerData]" : "[dbo].[Usp_LoadEmployeeData]";

            try
            {
                string[] parameters =
                {
                    "@UID",
                };
                object[] values =
                {
                    UserContext.Instance.UID,
                };

                if (providers.Connect())
                {
                    SqlCommand query = providers.Command(sp, parameters, values, true);
                    DataTable result = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = query;
                    adapter.Fill(result);
                    return result;
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
