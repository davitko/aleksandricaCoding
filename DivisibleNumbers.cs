using System;
using System.Collections.Generic;
using System.Numerics;
using Microsoft.VisualBasic.CompilerServices;

namespace InformatikaVezbanje
{

    /**
     * Klassa koja racuna 
     * 
     * 
     * @author aleksandra.davitkovic@gmail.com
     */
    public static class DivisibleNumbers
    {
        /**
         * Funkcija vraca sve deljive brojeve sa brojem 3,
         * od 0 do N
         *
         */

        public static void printDivisibleNumbers()
        { 
            Console.WriteLine("Funkcija vraca sve deljive brojeve sa brojem 3 od 0 do broja N, koji cete uneti.");

            int divider = 3;

            Console.WriteLine("Unesite molim Vas broj N.");
            int N = AleksandraUtils.readInt();

            List<int> divisibleNumbers = getDivisibleNumbers(divider, N);


            Console.WriteLine("Svi deljivi brojevi sa brojem 3, do 0 do " + N);
            foreach (int number in divisibleNumbers)
            {
                Console.WriteLine(number);
            }
        }

        /**
         * Funkcija vraca sve deljive brojeve sa unetim brojem,
         * od 0 do broja N
         *
         *
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
