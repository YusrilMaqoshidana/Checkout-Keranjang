using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
            items.AddRange(new[] { checkBox2, checkBox3, checkBox4, checkBox5 });
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
        private List<CheckBox> items = new List<CheckBox>();
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void UpdateCheckBox1State()
        {
            if (checkBox2.Checked && checkBox3.Checked && checkBox4.Checked && checkBox5.Checked == true)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
        }


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCheckBox1State();
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCheckBox1State();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCheckBox1State();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCheckBox1State();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            bool isChecked = checkBox1.Checked ;
            foreach (CheckBox item in items)
            {
                item.Checked = isChecked;
            }
        }
    }
}
