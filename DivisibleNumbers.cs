using System;
using System.Collections.Generic;

namespace InformatikaVezbanje
{

    /**
     * Klassa koja racuna deljive brojeve.
     * 
     * 
     * @author aleksandra.davitkovic@gmail.com
     * @date 29.03.2020
     */
    public static class DivisibleNumbers
    {
        /**
         * Funkcija koja stampa na ekranu
         * sve deljive brojeve sa brojem 3,
         * od 0 do unetog broja N.
         * 
         */

        public static void printDivisibleNumbers()
        { 
            Console.WriteLine("Funkcija vraca sve deljive brojeve sa brojem 3 od 0 do broja N.");

            int divider = 3;

            Console.WriteLine("Unesite molim Vas broj N.");
            int N = InputUtils.readInt();

            List<int> divisibleNumbers = getDivisibleNumbers(divider, N);

            Console.WriteLine("Svi deljivi brojevi sa brojem 3, od 0 do " + N);
            foreach (int number in divisibleNumbers)
            {
                Console.WriteLine(number);
            }
        }

        /**
         * Funkcija vraca sve deljive brojeve sa unetim brojem delilac,
         * od 0 do broja N.
         *
         * @param delilac integer vrednost broja sa kojim se deli
         * @param n integer vrednost koja odredjuje gornju granicu pretrage.
         * @return List<int> listu integera svih deljivih brojeva sa unetim brojem delilac,
         * od 0 do broja N.
         */
        private static List<int> getDivisibleNumbers(int delilac, int n)
        {
            List<int> divisibleNumbers = new List<int>();
            for(int broj = 0; broj < n; broj++)
            {
                if (broj % delilac == 0)
                {
                    divisibleNumbers.Add(broj);
                }
            }
            return divisibleNumbers;
        }
    }
}
