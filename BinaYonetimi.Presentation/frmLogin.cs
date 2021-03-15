using BinaYonetimi.Business;
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

        private void button1_Click(object sender, EventArgs e)
        {
            int durum = KullaniciBLL.kullaniciLogin(textBox1.Text,textBox2.Text);

            if (durum>0)
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
