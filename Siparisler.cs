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
    public partial class Siparisler : Form
    {
        public Siparisler()
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
        SiparisMusteri ac = new SiparisMusteri();
        private void button1_Click(object sender, EventArgs e)
        {
            ac.Show();
        }

        public void dataRenk()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[7].Value) >= 1)
                {
                    renk.BackColor = Color.Gold;
                    renk.ForeColor = Color.Black;
                }
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[8].Value) == 0)
                {
                    renk.BackColor = Color.DarkOrchid;
                    renk.ForeColor = Color.Black;
                }
                dataGridView1.Rows[i].DefaultCellStyle = renk;
            }
        }

        private void Siparisler_Load(object sender, EventArgs e)
        {
            this.siparisTableAdapter.Fill(this.siparisTakibiDataSet.siparis);
            dataRenk();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM siparis", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataRenk();
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                komut = new SqlCommand("DELETE FROM siparis WHERE s_ID=@id", baglanti);
                komut.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                DialogResult cevap = MessageBox.Show(dataGridView1.CurrentRow.Cells[2].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[3].Value.ToString() + " Adlı Müşteri Adına Oluşturulan " + dataGridView1.CurrentRow.Cells[0].Value.ToString() + " No'lu Sipariş Silinecektir. Emin Misiniz ?", "Sipariş Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    MessageBox.Show(dataGridView1.CurrentRow.Cells[0].Value.ToString() + " No'lu Sipariş Başarıyla Silindi!");
                    this.siparisTableAdapter.Fill(this.siparisTakibiDataSet.siparis);
                    dataRenk();
                }
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
                da = new SqlDataAdapter("SELECT * FROM SİPARİS WHERE s_ID like '%" + int.Parse(textBox1.Text) + "%'", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                baglanti.Close();
                dataGridView1.DataSource = dt;
                dataRenk();
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
                da = new SqlDataAdapter("SELECT * FROM siparis WHERE m_Adi like '%" + textBox2.Text + "%'", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                baglanti.Close();
                dataGridView1.DataSource = dt;
                dataRenk();
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
                da = new SqlDataAdapter("SELECT * FROM siparis WHERE m_Soyadi like '%" + textBox3.Text + "%'", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                baglanti.Close();
                dataGridView1.DataSource = dt;
                dataRenk();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu! " + hata.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                da = new SqlDataAdapter("SELECT * FROM siparis WHERE m_Tel like '%" + textBox4.Text + "%'", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                baglanti.Close();
                dataGridView1.DataSource = dt;
                dataRenk();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu! " + hata.Message);
            }
        }
        SepetGuncelle guncelle = new SepetGuncelle();
        private void button3_Click(object sender, EventArgs e)
        {
            guncelle.Show();
            guncelle.textBox13.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            guncelle.textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            guncelle.textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            guncelle.textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            guncelle.textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            guncelle.dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            guncelle.textBox8.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            guncelle.textBox9.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            guncelle.textBox10.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            int toplamTutar = Convert.ToInt32(guncelle.textBox9.Text) + Convert.ToInt32(guncelle.textBox10.Text);
            guncelle.textBox7.Text = toplamTutar.ToString();
        }
    }
}
