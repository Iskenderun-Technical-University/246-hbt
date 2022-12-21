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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {

            string Kuladı;
            string KulŞif;     

            Kuladı = "halil";
            KulŞif = "12345";

            Kuladı = txtkul.Text;
            KulŞif = txtşif.Text;

           if((Kuladı=="halil")&&(KulŞif=="12345"))
            {
                MessageBox.Show("program açılıyor");
                anasayfa f2 = new anasayfa();
                f2.Show();
                this.Hide();
            }
           else
            {
                MessageBox.Show("Yanlış Kullanıcı Adı / Şifre Girdiniz.");
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
