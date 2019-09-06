
using RadnickiDeo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KorisnickiDeo
{
    public partial class Potvrda : Form
    {
        public Potvrda()
        {
            InitializeComponent();
        }
        //Ne brisati ovo neki bag u editoru koji moze da srusi aolikaciju
        private void btn_KrajKupovinePotvrda_Click(object sender, EventArgs e)
        {
            NacinPorudzbine np = new NacinPorudzbine();
            np.Show();
            this.Hide();
        }

        private void btn_NastavakKupovinePotvrda_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void btn_KorpaPotvrda_Click(object sender, EventArgs e)
        {
            Korpa1 k = new Korpa1();
            this.Hide();
            k.Show();

        }
    }
}
