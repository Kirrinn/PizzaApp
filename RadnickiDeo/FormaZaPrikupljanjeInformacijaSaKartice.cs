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
    public partial class FormaZaPrikupljanjeInformacijaSaKartice : Form
    {
        public FormaZaPrikupljanjeInformacijaSaKartice(Person osoba)
        {
            InitializeComponent();
            this.osoba = osoba;
        }
        private Person osoba;
        private void setKartica(Person p)
        {
            p.BrojRacuna = txt_BrojKartice.Text;
        }
        private void FormaZaPrikupljanjeInformacijaSaKartice_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void postaviCenu(Person p)
        {
            double suma = 0;
            foreach (Porudzbina porudzbina in Storage.Porudzbine)
            {
                suma += porudzbina.CenaPorudzbine;
            }
            p.UkupnaCena = suma;
        }

        private void btn_Kraj_Click(object sender, EventArgs e)
        {
            setKartica(osoba);
            postaviCenu(osoba);
            Storage.Porudzbine.Clear();
            Storage.Osobe.Add(osoba);
            Console.Write(osoba.Ime);
            
        }
    }
}
