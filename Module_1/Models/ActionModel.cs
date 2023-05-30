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
        public DataTable GetAmenitiesData()
        {
            try
            {
                providers.Connect();
                SqlCommand query = new SqlCommand("SELECT Name FROM [dbo].[Amenities] AS Amenity", providers.connection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = query;
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                providers.Disconnect();
            }
        }

        public DataTable GetAttractionData()
        {
            try
            {
                providers.Connect();
                SqlCommand query = new SqlCommand("SELECT A.Name AS 'Attraction', AR.Name AS 'Area', IA.Distance AS 'Distance (km)', IA.DurationOnFoot AS 'On Foot (minutes)', IA.DurationByCar AS 'By Car (minutes)' FROM ItemAttractions IA JOIN Attractions AS A ON A.ID = IA.AttractionID LEFT JOIN Areas AS AR ON AR.ID = A.AreaID", providers.connection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = query;
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                providers.Disconnect();
            }
        }
    }
}
