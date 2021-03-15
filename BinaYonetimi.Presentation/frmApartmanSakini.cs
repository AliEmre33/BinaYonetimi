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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin frmLogin = (frmLogin)Application.OpenForms["frmLogin"];
            frmLogin.Show();
        }
    }
}
