using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bus_Ticket_Reservation;
using Bus_Ticket_Reservation.Model;

namespace Bus_Ticket_Reservation.Model
{
    class KisiDB
    {




        public int KisiEkle(Kisi kisi)
        {
            try
            {
                if (KisiExists(kisi.getKisiID()))
                {
                    throw new Exception("Course with same name exists");
                }
               

               string query = $"INSERT INTO Kisi(ad, soyad,  tc, cinsiyet, telNo,  mail,  sifre, dogumTarihi)  " +
                    $"VALUES('{kisi.getAd()}','{kisi.getSoyad()}'," +
                    $"'{kisi.getTc()}','{kisi.getCinsiyet()}','{kisi.getTelefonNo()}','{kisi.getMail()}','{kisi.getSifre()}','{kisi.getDogumTarihi()}')";
                int a1 = DbHelper.ExecuteNonQuery(query);
                return a1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private bool KisiExists(int kisiID)
        {
            try
            {
                List<Kisi> list = new List<Kisi>();
                string query = $"select * from Kisi where kisiID='{kisiID}'";
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

        public int getKisiIDforTC(long tc)
        {
            try
            {
                List<Kisi> list = new List<Kisi>();
                string query = $"select KisiID from Kisi where TC='{tc}'";
                var dt = DbHelper.ExecuteQuery(query);
                if (dt.Rows.Count > 0)
                {
                    int a1;
                    a1= int.Parse(dt.Rows[0]["KisiID"].ToString());
                    return a1;
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
        public int KisiUpdate(Kisi kisi)
        {
            try
            {
                string query = $"UPDATE Kisi SET " +
                    $"ad='{kisi.getAd()} ' ," +
                    $"cinsiyet='{kisi.getCinsiyet()} ', " +
                    $"dogumTarihi='{kisi.getDogumTarihi()} ', " +
                    $"mail='{kisi.getMail()} ', " +
                    $"sifre='{kisi.getSifre()} ', " +
                    $"soyad='{kisi.getSoyad()} ' ," +
                    $"tc='{kisi.getTc()} ' ," +
                    $"telNo='{kisi.getTelefonNo()} ' " +
                    $"WHERE kisiID={kisi.getKisiID()}";
                return DbHelper.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int KisiDelete(int kisiID)
        {
            try
            {
                string query = $"Delete from Kisi where kisiID='{kisiID}'";
                return DbHelper.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Kisi> GetKisi()
        {
            try
            {
                List<Kisi> list = new List<Kisi>();
                string query = $"SELECT  * from kisi b";
                var dt = DbHelper.ExecuteQuery(query);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Kisi kisi = new Kisi();
                    kisi.setKisiID(int.Parse(dt.Rows[i]["kisiID"].ToString()));
                    // personel.ad = dt.Rows[i]["ad"].ToString();
                    //personel.soyad = dt.Rows[i]["soyad"].ToString();

                    list.Add(kisi);
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
