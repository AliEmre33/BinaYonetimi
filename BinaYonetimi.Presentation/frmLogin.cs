using BinaYonetimi.Business;
using BinaYonetimi.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaYonetimi.Presentation
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public Kullanici kullanici = null;

        private void button1_Click(object sender, EventArgs e)
        {
             kullanici = KullaniciBLL.kullaniciLogin(textBox1.Text,textBox2.Text);

            if (kullanici !=null)
            {
                MessageBox.Show("Giriş Başarılı");
                frmApartmanSakini apartmanSakini = new frmApartmanSakini();
                apartmanSakini.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Kullanici Adi veya şifre yanlış");
            }

        }
    }
}
