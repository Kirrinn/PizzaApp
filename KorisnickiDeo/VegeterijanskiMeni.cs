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
    public partial class VegeterijanskiMeni : Form
    {
        public VegeterijanskiMeni()
        {
            InitializeComponent();
        }

        //ako se izbrise ovo se kresuje
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

    

        private void btn_SledecaVegeterijanskiMeni_Click(object sender, EventArgs e)
        {
            BiranjePice bp = new BiranjePice();
            bp.Show();
            this.Hide();
        }
    }
}
