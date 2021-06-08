using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace Bus_Ticket_Reservation.Model
{
    class DbHelper
    {
        

        public static DataTable ExecuteQuery(string query)
        {
            

            try
            {
                string connectionString = "Server=DESKTOP-1F73HS3;Database=OBS;Trusted_Connection=True;";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                if (sqlConnection.State == ConnectionState.Open)
                {
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                    adapter.Fill(dt);

                    return dt;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("GetAllDeparments Error: " + ex.Message);
            }
        }

        // INSERT, UPDATE, DELETE
        public static int ExecuteNonQuery(string query)
        {
            try
            {
                string connectionString = "Server=DESKTOP-1F73HS3;Database=OBS;Trusted_Connection=True;";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                

                if (sqlConnection.State == ConnectionState.Open)
                {
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    return sqlCommand.ExecuteNonQuery();

                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("GetAllDeparments Error: " + ex.Message);
            }
        }
    }
}
