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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            /*Charta veri eklemeleri */
            chart1.Series["Bolge"].Points.AddXY("Akdeniz", 15);
            chart1.Series["Bolge"].Points.AddXY("Ege", 23);
            chart1.Series["Bolge"].Points.AddXY("Karadeniz", 16);
            chart1.Series["Bolge"].Points.AddXY("Doğu Anadolu", 24);
            chart1.Series["Bolge"].Points.AddXY("Marmara", 17);

        }
        /**Proggesbar */

        private void Btn_artir_Click(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
     
        }

        private void Btn_azalt_Click(object sender, EventArgs e)
        {
            progressBar1.Value -= 10;
        }

        /*Proggesbar uygulaması*/
        private void Btn_baslat_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Prgsbar2.Value += 1;
            if(Prgsbar2.Value == 100) 
            {
                timer1.Stop();
                timer2.Start();
            }
            sayac++;
            label4.Text = sayac.ToString();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Prgsbar3.Value += 20;
            if(Prgsbar3.Value == 100)
            {
                timer2.Stop();
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Prgsbar4.Value += 25;
            if(Prgsbar4.Value== 100)
            {
                timer3.Stop();
                MessageBox.Show("Tüm işlemler tamamlandı.");
            }
        }

       
    }
}
