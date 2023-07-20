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


namespace AllyGano
{
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=EFSWALLY;Initial Catalog=siparisTakibi;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                komut = new SqlCommand("INSERT INTO urunler (u_ID,u_Kategori,u_Adi,u_PaketAdeti,u_Fiyati) VALUES(@id,@kategori,@adi,@adet,@fiyat)", baglanti);
                komut.Parameters.AddWithValue("@id", textBox1.Text);
                komut.Parameters.AddWithValue("@kategori", comboBox1.SelectedItem);
                komut.Parameters.AddWithValue("@adi", textBox2.Text);
                komut.Parameters.AddWithValue("@adet", int.Parse(textBox3.Text));
                komut.Parameters.AddWithValue("@fiyat", int.Parse(textBox4.Text));
                komut.ExecuteNonQuery();
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
                MessageBox.Show("Yeni Ürün Başarıyla Eklendi!");
                temizle();
                this.Hide();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu! " + hata.Message);
            }
        }
        public void temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
