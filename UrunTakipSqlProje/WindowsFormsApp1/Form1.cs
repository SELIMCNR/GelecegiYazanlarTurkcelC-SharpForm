using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbUrunDataSet.TblKategori' table. You can move, or remove it, as needed.


        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-6G93D3J\SQLEXPRESS;Initial Catalog=DbUrun;Integrated Security=True");



        private void Btn_Listele_Click(object sender, EventArgs e)
        {
            //Listeleme
            SqlCommand komut = new SqlCommand("Select * from TblKategori", baglanti); //sql komutu yazılırı

            
            SqlDataAdapter da = new SqlDataAdapter(komut); //adapter baglantısı 


            DataTable dt = new DataTable();  // tablo eklendi
    

            da.Fill(dt);      // adaptör ile tablo içi dolduruldu
      

            dataGridView1.DataSource = dt; // data gridview1 kaynağına tablo eklendi
 
            

            /*Bağlantı açıp kapatmaya gerek yok listeleme işleminde  */

        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {   //Kaydetme

            baglanti.Open();  // baglantı açıldı 
            
            SqlCommand komut = new SqlCommand("insert into  TblKategori (Ad) values (@p1)", baglanti); // sql komutu çalıştırıldı
            
            komut.Parameters.AddWithValue("@p1", Text_KategoriAd.Text);  // dışardan gelen değer eklendi
         

            komut.ExecuteNonQuery(); // komutları uygula 

            baglanti.Close();
     
            MessageBox.Show("Kategoriniz başarılı bir şekilde eklendi.");
  
        }

        private void Btn_Sil_Click(object sender , EventArgs  e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("delete from TblKategori where Id=@p1 ",baglanti);
            
            komut.Parameters.AddWithValue("@p1",Text_Kategoriid.Text);
            
            komut.ExecuteNonQuery();
            
            baglanti.Close();
            
            MessageBox.Show("Kategori silme işlemi başarılı bir şekilde gerçekleşti");
        
            /*İlişkili tablolarda silme işlemi hata verir.*/
        
        }

        private void Btn_guncelle_Click(object sender, EventArgs e)
        {
            // Güncelleme işlemi 
            baglanti.Open();
            
            SqlCommand komut = new SqlCommand("update TblKategori set Ad=@p1 where Id =@p2",baglanti);
           
            komut.Parameters.AddWithValue("@p1", Text_KategoriAd.Text);
           
            komut.Parameters.AddWithValue("@p2", Text_Kategoriid.Text);
           
            komut.ExecuteNonQuery();
            
            baglanti.Close();
            
            MessageBox.Show("Kategori silme işlemi başarılı bir şekilde gerçekleşti");

            

        }

        private void Tbl_Ara_Click(object sender, EventArgs e)
        {
            // ara işlemi 
            SqlCommand komut = new SqlCommand("Select * from TblKategori where Ad=@p1 ", baglanti);
            komut.Parameters.AddWithValue("@p1", Text_KategoriAd.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource= dt;

        }
        // Crud --> Create Read(Search arama) Update Delete 

    }
}