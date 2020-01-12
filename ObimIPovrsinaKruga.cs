using System;

namespace InformatikaVezbanje
{
    /**
     * 2. Napisati na jeziku C# program koji procita poluprecnik kruga s glavnog
     * ulaza racunara i ispiše obim i površinu tog kruga na glavnom izlazu racunara.
     *
     * @author: aleksandra.davitkovic@gmail.com
     */
    class ObimIPovrsinaKruga
    {
        public  static void izracunajObimiPovrsinuKruga()
        {
            Console.WriteLine("Izracunavanje Obima i povrsine kruga");
            Console.WriteLine("***********************************************");

            Console.WriteLine("Unesite poluprecnik kruga u cm: ");
            double r = AleksandraUtils.readDouble();

            double obim = getObimKruga(r);
            Console.WriteLine("Obim kruga je " + obim + " cm.");

            double povrsina = getPovrsinaKruga(r);
            Console.WriteLine("Povrsina kruga je " + povrsina + " cm2.");
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
