using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ucak_rezervasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota: " + comboBox1.Text + "--" + comboBox2.Text + " Tarih: " + dateTimePicker1.Text + " Ad Soyad: " + textBox1.Text + " TC: "+ maskedTextBox1.Text + " No: "+maskedTextBox2.Text);
            MessageBox.Show("Yolcu Kaydı Yapılmıştır");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text =comboBox1.Text ;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text=label9.Text;

        }
    }
}
