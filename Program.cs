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
            Zbir2Broja.izracunavanjeZbira();
        }

        private static void ucitajBrojIIspisiGa() 
        {
            String Pozdrav = "Hello! ";
            String upisiBrojPoruka = Pozdrav + "Upisi broj.";
            Console.WriteLine(upisiBrojPoruka);

            int broj = AleksandraUtils.readInt();
            String poruka = "Unet broj je ";
            Console.WriteLine(poruka + broj);
             if (broj > 20)
            {
                Console.WriteLine("broj je veci od 20");
            }
            else if (broj > 12)
            {
                Console.WriteLine("broj je veci od 12, ali nije veci od 20");
            }
            else if (broj > 0)
            {
                Console.WriteLine("broj je veci od 0, ali nije veci od 12");
            }
            else
            {
                Console.WriteLine("broj je manji ili jednak 0");
            }
        }
    }

}
        
    

