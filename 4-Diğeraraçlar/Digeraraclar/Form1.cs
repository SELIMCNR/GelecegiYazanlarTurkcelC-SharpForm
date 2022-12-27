using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digeraraclar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*Menu strip kullanımı*/
        private void yazdırmaKomutlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Yazdırma komutları alanına tıklandı";
             
        }

        /*Menü arka plan renk değişiklikleri*/
        private void sarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;

        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void pembeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;
        }

        private void turuncuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void googleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com.tr/");
        }

        /*Web browser aracı kullanımı*/
        private void fenerbahçeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.fenerbahce.org/");
        }

        private void btkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.btkakademi.gov.tr/portal");
        }


        private void turkcellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://gelecegiyazanlar.turkcell.com.tr/");
        }

        /*Contextmenu strıp aracı kullanımı sol fare tuşuna basınca */
        private void hakkımızdaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu uygulamayı Turkcell geleceği yazanlar platformu dersleri altında gerçekleşirmekteyiz.");

        }
        /* Timer aracı kullanımı*/
        int sayac = 0;
        private void başlatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start(); // TİMER 1 ÇALIŞIR


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label3.Text = sayac.ToString();  // LABELA TİMER1 DEN GELEN DEĞER EKLENİR
        }

        /*Trafik lambası Uygulaması*/
        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Start(); // TİMER2 BAŞLADI

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Stop(); // Timer2 durdu
        }

        int sure = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Text = sure.ToString();
            sure++;
            if( sure>=0 && sure <= 30)
            {
                panel1.BackColor = Color.Red;
                panel3.BackColor = Color.Transparent;
            }

            if(sure > 30 && sure <= 40)
            {
                panel2.BackColor = Color.Yellow;
            }
            if(sure > 40 && sure <= 70) 
            {
                panel3.BackColor = Color.Green;
                panel1.BackColor = Color.Transparent;
                panel2.BackColor = Color.Transparent;
            }


            if(sure == 71)
            {
                sure = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
        

}
