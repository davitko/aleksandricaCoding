using System;

namespace InformatikaVezbanje
{

    /**
     * 1.   Napisati na jeziku C# program koji procita dva cela broja s glavnog ulaza racunara, izracuna njihov zbir i
            ispiše rezultat na glavnom izlazu racunara.

        @author: aleksandra.davitkovic@gmail.com
    */

    public class Zbir2Broja
    {
        public static void izracunavanjeZbira()
        {
            Console.WriteLine("Izracunavanje zbira 2 broja.");
            Console.WriteLine("***********************************************");

            Console.WriteLine("Molimo unesite prvi broj:");
            int prviBroj = AleksandraUtils.readInt();

            Console.WriteLine("Molimo unesite prvi broj:");
            int drugiBroj = AleksandraUtils.readInt();

            int zbir = prviBroj + drugiBroj;

            Console.WriteLine("Zbir uneta 2 broja (" + prviBroj + " " + drugiBroj + ") je: " + zbir);
        }
    }
}
