﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InformatikaVezbanje
{
    class UnosKorisnika
    {
        public static void unosNovogKorisnika()
        {
            Console.WriteLine("Dobar dan! Molimo unesite Vase podatke.");
            Console.WriteLine(" Molimo unesite Vase ime.");
            String ime = Console.ReadLine();
            Console.WriteLine(" Molimo unesite Vase prezime.");
            String prezime = Console.ReadLine();
            Console.WriteLine(" Molimo unesite Vasu godinu rodjenja.");
            int godinaRodjenja = AleksandraUtils.readInt();
            int brojGodina = BrojGodina.getYears(godinaRodjenja);
            Console.WriteLine(" Molimo unesite Vas broj patika.");
            int brojPatika = AleksandraUtils.readInt();

            Korisnik aleksandrica = new Korisnik();
            aleksandrica.ime = ime;
            aleksandrica.prezime = prezime;
            aleksandrica.brojGodina = Convert.ToInt32(brojGodina);
            aleksandrica.brojPatika = Convert.ToInt32(brojPatika);
            Console.WriteLine(aleksandrica.ToString());




        }
    }
}
