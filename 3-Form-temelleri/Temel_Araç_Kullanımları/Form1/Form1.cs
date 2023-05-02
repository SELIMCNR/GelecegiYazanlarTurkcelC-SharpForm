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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //label6.Text = "Selim Çınar"; //label 6 ya değeri yazdırıyor.
            label6.Text = comboBox1.Text; // label 6'ya comboboxtan gelen değer eklendi.
            textBox1.Text = "Reac Native"; // textbox1'e değer eklendi
            label8.Text = textBox1.Text; // buttona tıklayınca textbox1 den gelen değeri yazdırır.
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Javascript"); // liste kutusuna ekler 
            listBox1.Items.Add("PostegroSql");
            comboBox1.Items.Add("Elazığ"); // Combobox kutusuna ekler.
            listBox1.Items.Add(textBox1.Text);  // textbox1 'den gelen değeri ekle
        }
    }
}
