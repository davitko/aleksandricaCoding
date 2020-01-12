using System;
using System.Collections.Generic;
using System.Text;

namespace InformatikaVezbanje
{
    class WriteExamples
    {
        public void writeExamples()
        {
            // Mozemo samo da upisem tekst izmedju navodnika:
            Console.Write("Hi Aleksandrice!"); // Hi Aleksandrice!

            // Mozemo i da ubacimo tekst u promenljivu tipa string, i onda ce Console.Write citati tekst iz fiokice howAreYou
            String howAreYou = "Kako si?";
            Console.Write(howAreYou); // Hi Aleksandrice!Kako si? // namerno nemam razmak

            // Mozemo da spojimo vrednost iz promenljive didYouEat sa tekstom izmedju navodnika
            String didYouEat = " Da li si jela?! ";
            Console.Write(didYouEat + "Ako nisi da ti donesem nesto?"); // Hi Aleksandrice!Kako si? Da li si jela?! Ako nisi da ti donesem nesto?

            // A ako nas mrzi da spajamo tekst i promenljive sa znakom plus (+) onda mozemo da ubacujemo {0}, {1}, {2}... na mesta gde bi smo stavili promenljive
            // i onda posle teksta stavimo zarez, i iz prva promeljiva posle zareza ce da se ucita vredsnot i stavi umesto {0},
            // iz druge promeljive umesto {1} i tako dalje...
            int bornYear = 2002;
            int nowYears = 17;
            Console.Write(" Aleksandrica je rodjena {0} godine i sada ima {1} godina. ", bornYear, nowYears); // Hi Aleksandrice!Kako si? Da li si jela?! Ako nisi da ti donesem nesto? Aleksandrica je rodjena 2002 godine i sada ima 17 godina.

            // caka je da kad koristimo Console.Write sveki put kad ga pozovemo on samo dopise u isti red, tako da ako bi njega koristili
            // bez da mu eksplicitno ne kazemo da predje u novi red, on bi tako i knjigu ispisao u jedan red... :)

        }

        public void writelnExamples()
        {
            // Mozemo samo da upisem tekst izmedju navodnika:
            Console.WriteLine("Hi Aleksandrice!");
            // Hi Aleksandrice!

            // Mozemo i da ubacimo tekst u promenljivu tipa string, i onda ce Console.Write citati tekst iz fiokice howAreYou
            String howAreYou = "Kako si?";
            Console.WriteLine(howAreYou);
            // Hi Aleksandrice!
            //Kako si?

            // Mozemo da spojimo vrednost iz promenljive didYouEat sa tekstom izmedju navodnika
            String didYouEat = "Da li si jela?! ";
            Console.WriteLine(didYouEat + "Ako nisi da ti donesem nesto?");
            // Hi Aleksandrice!
            // Kako si?
            // Da li si jela?! Ako nisi da ti donesem nesto?

            // A ako nas mrzi da spajamo tekst i promenljive sa znakom plus (+) onda mozemo da ubacujemo {0}, {1}, {2}... na mesta gde bi smo stavili promenljive
            // i onda posle teksta stavimo zarez, i iz prva promeljiva posle zareza ce da se ucita vredsnot i stavi umesto {0},
            // iz druge promeljive umesto {1} i tako dalje...
            int bornYear = 2002;
            int nowYears = 17;
            Console.WriteLine(" Aleksandrica je rodjena {0} godine i sada ima {1} godina. ", bornYear, nowYears);
            // Hi Aleksandrice!
            // Kako si?
            // Da li si jela?! Ako nisi da ti donesem nesto?
            // Aleksandrica je rodjena 2002 godine i sada ima 17 godina.

            // Caka je da WriteLine ispise sta mu je zadato i odmah predje u novi red,
            // tako da sledeci put kad se pozove on upisuje u novi red.
            // znaci kompjuteru mora da se kaze eksplicitno kada da pravi razmake, u kom momemtu,
            // ako mu se ne kaze, on ce si tera u jednu linu sve :)
        }
    }
}