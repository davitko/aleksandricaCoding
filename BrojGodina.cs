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

        public static void koJeStariji()
        {
            Console.WriteLine(" Ime igraca 1 ? ");
            string player1name = Console.ReadLine();
            Console.WriteLine(" Ime igraca 2 ? ");
            string player2name = Console.ReadLine();
            Console.WriteLine(" Koje godine je " + player1name + " rodjen/a ? ");
            int bornYearPlayer1 = AleksandraUtils.readInt();
            int yearsPlayer1 = getYears(bornYearPlayer1);
            Boolean isPlayer1Punoletan = isPunoletan(yearsPlayer1);
            if (isPlayer1Punoletan)
            {
                Console.WriteLine( player1name + " je punoletan. ");
            }
            else
            {
                Console.WriteLine(player1name + " nije punoletan. ");
            }
            Console.WriteLine(" Koje godine je  " + player2name + " rodjen/a ?");
            int bornYearPlayer2 = AleksandraUtils.readInt();
            int yearsPlayer2 = getYears(bornYearPlayer2);
            Boolean isPlayer2Punoletan = isPunoletan(yearsPlayer2);
            if (isPlayer2Punoletan)
            {
                Console.WriteLine(player2name + " je punoletan. ");
            }
            else
            {
                Console.WriteLine(player2name + " nije punoletan. ");
            }

            if (yearsPlayer1 == yearsPlayer2)
            {
                Console.WriteLine(player1name + " i " + player2name + " imaju isti broj godina. ");
                return;
            }

            if (yearsPlayer1 > yearsPlayer2)
            {
                int difference = yearsPlayer1 - yearsPlayer2;
                Console.WriteLine(player1name + " ima vise " + difference + " godina od " + player2name);
            } else
            {
                int difference = yearsPlayer2 - yearsPlayer1;
                Console.WriteLine(player2name + " ima vise " + difference + " godina od " + player1name);
            }
        }

        public static Boolean isPunoletan(int years)
        {
            int punoletstvo = 18;
            if(years >= punoletstvo)
            {
                return true;
            }
             else
            {
                return false;
            }
        }
    }
}
