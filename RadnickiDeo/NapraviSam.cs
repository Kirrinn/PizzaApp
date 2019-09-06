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
namespace RadnickiDeo
{
    public partial class NapraviSam : Form
    {
        public NapraviSam()
        {
            InitializeComponent();
            txt_CenaNapraviSam.Text = "0";
            nud_PiceNapraviSam.Minimum = 0;
            nud_VelicinaNapraviSam.Minimum = 0;
            lbl_PopustNapraviSam.Visible = false;
        }
        private void prikazPopustaICene()
        {
            obracunajPopust();
            obracunajKrajnjuCenu();
            lbl_PopustNapraviSam.Text = "Dobili ste popust u iznosu od dinara:" + ukupanPopust.ToString();
            lbl_PopustNapraviSam.Visible = true;
            txt_CenaNapraviSam.Text = ukupnaCena.ToString();
        }

        #region even heandler
        private void btn_KorpaNapraviSam_Click(object sender, EventArgs e)
        {
            Korpa k = new Korpa();
            this.Show();
            k.Hide();
        }

        

        private void btn_NazadNapraviSam_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void btn_DUKNapraviSam_Click(object sender, EventArgs e)
        {
            dodajUListu();
   
        }

        private void NapraviSam_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion
       
        CeneSastojaka cs;
        #region cene sastojaka
        private double jaja;
        private double majonez;
        private double origano;
        private double tuna;
        private double sunka;
        private double sir;
        #endregion

        #region trazenje popusta
        private void obracunajPopust()
        {
            int kolPodloga = (int)nud_VelicinaNapraviSam.Value;
            int kolPica = (int)nud_PiceNapraviSam.Value;

            ukupanPopust = ObradaPopusta.ukupanPopust(ObradaPopusta.popustNaKolicinuPizze(kolPodloga), ObradaPopusta.popustNaKolicinuPica(kolPica));
        }

        #endregion

        #region trazenje cene
        private double ukupnaCena;
        private double ukupanPopust;
        private double cenaPodloge;
        private double cenaPica;
        private double cenaSastojaka;
        private void dajCenuPodloga()
        {
            int kolPodloga = (int)nud_VelicinaNapraviSam.Value;

            double cena = 0;

            if (rbt_MalaNapraviSam.Checked)
                cena = kolPodloga * CenePodloga.Mala;
            else if (rbt_SrednjaNapraviSam.Checked)
                cena = kolPodloga * CenePodloga.Srednja;
            else if (rbt_VelikaNapraviSam.Checked)
                cena = kolPodloga * CenePodloga.Velika;

            cenaPodloge = cena;
            Console.Write(cenaPodloge);
        }


        //ono sto pijes
        private void dajCenuPica()
        {
            int kolPica = (int)nud_PiceNapraviSam.Value;

            double cena = 0;

            if (rbt_CocaColaNapraviSam.Checked)
                cena = kolPica * CenePicaRadnicki.kokakola;
            else if (rbt_JogurtNapraviSam.Checked)
                cena = kolPica * CenePicaRadnicki.jogurt;
            else if (rbt_VodaNapraviSam.Checked)
                cena = kolPica * CenePicaRadnicki.voda;
            else if (rbt_KiselaVodaNapraviSam.Checked)
                cena = kolPica * CenePicaRadnicki.kisvoda;
            else if (rbt_GuaranaNapraviSam.Checked)
                cena = kolPica * CenePicaRadnicki.guarana;
            else if (rbt_JabukaNapraviSam.Checked)
                cena = kolPica * CenePicaRadnicki.jabuka;

            cenaPica = cena;
        }

        //osmisli je
        private void dajCenuSastojaka()
        {
            double cena = 0;

            if (cb_JajaNapraviSam.Checked)
                cena += jaja;

            if (cb_MajonezNapraviSam.Checked)
                cena += majonez;

            if (cb_OriganoNapraviSam.Checked)
                cena += origano;

            if (cb_TunaNapraviSam.Checked)
                cena += tuna;

            if (cb_SunkaNapraviSam.Checked)
                cena += sunka;

            if (cb_SirNapraviSam.Checked)
                cena += sir;

            cenaSastojaka = cena;
        }

