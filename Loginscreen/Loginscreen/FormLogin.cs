using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loginscreen
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            string kullaniciadi = textBoxKullaniciAdi.Text;
            string sifre = textBoxSifre.Text;


            if(kullaniciadi=="asd" && sifre=="asd")
            {
                Form1 f1 = new Form1();
                f1.ShowDialog();


            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalıdır.");
                textBoxKullaniciAdi.Text = "";
                textBoxSifre.Text = "";
                    
               
            }
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            textBoxKullaniciAdi.Text = "";
            textBoxSifre.Text = "";
        }
    }
}
