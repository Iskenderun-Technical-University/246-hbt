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
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void btnasis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Asistan'a mesaj gönderildi.");
        }

        private void btnçlşbil_Click(object sender, EventArgs e)
        {
            CalisanBilg fr3 = new CalisanBilg();
            fr3.Show();
        }

        private void btnçlşkydt_Click(object sender, EventArgs e)
        {
            Calisanİslemleri fr4 = new Calisanİslemleri();
            fr4.Show();
        }

        private void btntop_Click(object sender, EventArgs e)
        {
            Toplanti fr5 = new Toplanti();
            fr5.Show();
        }

        private void btngörev_Click(object sender, EventArgs e)
        {
            Gorev fr6 = new Gorev();
            fr6.Show();
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
