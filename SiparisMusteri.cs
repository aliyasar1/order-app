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
    public partial class SiparisMusteri : Form
    {
        public SiparisMusteri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=EFSWALLY;Initial Catalog=siparisTakibi;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        SqlDataAdapter da;

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public void MusterileriGoster()
        {
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM musteri ORDER BY m_ID ASC", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        private void SipaarisMusteri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'siparisTakibiDataSet.musteri' table. You can move, or remove it, as needed.
            this.musteriTableAdapter.Fill(this.siparisTakibiDataSet.musteri);
            MusterileriGoster();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                da = new SqlDataAdapter("SELECT * FROM musteri WHERE m_ID like '%" + int.Parse(textBox5.Text) + "%'", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                baglanti.Close();
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen geçerli bir Müşteri ID giriniz! ");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                da = new SqlDataAdapter("SELECT * FROM musteri WHERE m_Adi like '%" + textBox1.Text + "%'", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                baglanti.Close();
                dataGridView1.DataSource = dt;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu! " + hata.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                da = new SqlDataAdapter("SELECT * FROM musteri WHERE m_Soyadi like '%" + textBox2.Text + "%'", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                baglanti.Close();
                dataGridView1.DataSource = dt;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu! " + hata.Message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                da = new SqlDataAdapter("SELECT * FROM musteri WHERE m_Tel like '%" + textBox3.Text + "%'", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                baglanti.Close();
                dataGridView1.DataSource = dt;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu! " + hata.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                da = new SqlDataAdapter("SELECT * FROM musteri WHERE m_Sehir like '%" + comboBox1.Text + "%'", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                baglanti.Close();
                dataGridView1.DataSource = dt;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu! " + hata.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
            
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Sepet ac = new Sepet();
            ac.Show();
            da = new SqlDataAdapter("SELECT * FROM sepet WHERE s_ID is NULL", baglanti);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            ac.dataGridView1.DataSource = dt;
            ac.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ac.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            ac.textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            ac.textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            this.Hide();
        }
    }
}
