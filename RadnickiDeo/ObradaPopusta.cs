using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadnickiDeo
{
    public static class ObradaPopusta
    {
        public static double popustNaKolicinuPizze(int y)
        {
            double popust = 0;
            switch(y)
            {
                case 2:
                    popust=20;
                    break;
                case 5:
                    popust = 50;
                    break;
                case 10:
                    popust = 300;
                    break;
                default:
                    popust = 0;
                    break;

            }
            return popust;
        }

        public static double popustNaKolicinuPica(int y)
        {
            double popust = 0;
            switch (y)
            {
                case 2:
                    popust = 10;
                    break;
                case 5:
                    popust = 40;
                    break;
                case 10:
                    popust = 200;
                    break;
                default:
                    popust = 0;
                    break;

            }
            return popust;
        }

        public static double ukupanPopust(double x,double y)
        {
            return x + y;

        }
    }
}
