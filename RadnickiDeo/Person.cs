using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadnickiDeo
{
    public class Person
    {
        public String Ime { get; }
        public String Prezime { get; }

        public String Adresa { get; }

        public String Telefon { get; }

        public String BrojRacuna { get; set; }

        public double UkupnaCena { get; set; }
        public Person(String ime, String prezime, String adresa, String telefon, String brRacuna)
        {
            Ime = ime;
            Prezime = prezime;
            Adresa = adresa;
            Telefon = telefon;
            BrojRacuna = brRacuna;
        }

    }
}
