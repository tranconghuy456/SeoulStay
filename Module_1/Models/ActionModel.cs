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
    class ActionModel
    {
        Providers providers = new Providers();

        public DataTable ServiceTypesFill()
        {
            try {
                providers.Connect();
                SqlCommand query = new SqlCommand("SELECT -1 AS ID, '-- Select Service Type --' AS Name UNION ALL SELECT ID, Name FROM [Session_1].[dbo].[ItemTypes]", providers.connection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = query;
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            } catch (Exception ex)
            {
                throw;
            } finally
            {
                providers.Disconnect();
            }
        }
    }
}
