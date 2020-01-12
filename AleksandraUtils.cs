using System;
using System.Collections.Generic;
using System.Text;

namespace InformatikaVezbanje
{
    class AleksandraUtils
    {
        public static int readInt()
        {
            String input = Console.ReadLine();
           
            try
            {
                int broj = Convert.ToInt32(input);
                return broj;
            }
            catch (FormatException ex)
            {
                throw new FormatException("Uneseni broj nije ceo broj (int)! Molimo proverite Vas unos!" + input);
            }
        }

        public static double readDouble()
        {
            String input = Console.ReadLine();

            try
            {
                double broj = Convert.ToDouble(input);
                return broj;
            }
            catch (FormatException ex)
            {
                throw new FormatException("Uneseni broj nije broj dvostruke preciznosti (double)! Molimo proverite Vas unos!" + input);
            }

        }
    }
}
