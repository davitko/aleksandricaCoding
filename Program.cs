using System;

namespace InformatikaVezbanje
{
    class Program
    {
         static void Main(string[] args)
        {
            BrojGodina.kolikoGodinaImas();
            //ucitajBrojIIspisiGa();
            //ZapreminaBazena.zapreminaBazena();
            //ObimIPovrsinaKruga.izracunajObimiPovrsinuKruga();
            //UnosKorisnika.unosNovogKorisnika();
            //BrojGodina.koJeStariji();
            zbir2Broja.izracunavanjeZbira();
        }

        private static void ucitajBrojIIspisiGa()
        {
            String buckastiPozdrav = "Hello Buckasti! ";
            String upisiBrojPoruka = buckastiPozdrav + "Upisi broj.";
            Console.WriteLine(upisiBrojPoruka);

            int broj = AleksandraUtils.readInt();
            String poruka = "Unet broj je ";
            Console.WriteLine(poruka + broj);
        }
        
    }
}
