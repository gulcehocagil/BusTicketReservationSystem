using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Ticket_Reservation.Model
{
    class Personel: Kisi
    {


        private int personelID;
        private int departmanID;
        
        
        public Personel(int personelID, int departmanID, int kisiID)
        {
            this.personelID = personelID;
            this.departmanID = departmanID;
            this.kisiID = kisiID;
            
        }

        public Personel()
        {
               

        }




        public int getPersonelID()
        {
            return personelID;
        }
        public void setPersonelID(int personelID)
        {
            this.personelID = personelID;
        }


        public int getDepartmanID()
        {
            return departmanID;
        }
        public void setDepartmanlID(int departmanID)
        {
            this.departmanID = departmanID;
        }



    }
}
