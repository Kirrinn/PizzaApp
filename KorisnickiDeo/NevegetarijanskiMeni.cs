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
    public partial class NevegetarijanskiMeni : Form
    {
        public NevegetarijanskiMeni()
        {
            InitializeComponent();
        }

       

        private void btn_SledecaNevegeterijanskiMeni_Click(object sender, EventArgs e)
        {
            BiranjePice bp = new BiranjePice();
            bp.Show();
            this.Hide();
        }
    }
}
