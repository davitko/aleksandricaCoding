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
            double aX = InputUtils.readDouble();
            Console.WriteLine("Unesite kordinate prve tacke po Y osi:");
            double aY = InputUtils.readDouble();

            Console.WriteLine("Unesite kordinate druge tacke po X osi:");
            double bX = InputUtils.readDouble();
            Console.WriteLine("Unesite kordinate druge tacke po Y osi:");
            double bY = InputUtils.readDouble();

            Console.WriteLine("Unesite kordinate treca tacke po X osi:");
            double cX = InputUtils.readDouble();
            Console.WriteLine("Unesite kordinate treca tacke po Y osi:");
            double cY = InputUtils.readDouble();

          

        }
    }
}
