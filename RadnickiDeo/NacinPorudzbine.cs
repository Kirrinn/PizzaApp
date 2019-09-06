using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadnickiDeo
{
    public partial class NacinPorudzbine : Form
    {
        public NacinPorudzbine()
        {
            InitializeComponent();
        }

        private void btn_Dostava_Click(object sender, EventArgs e)
        {
            FormularZaInformacijeOKorisniku fk = new FormularZaInformacijeOKorisniku();
            this.Hide();
            fk.Show();
        }

        private void NacinPorudzbine_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
