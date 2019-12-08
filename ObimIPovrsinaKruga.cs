using System;
using System.Collections.Generic;
using System.Text;

namespace InformatikaVezbanje
{
    class ObimIPovrsinaKruga
    {
        public  static void izracunajObimiPovrsinuKruga()
        {
            double r = AleksandraUtils.readDouble();
            double obim = getObimKruga(r);
            Console.WriteLine("Obim kruga je " + obim);
            double povrsina = getPovrsinaKruga(r);
            Console.WriteLine("Povrsina kruga je " + povrsina);
        }

        private static double getObimKruga(double r)
        {
            double obim = 2 * r * Math.PI;
            return obim;
        }

        private static double getPovrsinaKruga(double r)
        {
            double povrsina = r * r * Math.PI;
            return povrsina;
        }
    }
}
