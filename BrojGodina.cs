using System;
using System.Collections.Generic;
using System.Text;

namespace InformatikaVezbanje
{
    class BrojGodina
    {
        public static void kolikoGodinaImas()
        {
            String buckastiPozdrav = "Hello Buckasti! ";
            String bornYearQuestion = buckastiPozdrav + "Koje godine si rodjen?";
            Console.WriteLine(bornYearQuestion);

            int bornYear = AleksandraUtils.readInt();
            int years = getYears(bornYear);
            Console.WriteLine("Broj godina je " + years);
        }

        public static int getYears(int bornYear)
        {
            DateTime currentTime = DateTime.Now;
            int currentYear = currentTime.Year;
            int years = currentYear - bornYear;
            return years;
        }
    }
}
