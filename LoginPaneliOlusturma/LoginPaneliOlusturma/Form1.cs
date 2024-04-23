using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPaneliOlusturma
{
    public partial class OnlineDersGirisPaneli : Form
    {
        public OnlineDersGirisPaneli()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Giriş Onaylandı.");
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sistemdeki Bir Arıza Nedeniyle Şuan Yardım Edemiyoruz. Lütfen Daha Sonra Tekrar Deneyiniz.");
            Application.Exit();
        }
    }
}
