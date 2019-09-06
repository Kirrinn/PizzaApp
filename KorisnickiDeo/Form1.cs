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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Gotove_Click(object sender, EventArgs e)
        {
            VrstaGotovePice v = new VrstaGotovePice();
            this.Hide();
            v.Show();
        }

        private void btn_Nova_Click(object sender, EventArgs e)
        {
            BiranjeVeličineiKoličine v = new BiranjeVeličineiKoličine();
            this.Hide();
            v.Show();
        }
    }
}
