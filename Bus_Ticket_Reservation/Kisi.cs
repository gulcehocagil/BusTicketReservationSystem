using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Ticket_Reservation.Model
{
   class Kisi
    {


        public int kisiID;
        public string ad;
        public string soyad;
        public long tc;
        public string cinsiyet;
        public long telefonNo;
        public string mail;
        public string sifre;
        private DateTime dogumTarihi;

        

        public Kisi(int kisiID, string ad, string soyad, int tc, string cinsiyet, int telefonNo, string mail, string sifre, DateTime dogumTarihi)
        {
            this.kisiID = kisiID;
            this.ad = ad;
            this.soyad = soyad;
            this.tc = tc;
            this.cinsiyet = cinsiyet;
            this.telefonNo = telefonNo;
            this.mail = mail;
            this.sifre = sifre;
            this.dogumTarihi = dogumTarihi;
        }

        public Kisi()
        {
            
        }
        public int getKisiID()
        {
            return kisiID;
        }
        public void setKisiID(int kisiID)
        {
            this.kisiID = kisiID;
        }
        public string getAd()
        {
            return ad;
        }
        public void setAd(string ad)
        {
            this.ad = ad;
        }
        public string getSoyad()
        {
            return soyad;
        }
        public void setSoyad(string soyad)
        {
            this.soyad =  soyad;
        }
        public long getTc()
        {
            return tc;
        }
        public void setTc(long tc)
        {
            this.tc = tc;
        }
        public string getCinsiyet()
        {
            return cinsiyet;
        }
        public void setCinsiyet(string cinsiyet)
        {
            this.cinsiyet = cinsiyet;
        }
        public long getTelefonNo()
        {
            return telefonNo;
        }
        public void setTelefonNo(long telefonNo)
        {
            this.telefonNo = telefonNo;
        }
        public string getMail()
        {
            return mail;
        }
        public void setMail(string mail)
        {
            this.mail = mail;
        }
        public int getSifre()
        {
            return kisiID;
        }
        public void setSifre(int kisiID)
        {
            this.kisiID = kisiID;
        }
        public DateTime getDogumTarihi()
        {
            return dogumTarihi;
        }
        public void setDogumTarihi(DateTime dogumTarihi)
        {
            this.dogumTarihi = dogumTarihi;
        }




    }
}
