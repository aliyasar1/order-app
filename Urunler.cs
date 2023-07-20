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
    public partial class Urunler : Form
    {
        public Urunler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=EFSWALLY;Initial Catalog=siparisTakibi;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        SqlDataAdapter da;

        UrunEkle ac = new UrunEkle();
        UrunGuncelle guncelle = new UrunGuncelle();

        private void button1_Click(object sender, EventArgs e)
        {
            ac.Show();
        }

        public void UrunleriGoster()
        {
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM urunler ORDER BY u_Kategori ASC", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void Urunler_Load(object sender, EventArgs e)
        {
            this.urunlerTableAdapter.Fill(this.siparisTakibiDataSet.urunler);
            UrunleriGoster();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            guncelle.Show();
            guncelle.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            guncelle.comboBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            guncelle.textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            guncelle.textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            guncelle.textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UrunleriGoster();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                komut = new SqlCommand("DELETE FROM urunler WHERE u_ID=@id", baglanti);
                komut.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Seçilen Ürün Başarıyla Silindi!");
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
