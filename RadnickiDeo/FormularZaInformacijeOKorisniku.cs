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
    public partial class FormularZaInformacijeOKorisniku : Form
    {
        public FormularZaInformacijeOKorisniku()
        {
            InitializeComponent();
        }
       #region EVENT
        private void btn_Kartica_Click(object sender, EventArgs e)
        {
            String ime = txt_Ime.Text;
            String prezime = txt_Prezime.Text;
            String telefon = txt_BrojTelefona.Text;
            String adresa = txt_Adresa.Text;

            Person p = new Person(ime, prezime, adresa, telefon, "0");
            //pitaj za ovaj deo
            FormaZaPrikupljanjeInformacijaSaKartice fk = new FormaZaPrikupljanjeInformacijaSaKartice(p);
            this.Hide();
            fk.Show();
        }


        private void FormularZaInformacijeOKorisniku_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }




        #endregion

        private void pokupiPodatke()
        {
            String ime = txt_Ime.Text;
            String prezime = txt_Prezime.Text;
            String telefon = txt_BrojTelefona.Text;
            String adresa = txt_Adresa.Text;

            Person p = new Person(ime, prezime, adresa, telefon, "0");
            postaviCenu(p);
            Storage.Porudzbine.Clear();
            Storage.Osobe.Add(p);
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
        private void btn_Novac_Click(object sender, EventArgs e)
        {
            pokupiPodatke();
            
        }
    }
}
