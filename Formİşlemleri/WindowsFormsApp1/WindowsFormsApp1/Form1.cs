using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void kodolustur()
        {
            Random rastgele = new Random();  // Random sınıfından rastgele nesnesi oluştu 
            int sayi = rastgele.Next(10000,100000);        // rasgele'den random sayı geldi.
            Txtkod2.Text = sayi.ToString();               // textBox2 'ye sayi değişkeninden gelen değer atandı
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            kodolustur();     //kodolustur metodu çağrıldı.
            timer1.Start();   //Tımer1'i başlat.
        }
        
        private void Txtbutton_Click(object sender, EventArgs e)
        {
            if(Txtad.Text == "admin" && Txtsifre.Text =="1234" && Txtkod1.Text== Txtkod2.Text)
            {
                Form2 frm = new Form2();
                frm.kullanici = Txtad.Text; // form2 ye kullanici adını gönderdik
                
                frm.Show();
                this.Hide();
                Form3 frm3 = new Form3();
                frm3.sifre = Txtsifre.Text;
                frm3.Show();
            }
            else
            {
                MessageBox.Show("Hatalı bilgi girişi: Kullanıcı adı ,şifre veya kod yanlış girildi! ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
         }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 frm = new Form3();    
            frm.Show();
        }

        int sayac=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if(sayac %2 == 0)
            {
                label3.BackColor = Color.YellowGreen;
            }
            else
            {
                label3.BackColor = Color.OrangeRed;
            }
            if(sayac == 10)
            {
                sayac = 0
;            }

        }
    }
}
