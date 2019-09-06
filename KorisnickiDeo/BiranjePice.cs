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
    public partial class BiranjePice : Form
    {
        public BiranjePice()
        {
            InitializeComponent();
        }

        

        private void btn_SledecaBiranjePica_Click(object sender, EventArgs e)
        {
            Potvrda p = new Potvrda();
            this.Hide();
            p.Show();
        }
    }
}
