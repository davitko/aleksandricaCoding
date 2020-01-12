using System;

namespace InformatikaVezbanje
{
    class Korisnik
    {
        public String ime;
        public String prezime;
        private Int32 visina;
        public Int32 brojGodina;
        public Int32 brojPatika;

        public int Visina { get => visina; set => visina = value; }
    }
}
