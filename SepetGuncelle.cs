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
    public partial class SepetGuncelle : Form
    {
        public SepetGuncelle()
        {
            InitializeComponent();
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
