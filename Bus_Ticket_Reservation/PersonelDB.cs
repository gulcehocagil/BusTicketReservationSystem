using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Ticket_Reservation.Model
{
    class PersonelDB
    {

        public String Giris(string mail, string sifre)
        {
            try
            {
                string query = $"select a.personelID,b.ad, b.soyad,b.mail,c.departmanAd from dbo.Personel a,kisi b, departman c where a.kisiID=b.kisiID and a.departmanID=c.departmanID  and b.mail = '{mail}' AND b.sifre = '{sifre}'	";
                var dt = DbHelper.ExecuteQuery(query);

                if (dt.Rows.Count > 0)
                {
                    Personel personel = new Personel();

                   String departmanAdi = dt.Rows[0]["departmanAd"].ToString();
                    return departmanAdi;
                    ;

                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Log In Error: " + ex.Message);
            }
        }

        public int PersonelEkle(Personel personel)
        {
            try
            {
                if (PersonelExists(personel.getPersonelID()))
                {
                    throw new Exception("Course with same name exists");
                }

                string query = $"INSERT INTO Personel(departmanID,kisiID) VALUES('{personel.getDepartmanID()}','{personel.getKisiID()}')";
                return DbHelper.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private bool PersonelExists(int personelID)
        {
            try
            {
                List<Personel> list = new List<Personel>();
                string query = $"select * from Personel where personelID='{personelID}'";
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
        public int PersonelUpdate(Personel personel)
        {
            try
            {
                string query = $"UPDATE Personel SET departmaID='{personel.getDepartmanID()}' WHERE personel_ID={personel.getPersonelID()}";
                return DbHelper.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int PersonelDelete(int personelID)
        {
            try
            {
                string query = $"Delete from Personel where personelID='{personelID}'";
                return DbHelper.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Personel> GetPersonel()
        {
            try
            {
                List<Personel> list = new List<Personel>();
                string query = $"SELECT a.Personel_ID,a.Departman_ID,b.Ad,b.Soyad from personel a,kisi b where a.Kisi_ID=b.Kisi_ID ";
                var dt = DbHelper.ExecuteQuery(query);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Personel personel = new Personel();
                    personel.setPersonelID( int.Parse(dt.Rows[i]["personelID"].ToString()));
                   // personel.ad = dt.Rows[i]["ad"].ToString();
                    //personel.soyad = dt.Rows[i]["soyad"].ToString();

                    list.Add(personel);
                }
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception("GetAllDeparments Error: " + ex.Message);
            }
        }
    }
}
