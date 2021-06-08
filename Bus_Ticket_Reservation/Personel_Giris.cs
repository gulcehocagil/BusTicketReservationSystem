using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bus_Ticket_Reservation.Model;

namespace Bus_Ticket_Reservation
{
    public partial class Personel_Giris : Form
    {
        public Personel_Giris()
        {
            InitializeComponent();
        }

        private void Personel_Giris_Load(object sender, EventArgs e)
        {
            tbPersonelMail.Text = "gulce.hocagil@bilet.com";
            tbPersonelSifre.Text = "1234";

        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                lblMessage.Text = "";
                lblMessage.ForeColor = Color.Black;

                string mail = tbPersonelMail.Text.Trim();
                string sifre = tbPersonelSifre.Text.Trim();
                
                if (string.IsNullOrEmpty(mail))
                {
                    lblMessage.Text = "Mailinizi Giriniz.";
                    tbPersonelMail.Focus();
                    lblMessage.ForeColor = Color.Red;
                    return;

                }
                if (string.IsNullOrEmpty(sifre))
                {
                    lblMessage.Text = "Şifrenizi Giriniz.";
                    tbPersonelSifre.Focus();
                    lblMessage.ForeColor = Color.Red;
                    return;
                }
                PersonelDB personel = new PersonelDB();
                string result = personel.Giris( mail , sifre); 
                if (result == "Yonetim")
                {
                    PersonelAnaSayfa personelhome = new PersonelAnaSayfa();
                    personelhome.WindowState = FormWindowState.Maximized;
                    this.Hide();
                    personelhome.ShowDialog();
                }else if(result == "Yolcu")
                    {
                    PersonelAnaSayfa personelhome = new PersonelAnaSayfa();
                    personelhome.WindowState = FormWindowState.Maximized;
                    this.Hide();
                    personelhome.ShowDialog();
                }
                else {
                    PersonelAnaSayfa personelhome = new PersonelAnaSayfa();
                    personelhome.WindowState = FormWindowState.Maximized;
                    this.Hide();
                    personelhome.ShowDialog();
                }
                
            }
            catch (Exception ex)
            {

                lblMessage.Text = ex.Message;
                lblMessage.ForeColor = Color.Red;
            }
        }
    }
}