        private void obracunajKrajnjuCenu()
        {
          
            ukupnaCena = cenaSastojaka + cenaPica + cenaPodloge - ukupanPopust;
        }

        
        #endregion

        #region dodavanje u listu
        private void dodajUListu()
        {
            Porudzbina p = new Porudzbina(Storage.IndexListe,ukupnaCena);
            Storage.Porudzbine.Add(p);
            Storage.IndexListe++;
        }
        #endregion

        #region promena trenutne cene
        private void rbt_MalaNapraviSam_CheckedChanged(object sender, EventArgs e)
        {
            dajCenuPodloga();
            prikazPopustaICene();
        }

        private void rbt_SrednjaNapraviSam_CheckedChanged(object sender, EventArgs e)
        {
            dajCenuPodloga();
            prikazPopustaICene();
        }

        private void rbt_VelikaNapraviSam_CheckedChanged(object sender, EventArgs e)
        {
            dajCenuPodloga();
            prikazPopustaICene();
        }

        private void rbt_CocaColaNapraviSam_CheckedChanged(object sender, EventArgs e)
        {
            dajCenuPica();
            prikazPopustaICene();
        }

        private void rbt_JogurtNapraviSam_CheckedChanged(object sender, EventArgs e)
        {
            dajCenuPica();
            prikazPopustaICene();
        }

        private void rbt_VodaNapraviSam_CheckedChanged(object sender, EventArgs e)
        {
            dajCenuPica();
            prikazPopustaICene();
        }

        private void rbt_KiselaVodaNapraviSam_CheckedChanged(object sender, EventArgs e)
        {
            dajCenuPica();
            prikazPopustaICene();
        }

        private void rbt_GuaranaNapraviSam_CheckedChanged(object sender, EventArgs e)
        {
            dajCenuPica();
            prikazPopustaICene();
        }

        private void rbt_JabukaNapraviSam_CheckedChanged(object sender, EventArgs e)
        {
            prikazPopustaICene();
        }

        private void nud_VelicinaNapraviSam_ValueChanged(object sender, EventArgs e)
        {
            dajCenuPodloga();
            prikazPopustaICene();
        }

        private void nud_PiceNapraviSam_ValueChanged(object sender, EventArgs e)
        {
            dajCenuPica();
            prikazPopustaICene();
        }
        private void cb_OriganoNapraviSam_CheckedChanged(object sender, EventArgs e)
        {
            dajCenuSastojaka();
            prikazPopustaICene();
        }

        private void cb_MajonezNapraviSam_CheckedChanged(object sender, EventArgs e)
        {
            dajCenuSastojaka();
            prikazPopustaICene();
        }

        private void cb_JajaNapraviSam_CheckedChanged(object sender, EventArgs e)
        {
            dajCenuSastojaka();
            prikazPopustaICene();
        }

        private void cb_TunaNapraviSam_CheckedChanged(object sender, EventArgs e)
        {
            dajCenuSastojaka();
            prikazPopustaICene();
        }

        private void cb_SunkaNapraviSam_CheckedChanged(object sender, EventArgs e)
        {
            dajCenuSastojaka();
            prikazPopustaICene();
        }

        private void cb_SirNapraviSam_CheckedChanged(object sender, EventArgs e)
        {
            dajCenuSastojaka();
            prikazPopustaICene();
        }

        #endregion

        #region json
        private void NapraviSam_Load(object sender, EventArgs e)
        {
            dajJson(); ;
            dajCenuIzJsona(cs);
        }
        private void dajJson()
        {
            string line;
            using (StreamReader sr = new StreamReader(@"C:\Users\uros4\OneDrive\Desktop\PizzaApp\RadnickiDeo\sastojci\NapraviSamSastojci.json"))
            {

                line = sr.ReadToEnd();

            }
               var sastojci = JsonConvert.DeserializeObject<CeneSastojaka>(line);

            cs = sastojci;

        }

        private void dajCenuIzJsona(CeneSastojaka cs)
        {
            jaja = cs.jaja.Min();
            majonez = cs.majonez.Min();
            origano = cs.origano.Min();
            tuna = cs.tuna.Min();
            sunka = cs.sunka.Min();
            sir = cs.sir.Min();
        }
        #endregion

       
    }
}
