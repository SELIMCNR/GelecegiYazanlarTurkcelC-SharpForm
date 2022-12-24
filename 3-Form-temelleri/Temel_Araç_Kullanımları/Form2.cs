using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temel_Araç_Kullanımları
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Btn_Hesapla_Click(object sender, EventArgs e)
        {
            /*Ortalam hesaplama*/
            int s1, s2, s3, ort;
            string durum;
            s1 = Convert.ToInt16(TextSinav1.Text);
            s2 = Convert.ToInt16(TextSinav2.Text);
            s3 = Convert.ToInt16(TextSinav3.Text);

            ort = (s1 + s2 + s3) / 2;
            TextOrtalama.Text = ort.ToString();

            /*Durum hesapla*/
            if (ort >= 50)
            {
                durum = "Geçti";
            }
            else
            {
                durum = "Kaldı";
            }
            TextDurum.Text = durum;



        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            if(TextDurum.Text != "" &&  TextOrtalama.Text!="")
            {
                String adsoyad, ders, numara;
                adsoyad = TextAdSoyad.Text;
                ders = comboBox1.Text;
                numara = maskedTextBox1.Text;
                listBox1.Items.Add(adsoyad + " " + ders + "Numara:  " + numara + "Ortalama:  " + TextOrtalama.Text + "Durum:  " + TextDurum.Text);
                sayac++;
                label10.Text = "Kaydedilen öğrenci sayısı "+sayac;
            }
            else
            {
                MessageBox.Show("Lütfen ortalma ve durum hesabı yapınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void Btn_Cizgi_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("-------------");
        }

        int sayac;
        private void button1_Click(object sender, EventArgs e)
        {
            sayac = 0;
            sayac++;
            label10.Text = sayac.ToString();
        }

        private void Btn_Temizle_Click(object sender, EventArgs e)
        {
            TextAdSoyad.Text = "";
            TextDurum.Clear();
            TextOrtalama.Text = "";
            TextSinav1.Text = "";
            TextSinav2.Text = "";
            TextSinav3.Text = "";
            maskedTextBox1.Text = "";
           // comboBox1.Text = "";
            comboBox1.SelectedIndex = -1;

            TextAdSoyad.Focus(); /*Ad soyad alanına odakla*/
            MessageBox.Show("Mesaj","Başlık",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba öğrenciler dersler devam ediyor", "Mesaj kutusu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i <=10; i++)
            {
                listBox2.Items.Add(i+"Merhaba");
            }
        }

        private void BtnForDöngüsü2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <=20; i++)
            {
                if(i%3 == 0)
                {
                    listBox2.Items.Add(i);
                }
            }
        }

        private void BtnListTemizle_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

        }

        private void BtnWhile_Click(object sender, EventArgs e)
        {
            int x = 0;
            while(x <= 10)
            {
                listBox2.Items.Add(x + "-While döngüsü");
                x++;
            }
        }

        private void BtnDizi1_Click(object sender, EventArgs e)
        {
            string[] sehirler = { "a1", "a2", "a3", "a" };
            TextAdSoyad.Text = sehirler[4];
        }

        private void BtnDizi2_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 34, 65, 87, 98, 104, 315, 24 };
            for (int i = 0; i < sayilar.Length; i++)
            {
                listBox2.Items.Add(sayilar[i]);
            }

            foreach (var k in sayilar)
            {
                if(k % 2 == 0)
                {
                    listBox2.Items.Add(k);
                }
            }
        }
    }
}
