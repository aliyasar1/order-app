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
    public partial class Musteriler : Form
    {
        public Musteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=EFSWALLY;Initial Catalog=siparisTakibi;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        SqlDataAdapter da;

        public void MusterileriGoster()
        {
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM musteri ORDER BY m_ID ASC", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            comboBox1.Enabled = true;
        }

        private void Musteriler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'siparisTakibiDataSet.musteri' table. You can move, or remove it, as needed.
            this.musteriTableAdapter.Fill(this.siparisTakibiDataSet.musteri);
            MusterileriGoster();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
        MusteriEkle ac = new MusteriEkle();

        private void button6_Click(object sender, EventArgs e)
        {
            MusterileriGoster();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ac.Show();

        }
        MusteriGuncelle guncelle = new MusteriGuncelle();

        private void button3_Click(object sender, EventArgs e)
        {
            guncelle.Show();
            guncelle.textBox5.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            guncelle.textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            guncelle.textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            guncelle.textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            guncelle.comboBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            guncelle.textBox4.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                komut = new SqlCommand("DELETE FROM musteri WHERE m_ID=@id", baglanti);
                komut.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                DialogResult cevap = MessageBox.Show(dataGridView1.CurrentRow.Cells[1].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[2].Value.ToString() + " Adlı Müşteri Silinecektir. Emin Misiniz ?", "Müşteri Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    MessageBox.Show("Seçilen Müşteri Başarıyla Silindi!");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu! " + hata.Message);
            }
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
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu! " + hata.Message);
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
            
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                da = new SqlDataAdapter("SELECT * FROM musteri WHERE m_AlisNedeni like '%" + textBox4.Text + "%'", baglanti);
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

    }
}
