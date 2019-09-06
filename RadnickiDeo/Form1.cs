using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
// dodaj mesageboxsove za obavestenja
namespace RadnickiDeo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txt_CenaPocetnaStrana.Text = "0";
            nud_PicePocetnaStrana.Minimum = 0;
            nud_VelicinaPocetnaStrana.Minimum = 0;
            lbl_Popust1.Visible = false;
            
        }

    
        #region Event Heandler
        private void btn_Korpa1_Click(object sender, EventArgs e)
        {
            Korpa k = new Korpa();
            this.Hide();
            k.Show();
        }

        private void btn_NapSam_Click(object sender, EventArgs e)
        {
            
            NapraviSam ns = new NapraviSam();
            this.Hide();
            ns.Show();

        }

        private void btn_PotPor1_Click(object sender, EventArgs e)
        {
            NacinPorudzbine np = new NacinPorudzbine();
            this.Hide();
            np.Show();
            Storage.IndexListe = 0;
        }
       
        #endregion

        #region Trazenje Cena
        private double dajCenuPizze()
        {
            double cena = 0;

            if (rbt_Margarita.Checked && rbt_MalaPocetnaStrana.Checked)
                cena += GotoveCeneRadnicki.mMargarita;
            else if (rbt_Margarita.Checked && rbt_SrednjaPocetnaStrana.Checked)
                cena += GotoveCeneRadnicki.sMargarita;
            else if (rbt_Margarita.Checked && rbt_VelikaPocetnaStrana.Checked)
                cena += GotoveCeneRadnicki.vMargarita;
            /////////////////
            else if (rbt_Capriccosa.Checked && rbt_MalaPocetnaStrana.Checked)
                cena += GotoveCeneRadnicki.mCapriccosa;
            else if (rbt_Capriccosa.Checked && rbt_SrednjaPocetnaStrana.Checked)
                cena += GotoveCeneRadnicki.sCapriccosa;
            else if (rbt_Capriccosa.Checked && rbt_VelikaPocetnaStrana.Checked)
                cena += GotoveCeneRadnicki.vCapriccosa;
            /////////////////
            else if (rbt_QuaFor.Checked && rbt_MalaPocetnaStrana.Checked)
                cena += GotoveCeneRadnicki.mQuaFor;
            else if (rbt_QuaFor.Checked && rbt_SrednjaPocetnaStrana.Checked)
                cena += GotoveCeneRadnicki.sQuaFor;
            else if (rbt_QuaFor.Checked && rbt_VelikaPocetnaStrana.Checked)
                cena += GotoveCeneRadnicki.vQuaFor;
            /////////////////
            else if (rbt_QuaSta.Checked && rbt_MalaPocetnaStrana.Checked)
                cena += GotoveCeneRadnicki.mQuaSta;
            else if (rbt_QuaSta.Checked && rbt_SrednjaPocetnaStrana.Checked)
                cena += GotoveCeneRadnicki.sQuaSta;
            else if (rbt_QuaSta.Checked && rbt_VelikaPocetnaStrana.Checked)
                cena += GotoveCeneRadnicki.vQuaSta;
            /////////////////   
            else if (rbt_Vesuvio.Checked && rbt_MalaPocetnaStrana.Checked)
                cena += GotoveCeneRadnicki.mVesuvio;
            else if (rbt_Vesuvio.Checked && rbt_SrednjaPocetnaStrana.Checked)
                cena += GotoveCeneRadnicki.sVesuvio;
            else if (rbt_Vesuvio.Checked && rbt_VelikaPocetnaStrana.Checked)
                cena += GotoveCeneRadnicki.vVesuvio;
            /////////////////
            else if (rbt_Hawaiian.Checked && rbt_MalaPocetnaStrana.Checked)
                cena += GotoveCeneRadnicki.mHawaiian;
            else if (rbt_Hawaiian.Checked && rbt_SrednjaPocetnaStrana.Checked)
                cena += GotoveCeneRadnicki.sHawaiian;
            else if (rbt_Hawaiian.Checked && rbt_VelikaPocetnaStrana.Checked)
                cena += GotoveCeneRadnicki.vHawaiian;
            return cena;
        }

        private double dajCenuPica()
        {
            double cena = 0;
            if (rbt_CocaCola1.Checked)
                cena += CenePicaRadnicki.kokakola;
            else if (rbt_Jogurt1.Checked)
                cena += CenePicaRadnicki.jogurt;
            else if (rbt_Voda1.Checked)
                cena += CenePicaRadnicki.voda;
            else if (rbt_KiselaVoda1.Checked)
                cena += CenePicaRadnicki.kisvoda;
            else if (rbt_Guarana1.Checked)
                cena += CenePicaRadnicki.guarana;
            else if (rbt_Jabuka1.Checked)
                cena += CenePicaRadnicki.jabuka;
            return cena;
        }

        private double ukupanPopust;
        private void dajPopust()
        {
            int kolicinaPizza = (int)nud_VelicinaPocetnaStrana.Value;
            int kolicinaPica = (int)nud_PicePocetnaStrana.Value;

           this.ukupanPopust= ObradaPopusta.ukupanPopust(ObradaPopusta.popustNaKolicinuPizze(kolicinaPizza), ObradaPopusta.popustNaKolicinuPica(kolicinaPica));
        }

        private double konacnaCena;
        private void dajKonacnuCenu()
        {
            int kolicinaPizza = (int)nud_VelicinaPocetnaStrana.Value;
            int kolicinaPica = (int)nud_PicePocetnaStrana.Value;
            this.konacnaCena= dajCenuPizze() * kolicinaPizza + dajCenuPica() * kolicinaPica - ukupanPopust;
        }
        #endregion

        
        private void prikazCene()
        {
            dajKonacnuCenu();
            dajPopust();
            lbl_Popust1.Text = "Dobili ste popust u iznosu od dinara:" +ukupanPopust.ToString();
            lbl_Popust1.Visible = true;
            txt_CenaPocetnaStrana.Text = konacnaCena.ToString();
            
        }
       private void dodajUListu()
        {
            Porudzbina p = new Porudzbina(Storage.IndexListe,konacnaCena);
            Storage.Porudzbine.Add(p);
            Storage.IndexListe++;
        }
 
        #region Trenutni Prikaz Cene
     

        private void nud_VelicinaPocetnaStrana_ValueChanged(object sender, EventArgs e)
        {
            prikazCene();
        }

        private void nud_PicePocetnaStrana_ValueChanged(object sender, EventArgs e)
        {
            prikazCene();
        }
        private void rbt_MalaPocetnaStrana_CheckedChanged(object sender, EventArgs e)
        {
            prikazCene();
        }

        private void rbt_SrednjaPocetnaStrana_CheckedChanged(object sender, EventArgs e)
        {
            prikazCene();
        }

        private void rbt_VelikaPocetnaStrana_CheckedChanged(object sender, EventArgs e)
        {

            prikazCene();
        }
        private void rbt_Margarita_CheckedChanged(object sender, EventArgs e)
        {
            prikazCene();
        }

        private void rbt_Capriccosa_CheckedChanged(object sender, EventArgs e)
        {
            prikazCene();
        }

        private void rbt_QuaFor_CheckedChanged(object sender, EventArgs e)
        {
            prikazCene();
        }

        private void rbt_QuaSta_CheckedChanged(object sender, EventArgs e)
        {

            prikazCene();
        }

        private void rbt_Vesuvio_CheckedChanged(object sender, EventArgs e)
        {
            prikazCene();
        }

        private void rbt_Hawaiian_CheckedChanged(object sender, EventArgs e)
        {
            prikazCene();
        }
        private void rbt_CocaCola1_CheckedChanged(object sender, EventArgs e)
        {
            prikazCene();
        }

        private void rbt_Jogurt1_CheckedChanged(object sender, EventArgs e)
        {
            prikazCene();
        }

        private void rbt_Voda1_CheckedChanged(object sender, EventArgs e)
        {
            prikazCene();
        }

        private void rbt_KiselaVoda1_CheckedChanged(object sender, EventArgs e)
        {
            prikazCene();
        }

        private void rbt_Guarana1_CheckedChanged(object sender, EventArgs e)
        {
            prikazCene();
        }

        private void rbt_Jabuka1_CheckedChanged(object sender, EventArgs e)
        {
            prikazCene();
        }
        #endregion

        private void btn_DUK1_Click(object sender, EventArgs e)
        {
            dodajUListu();
        }


        
        
    }

    
}
