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
            //int broj = Int32.Parse(input);
            int broj = Convert.ToInt32(input);
            return broj;
        }

        public static double readDouble()
        {
            String input = Console.ReadLine();
            double broj = Convert.ToDouble(input);
            return broj;
        }
    }
}
