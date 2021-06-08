using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Ticket_Reservation.Model
{
    class Departman
    {
        int departmanID;
        string departmanAd;

        public Departman(int departmanID, string departmanAd)
        {
            this.departmanID = departmanID;
            this.departmanAd = departmanAd;
        }

        public Departman()
        {

        }

        public static int GetAllDepartmentCount()
        {
            try
            {
                string query = $"select COUNT(DepartmentID) Departs from Department";
                return int.Parse(DbHelper.ExecuteQuery(query).Rows[0][0].ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int getDepartmanID()
        {
            return departmanID;
        }
        public void setDepartmanID(int departmanID)
        {
            this.departmanID = departmanID;
        }

        public string getDepartmanAd()
        {
            return departmanAd;
        }
        public void setDepartmanAd(string departmanAd)
        {
            this.departmanAd = departmanAd;
        }

        public DataTable GetAllDeparments()
        {
            try
            {
                string query = $"select * from Department";
                return DbHelper.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception("Log In Error: " + ex.Message);
            }
        }
    }
}
