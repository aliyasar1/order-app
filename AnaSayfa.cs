using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllyGano
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        Urunler ac = new Urunler();
        private void button1_Click(object sender, EventArgs e)
        {
            ac.Show();
        }

        Musteriler ac_m = new Musteriler();
        private void button2_Click(object sender, EventArgs e)
        {
            ac_m.Show();
        }
        Siparisler ac_s = new Siparisler();
        private void button3_Click(object sender, EventArgs e)
        {
            ac_s.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Programdan Çıkış Yapıyorsunuz. Emin Misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cevap == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
