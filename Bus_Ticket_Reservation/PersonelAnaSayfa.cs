using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bus_Ticket_Reservation;
using Bus_Ticket_Reservation.Model;

namespace Bus_Ticket_Reservation
{
    public partial class PersonelAnaSayfa : Form
    {
        

        public PersonelAnaSayfa()
        {
            InitializeComponent();
        }

        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelIslem personelislem = new PersonelIslem();
            personelislem.WindowState = FormWindowState.Maximized;
            personelislem.ShowDialog();
            
        }

        private void btCikis_Click(object sender, EventArgs e)
        {
            try
            {
               var result =  MessageBox.Show("Çıkış yapmak istiyor musunuz?", "System message",MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void PersonelAnaSayfa_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    if (personel == null)
            //    {
            //        MessageBox.Show("Giriş yapınız.");
            //    }
            //    else
            //    {
            //        lblHosgeldin.Text = "Hoşgeldin, " + personel.ad;
            //    }
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }
    }
}
