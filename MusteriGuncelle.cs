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
    public partial class MusteriGuncelle : Form
    {
        public MusteriGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=EFSWALLY;Initial Catalog=siparisTakibi;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public void temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                komut = new SqlCommand("UPDATE musteri SET m_Adi=@adi,m_Soyadi=@soyadi,m_Tel=@tel,m_Sehir=@sehir,m_AlisNedeni=@neden WHERE m_ID=@id", baglanti);
                komut.Parameters.AddWithValue("@id", textBox5.Text);
                komut.Parameters.AddWithValue("@adi", textBox1.Text);
                komut.Parameters.AddWithValue("@soyadi", textBox2.Text);
                komut.Parameters.AddWithValue("@tel", textBox3.Text);
                komut.Parameters.AddWithValue("@sehir", comboBox1.SelectedItem);
                komut.Parameters.AddWithValue("@neden", textBox4.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Müşteri Bilgileri Başarıyla Güncellendi!");
                temizle();
                this.Hide();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu! " + hata.Message);
            }
        }
    }
}
