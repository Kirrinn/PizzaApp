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
    public partial class VrstaGotovePice : Form
    {
        public VrstaGotovePice()
        {
            InitializeComponent();
        }

        private void btn_SledecaVrstaGotovePice_Click(object sender, EventArgs e)
        {
            BiranjePice bp = new BiranjePice();
            this.Hide();
            bp.Show();
        }
    }
}
