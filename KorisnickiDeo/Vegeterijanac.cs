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
    public partial class Vegeterijanac : Form
    {
        public Vegeterijanac()
        {
            InitializeComponent();
        }

        private void btn_DaVegeterijanac_Click(object sender, EventArgs e)
        {
            VegeterijanskiMeni me = new VegeterijanskiMeni();
            this.Hide();
            me.Show();
        }

        private void btn_NeVegeterijanac_Click(object sender, EventArgs e)
        {
            NevegetarijanskiMeni me = new NevegetarijanskiMeni();
            this.Hide();
            me.Show();
        }
    }
}
