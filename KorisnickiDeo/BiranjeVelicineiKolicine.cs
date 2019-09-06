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
    public partial class BiranjeVeličineiKoličine : Form
    {
        public BiranjeVeličineiKoličine()
        {
            InitializeComponent();
        }

       

        private void btn_SledecaBiranjeVelicineIKolicine_Click(object sender, EventArgs e)
        {
            Vegeterijanac v = new Vegeterijanac();
            this.Hide();
            v.Show();
        }
    }
}
