using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rezervasyonunuz başarıyla tamamlandı...");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Açılabilir pencere\r\nBalkon\r\nBuzdolabı\r\nDuş\r\nDüz ekran TV\r\nElektrik su ısıtıcısı\r\nKablo TV\r\nKahve Makinesi\r\nKlima\r\nMerkezi ısıtma\r\nMikrodalga Fırın\r\nOda Kasası\r\nSaç kurutma makinası\r\nTelefon\r\nTelevizyon\r\nUydu TV\r\nWi-Fi\r\nÇalışma Masası\r\nÜcretsiz WiFi (odada)\r\nÜtü Masası");
        }

        private void label22_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
