using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcakBiletRezervasyonSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label10.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label10.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Yolcu Bilgileri: " + textBox1.Text + " - " + comboBox3.Text + " - " + maskedTextBox1.Text + " - " + maskedTextBox2.Text + " // Rota: " + comboBox1.Text + " - " + comboBox2.Text + " - " + dateTimePicker1.Text + " - " + maskedTextBox3.Text);
            MessageBox.Show("Kaydınız Alınmıştır.");
        }
    }
}
