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

            Console.WriteLine("Unesite cenu kupljenog proizvoda u dinarima: ");
            double cena = InputUtils.readDouble();

            Console.WriteLine("Unesite kolicinu kupljenog proizvoda: ");
            double kolicina = InputUtils.readDouble();

            double racun = cena * kolicina;
            Console.WriteLine("Ukupna cena: " + racun + " din.");

            Console.WriteLine("Unesite koliko je novca kupac dao u dinarima: ");
            double datNovac = InputUtils.readDouble();

            if(datNovac > racun)
            {
                double kusur = datNovac - racun;
                Console.WriteLine("Kusur za vracanje je: " + kusur + " din.");
            }

        }
    }
}
