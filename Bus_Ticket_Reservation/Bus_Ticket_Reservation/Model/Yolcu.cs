using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Ticket_Reservation.Model
{
    class Yolcu:kisi
    {
        int Yolcu_ID;
       

        public Yolcu(int yolcu_ID, string ad, string soyad, int tc, string cinsiyet, int telefon_No, 
            string mail, string sifre, DateTime dogum_Tarihi)
        {
            this.Yolcu_ID = yolcu_ID;
            this.Ad = ad;
            this.Soyad = soyad;
            this.Tc = tc;
            this.Cinsiyet = cinsiyet;
            this.Telefon_No = telefon_No;
            this.Mail = mail;
            this.Sifre = sifre;
            this.Dogum_Tarihi = dogum_Tarihi;
        }
    }
}
