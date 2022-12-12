using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Dosyaİşlemleri
{
    public partial class Btnkonumsec : Form
    {
        public Btnkonumsec()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();// istenen konuma yeni klasör ekler seçer,dizinleri gösterir.
            label1.Text = folderBrowserDialog1.SelectedPath; // seçilen yolu label 1 e aktar
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(); // Dosyaları gösterir
            label1.Text = openFileDialog1.FileName; // Open file da seçilen dosya adını label 1 e aktarır   
        }

        private void Btnsavefiledialog_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog(); //Kayıt türü seçeneği de vardır.
        }
        string belgeyolu, belgeadi;

        private void Btnolustur_Click(object sender, EventArgs e)
        {
            if(Txtad.Text=="" || Txtad.Text == string.Empty)
            {
                MessageBox.Show("Alan boş bırakılamaz");
            }
            else
            {
                belgeadi = Txtad.Text; // Txtad.Text den gelen değer değişkene aktarıldı
                StreamWriter sw = File.CreateText(belgeyolu + "\\" + belgeadi + ".txt");   //sw değişkenine belge oluşturma işlemi aktarıldı 
                MessageBox.Show("Belgeniz başarıyla oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); //mesaj kutusunda mesaj verildi
            }


            
        }

        private void Btnoku_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK) // Open file dialoga penceresi gelince tıklama işleminde şu olsun.
            {
                StreamReader oku = new StreamReader(openFileDialog1.FileName); // dialogdan gelen dosyayı oku 
                string satir = oku.ReadLine();  // satır satır belgeyi okur
                while(satir != null)
                {
                    listBox1.Items.Add(satir); //Liste kutusuna ekle satır değişkeninde değerleri
                    satir = oku.ReadLine();
                }
            }
        }

        private void Btnyazdır_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Metin dosyasi |*.txt"; // Dialog alanında sadece txt dosyaları gösterilir.
            saveFileDialog1.ShowDialog();  //Dialog alanı açılır.
            StreamWriter kaydet = new StreamWriter(saveFileDialog1.FileName); //Dialog alanında yazılan dosya adı kullanılır.
            kaydet.WriteLine(richTextBox1.Text);  //Kaydedilecek alanlar richTextBox1.text 'den gelecek.
            kaydet.Close();          //Kaydetme işlemini kapat.
            MessageBox.Show("Metin belgesine kayıt yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Mesaj kutusu eklendi
        }

        private void Btnkonum_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                belgeyolu= folderBrowserDialog1.SelectedPath;  // Seçili dosya yolunu değişkene atar
                Txtyol.Text = belgeyolu;                 // Txtyol içerisinde belge yolunu yazdırır.
            }

        }
    }
}
