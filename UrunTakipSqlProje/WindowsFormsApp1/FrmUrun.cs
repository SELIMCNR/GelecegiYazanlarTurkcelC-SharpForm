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
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-6G93D3J\SQLEXPRESS;Initial Catalog=DbUrun;Integrated Security=True");

        private void Btn_listele_Click(object sender, EventArgs e)
        {
            //Listele

            SqlCommand komut = new SqlCommand("Select * from TblUrunler",baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource= dt;
            
        }

        private void Btn_kaydet_Click(object sender, EventArgs e)
        {
            // Kaydet 
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TblUrunler (Urunad,Stok,AlisFiyat,SatisFiyat,Kategori) values (@p1,@p2,@p3,@p4,@p5)",baglanti);
            komut.Parameters.AddWithValue("@p1", Text_Ad.Text);
            komut.Parameters.AddWithValue("@p2", Nud_Stok.Value);
            komut.Parameters.AddWithValue("@p3", Text_Alısfiyat.Text);
            komut.Parameters.AddWithValue("@p4", Text_Satış.Text);
            komut.Parameters.AddWithValue("@p5", comboBox1.SelectedValue);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün kaydı başarılı bir şekilde gerçekleşti");

        }

        private void FrmUrun_Load(object sender, EventArgs e)
        { 
            //Comboboxa değer ekleme
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from TblKategori", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            // Combobox1 e değerler eklendi;
            comboBox1.DisplayMember = "Ad";
         
            comboBox1.ValueMember= "Id";
         
            
            comboBox1.DataSource = dt;
            baglanti.Close();
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from TblUrunler where Urunid=@p1 ", baglanti);
            komut.Parameters.AddWithValue("@p1", Text_Urun.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün silme işlemi gerçekleşti");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Datagridviewda tıklanılan değerleri textbpxa at. 
            Text_Urun.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Text_Ad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Nud_Stok.Value = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            Text_Alısfiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            Text_Satış.Text= dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            comboBox1.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update TblUrunler set UrunAd=@p1,Stok=@p2,AlisFiyat=@p3,SatisFiyat=@p4,Kategori=@p5 where Urunid = @p6",baglanti);
 
            komut.Parameters.AddWithValue("@p1", Text_Ad.Text);
            komut.Parameters.AddWithValue("@p2", Nud_Stok.Value);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(Text_Alısfiyat.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse( Text_Satış.Text));
            komut.Parameters.AddWithValue("@p5", comboBox1.SelectedValue);
            komut.Parameters.AddWithValue("@p6", Text_Urun.Text);

            komut.ExecuteNonQuery();

    

            baglanti.Close();

            MessageBox.Show("Ürün bilgileri başarıyla güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
