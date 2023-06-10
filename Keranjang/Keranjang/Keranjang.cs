using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keranjang
{
    public partial class Keranjang : UserControl
    {
        public Keranjang()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {

        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            string placeholderText = "Masukkan teks di sini";

            if (textBox1.Text == placeholderText)
            {
                textBox1.Text = "";
            }
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            string placeholderText = "Masukkan teks di sini";

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = placeholderText;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            string placeholderText = "Masukkan teks di sini";
            textBox1.Text = placeholderText;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
