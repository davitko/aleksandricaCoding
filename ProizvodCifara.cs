using System;
using System.Collections.Generic;
using System.Text;

namespace InformatikaVezbanje
{
    class ProizvodCifara
    {
        public static void izracunajProizvod()
        {
            Console.WriteLine("Izracunavanje proizvoda cifara cetvorocifrenog broja");
            Console.WriteLine("***********************************************");

            Console.WriteLine("Unesite cetvorocifreni broj");

            int broj = InputUtils.readInt();   // 4568

            int cifra1 = broj / 1000;       // 4,568 -> 4
            // int cifra2 = (broj / 100) % 10; // 45,68 -> 45 -> 5
            int cifra2 = (broj % 1000) / 100;    // 568 -> 5,68 -> 5
            //int cifra3 = (broj % 100) / 10; // 68 -> 6,8 -> 6
            int cifra3 = (broj / 10) % 10; // 456,8 _> 456 -> 6
            int cifra4 = broj % 10;         // 8
            
            double proizvod = cifra1 * cifra2 * cifra3 * cifra4;

            Console.WriteLine("proizvod je: " + proizvod);
        }

        /**
         * "4568" -> "4", "5", "6", "8" -> 4 * 5 * 6 * 8
               "4568" -> 4568 _> 4 5 6 8

        // */
        //private static List<int> getNumber()
        //{
        //    Console.WriteLine("Unesite cetvorocifreni broj");
        //    String input = Console.ReadLine();      // "4568"


        //    List<int> cifre = new List<int>();
        //    for (int i = 0; i < input.Length; i++)
        //    {
        //        int.Parse(input[i]);
        //        cifre.Add();
        //    }

        //    return cifre;
        ////}

        //private static List<int> getNumber()
        //{
            
        //    //List<int> listOfInts = new List<int>();
        //    //while (broj > 0)
        //    //{
        //    //    listOfInts.Add(broj % 10);
        //    //    broj = broj / 10;
        //    //}
        //    //listOfInts.Reverse();
        //    //return listOfInts;
        //}
    }
}
