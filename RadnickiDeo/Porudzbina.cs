using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadnickiDeo
{
    public class Porudzbina
    {
        public double CenaPorudzbine { get; }

        public int ID { get; }

        public Porudzbina(int id,double cenaPorudzbine)
        {
            ID = id;
            CenaPorudzbine = cenaPorudzbine;
        }

        public override string ToString()
        {
            return $"Porudzbina {ID}: cena {CenaPorudzbine:0.00}";
        }
    }

    

}
