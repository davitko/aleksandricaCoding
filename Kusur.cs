using System;
namespace InformatikaVezbanje
{
    /**
     * 4.   Napisati program koji pomaže kasirki da obracuna kusur
            koji treba da vrati kupcu. Za unetu cenu artikla, kolicinu artikla i iznos koji je
            kupac dao, program treba da ispiše vrednost kusura. Napomena: Pretpostaviti
            da su cene svih artikala pozitivni celi brojevi, kao i da su unete vrednosti ispravne,
            tj. da se može vratiti kusur.
	            Test Primer1:
	            Unesite cenu, kolicinu i iznos: 132 2 500
	            Kusur je 236 dinara.

         @author: aleksandra.davitkovic@gmail.com
    */

    public class Kusur
    {
        public static void izracunavanjeKusura()
        {
            Console.WriteLine("Izracunavanje Kusura, pravda za Kasirku!");
            Console.WriteLine("***********************************************");

            Console.WriteLine("Unesite cenu kupljenog proizvoda: ");
            double cena = AleksandraUtils.readDouble();

            Console.WriteLine("Unesite kolicinu kupljenog proizvoda: ");
            double kolicina = AleksandraUtils.readDouble();

            double ukupnaCena = cena * kolicina;
            Console.WriteLine("Ukupna cena: " + ukupnaCena);

            Console.WriteLine("Unesite koliko je novca kupac dao: ");
            double datNovac = AleksandraUtils.readDouble();

            if(datNovac > ukupnaCena)
            {
                double kusur = ukupnaCena - datNovac;
                Console.WriteLine("Kusur za vracanje je: " + kusur);
            }

        }
    }
}
