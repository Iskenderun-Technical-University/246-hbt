using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projex
{
    public partial class Calisanİslemleri : Form
    {
        public Calisanİslemleri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çalışan Bilgisi Silindi.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çalışan Çağırıldı.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calisanekle fr7 = new calisanekle();
            fr7.Show();
            this.Hide();
        }

        private void Calisanİslemleri_Load(object sender, EventArgs e)
        {

        }
    }
}
