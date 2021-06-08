using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Ticket_Reservation.Model
{
    class DepartmanDB
    {
        public int DepartmanEkle(Departman departman)
        {
            try
            {
                if (DepartmanExists(departman.getDepartmanID()))
                {
                    throw new Exception("Course with same name exists");
                }

                string query = $"INSERT INTO Departman(departmanID,departmanAd)VALUES('{departman.getDepartmanID()}',{departman.getDepartmanAd()})";
                return DbHelper.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private bool DepartmanExists(int departmanID)
        {
            try
            {
                List<Departman> list = new List<Departman>();
                string query = $"select * from Departman where departmanID='{departmanID}'";
                var dt = DbHelper.ExecuteQuery(query);
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("GetAllDeparments Error: " + ex.Message);
            }
        }
    }
}
