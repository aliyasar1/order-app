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
    public partial class Sepet : Form
    {
        public Sepet()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=EFSWALLY;Initial Catalog=siparisTakibi;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        SqlDataAdapter da;
        private void SiparisEkle_Load(object sender, EventArgs e)
        {
            this.sepetTableAdapter.Fill(this.siparisTakibiDataSet.sepet);
            baglanti.Open();
            ToplamUrun();
            baglanti.Close();
        }
        Urunler urunler = new Urunler();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("SELECT * FROM urunler WHERE u_Kategori = '"+comboBox1.SelectedItem +"'", baglanti);
                comboBox2.Items.Clear();
                comboBox2.Text = "";
                SqlDataReader oku;
                baglanti.Open();
                oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    comboBox2.Items.Add(oku["u_Adi"]);
                }
                baglanti.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Seçilen Kategoriye Ait Ürün Bulunamamaştır.");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBox5.Text = "1";
                SqlCommand komut = new SqlCommand("SELECT * FROM urunler WHERE u_Adi = '" + comboBox2.SelectedItem + "'", baglanti);
                SqlDataReader oku;
                baglanti.Open();
                oku = komut.ExecuteReader();
                while(oku.Read())
                {
                    textBox6.Text = oku["u_Fiyati"].ToString();
                    textBox11.Text = oku["u_ID"].ToString();
                }
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Seçilen Kategoriye Ait Ürün Bulunamamaştır.");
            }
        }

        public void ToplamUrun()
        {
            SqlCommand kmt = new SqlCommand("SELECT SUM(u_Adeti) AS ToplamAdet, SUM(u_Fiyati) AS ToplamFiyat FROM sepet", baglanti);
                SqlDataReader oku;
                oku = kmt.ExecuteReader();
                while(oku.Read())
                {
                    textBox8.Text = oku["ToplamAdet"].ToString();
                    textBox10.Text = oku["ToplamFiyat"].ToString();
                    textBox7.Text = oku["ToplamFiyat"].ToString();
                }
        }
        public void SepetGoster()
        {
            da = new SqlDataAdapter("SELECT * FROM sepet WHERE s_ID is NULL", baglanti);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;       
        }
        public void temizle()
        {
            textBox11.Clear();
            textBox5.Clear();
            textBox6.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int adet, fiyat, toplam;
            adet = int.Parse(textBox5.Text);
            fiyat = int.Parse(textBox6.Text);
            toplam = adet * fiyat;
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("INSERT INTO sepet (u_ID, u_Kategori, u_Adi, u_Adeti, u_Fiyati) VALUES ('" + textBox11.Text + "', '" + comboBox1.SelectedItem + "', '" + comboBox2.SelectedItem + "', "+textBox5.Text+", "+toplam+" )", baglanti);
            komut1.ExecuteNonQuery();
            SepetGoster();
            temizle();
            ToplamUrun();
            baglanti.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                komut = new SqlCommand("DELETE FROM sepet WHERE spt_ID=@id", baglanti);
                komut.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                komut.ExecuteNonQuery();
                ToplamUrun();
                baglanti.Close();
                SepetGoster();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu! " + hata.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int odeme, odenen = 0, kalan, toplam;
            odeme = int.Parse(textBox12.Text);
            kalan = int.Parse(textBox10.Text);
            if (odeme > kalan || odeme<=0)
            {
                MessageBox.Show("Ödenecek Ücret Kalan Tutardan Fazla veya 0'dan Küçük Olamaz!");
                textBox12.Text = "";
            }
            else
            {
                toplam = kalan - odeme;
                odenen += odeme;
                textBox9.Text = odenen.ToString();
                textBox10.Text = toplam.ToString();
                textBox12.Text = "";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Sepeti Onaylıyorsunuz. Daha Sonra Değişiklik Yapılmayacaktır. Devam Etmek İstiyor Musunuz ?", "Sepeti Onayla", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cevap == DialogResult.Yes)
            {
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                textBox5.Enabled = false;
                button1.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
            }
            baglanti.Open();
            SqlCommand kmt = new SqlCommand("SELECT * FROM siparis", baglanti);
            SqlDataReader yazdir;
            yazdir = kmt.ExecuteReader();
            while (yazdir.Read())
            {
                textBox13.Text = yazdir["s_ID"].ToString();
            }
            baglanti.Close();
        }
        Siparisler ac_siparis = new Siparisler();
        private void button3_Click(object sender, EventArgs e)
        {
               try
                {
                    string durum = "Yeni Sipariş";
                    baglanti.Open();
                    komut = new SqlCommand("INSERT INTO siparis (m_ID, m_Adi, m_Soyadi, m_Tel, s_Tarih, s_UrunSayisi, s_Odenen, s_Kalan, s_SiparisDurum) VALUES (@id,@adi,@soyadi,@tel,@tarih,@urunsayisi,@odenen,@kalan,@siparisdurumu)", baglanti);
                    komut.Parameters.AddWithValue("@id", textBox1.Text);
                    komut.Parameters.AddWithValue("@adi", textBox2.Text);
                    komut.Parameters.AddWithValue("@soyadi", textBox3.Text);
                    komut.Parameters.AddWithValue("@tel", textBox4.Text);
                    komut.Parameters.AddWithValue("@tarih", dateTimePicker1.Value);
                    komut.Parameters.AddWithValue("@urunsayisi", textBox8.Text);
                    komut.Parameters.AddWithValue("@odenen", textBox9.Text);
                    komut.Parameters.AddWithValue("@kalan", textBox10.Text);
                    komut.Parameters.AddWithValue("@siparisdurumu", durum);
                    komut.ExecuteNonQuery();
                    DialogResult cevap = MessageBox.Show("Sipariş Kaydediliyor. Onaylıyor Musunuz ?", "Sipariş Kaydediliyor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (cevap == DialogResult.Yes)
                    {
                        SqlCommand komut1 = new SqlCommand("update sepet (s_ID) set (@s_id) where spt_ID = '"+dataGridView1.CurrentRow.Cells[0].Value.ToString()+"'", baglanti);
                        komut1.Parameters.AddWithValue("@s_id", textBox13.Text);
                        komut1.ExecuteNonQuery();
                        MessageBox.Show("Yeni Sipariş Başarıyla Kaydedildi!");
                    }
                    baglanti.Close();
                    this.Hide();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Hata Oluştu! " + hata.Message);
                }
        } 
    }
}
