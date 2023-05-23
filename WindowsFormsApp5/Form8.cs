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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("24 saat açık spor salonu ve sezonluk açık havuz dâhil dinlenme olanaklarından mutlaka yararlanın. Bu otelde ayrıca ücretsiz kablosuz İnternet, danışma (concierge) hizmetleri ve ortak alanda televizyon sunulmaktadır.Türk mutfağı alanında uzman olan Mikla Restaurant yemek servisi için ideal, bu otelde toplam 2 restoran var; isterseniz 24 saat oda servisi imkanı da mevcut. Barda/oturma salonunda ve havuz kenarı barında misafirlere içecek servisi yapılmaktadır. Misafirlere her gün 6.30 ve 10.30 arasında ücretli açık büfe kahvaltı servisi yapılmaktadır.Misafirler için ofis, lobide ücretsiz gazete servisi ve kuru temizleme/çamaşır yıkama servisi mevcuttur. Misafirler için gidiş-dönüş havaalanı transfer servisi 24 saat ücretli olarak hizmet vermektedir, ayrıca otelde (ücretli) otopark vardır.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rezervasyonunuz başarıyla tamamlanmıştır...");
        }

        private void label22_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
            this.Hide();
        }
    }
}
