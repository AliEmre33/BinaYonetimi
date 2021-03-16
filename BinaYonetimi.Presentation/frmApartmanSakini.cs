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
    public partial class frmApartmanSakini : Form
    {
        public frmApartmanSakini()
        {
            InitializeComponent();
        }
        frmLogin frmLogin = (frmLogin)Application.OpenForms["frmLogin"];

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            
            frmLogin.Show();
        }

        private void frmApartmanSakini_Load(object sender, EventArgs e)
        {
            label1.Text = frmLogin.kullanici.KullaniciAdi;

            textBox1.Text = frmLogin.kullanici.AD;
            textBox2.Text = frmLogin.kullanici.Soyad;
            textBox3.Text = frmLogin.kullanici.KullaniciAdi;
            textBox4.Text = frmLogin.kullanici.Sifre;
            numericUpDown1.Text = frmLogin.kullanici.Yas.ToString();
            comboBox1.SelectedIndex =Convert.ToInt32( frmLogin.kullanici.Cinsiyet);
            textBox7.Text = frmLogin.kullanici.MailAdresi;
            textBox8.Text = frmLogin.kullanici.Telefon.ToString();
            comboBox2.SelectedIndex = Convert.ToInt32(frmLogin.kullanici.MedeniDurum);
            textBox10.Text = ApartmanBLL.Select(frmLogin.kullanici.ApartmanID).ApartmanAdı;


        }

        private void frmApartmanSakini_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
