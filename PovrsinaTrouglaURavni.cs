using System;
namespace InformatikaVezbanje
{
    public class PovrsinaTrouglaURavni
    {
        public static void izracunajPovrsinu()
        {
            Console.WriteLine("Izracuvananje Povrsine Trougla u Ravni!");
            Console.WriteLine("***********************************************");

            Console.WriteLine("Unesite kordinate prve tacke po X osi:");
            double aX = AleksandraUtils.readDouble();
            Console.WriteLine("Unesite kordinate prve tacke po Y osi:");
            double aY = AleksandraUtils.readDouble();

            Console.WriteLine("Unesite kordinate druge tacke po X osi:");
            double bX = AleksandraUtils.readDouble();
            Console.WriteLine("Unesite kordinate druge tacke po Y osi:");
            double bY = AleksandraUtils.readDouble();

            Console.WriteLine("Unesite kordinate treca tacke po X osi:");
            double cX = AleksandraUtils.readDouble();
            Console.WriteLine("Unesite kordinate treca tacke po Y osi:");
            double cY = AleksandraUtils.readDouble();

          

        }
    }
}
