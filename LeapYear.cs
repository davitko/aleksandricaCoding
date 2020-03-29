using System;
namespace InformatikaVezbanje
{
    /**
     * Klassa Racuna Presputne godine
     *
     */
    public static class LeapYear
    {

        public static void printLeapYears()
        {
            Console.WriteLine("Funkcija proverava da li je uneta godina prestupna ili nije.");
            Console.WriteLine("Unesite molim Vas godinu za proveru, bez tacke, samo broj.");

            int year = AleksandraUtils.readInt();

            //bool isLeapYear = DateTime.IsLeapYear(year);
            bool isLeapYear = IsLeapYear(year);

            if (isLeapYear)
            {
                Console.WriteLine("Godina " + year + " je prestupna godina!");
            }
            else
            {
                Console.WriteLine("Godina " + year + " nije prestupna godina!");
            }
        }

        /**
         * Funkcija vraca true ili false, u zavisnosti od toga
         * da li je godina prestupna ili ne.
         *
         * @return boolean vrednost, u zavisnosti od toga
         * da li je godina prestupna ili ne.
         */
        private static bool IsLeapYear(int year)
        {
            /*
                1.If the year is evenly divisible by 4, go to step 2. Otherwise, go to step 5.
                2.If the year is evenly divisible by 100, go to step 3. Otherwise, go to step 4.
                3.If the year is evenly divisible by 400, go to step 4. Otherwise, go to step 5.
                4.The year is a leap year (it has 366 days).
                5.The year is not a leap year (it has 365 days).
            */

      

            // 1.
            if (year % 4 == 0)
            {
                // 2.
                if(year % 100 == 0)
                {
                    // 3.
                    if(year % 400 == 0)
                    {
                        return true;
                    } else
                    {
                        return false;
                    }
                } else
                {
                    return true;
                }
            } else
            {
                return false;
            }

       
        }
    }
}
