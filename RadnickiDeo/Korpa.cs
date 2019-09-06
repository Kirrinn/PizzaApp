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
{   //kada pritisne nazad indeks se promeni popravi to
    public partial class Korpa : Form
    {
        public Korpa()
        {
            InitializeComponent();
        }

        private void btn_Nazad2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void Korpa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Korpa_Load(object sender, EventArgs e)
        {
            ispisPorudzbina(Storage.Porudzbine);
        }

     
        private void ispisPorudzbina(List<Porudzbina> por)
        {
            txt_ListaPorudzbina.Text = string.Join(Environment.NewLine, por);
        }

        private void ukloniSaListe()
        {
            int indeks;
            int.TryParse(txt_BrojPorudzbine.Text, out indeks);
            Storage.Porudzbine.RemoveAt(indeks);
        }

        private void btn_Izbrisi_Click(object sender, EventArgs e)
        {
            ukloniSaListe();
            ispisPorudzbina(Storage.Porudzbine);
        }
    }
}
