using System;

namespace InformatikaVezbanje
{
    /**
     * InputUtils je klasa koja obezbedjuje elementarne funkcije za unos podataka
     * u sistem kroz konzolu.
     *
     *
     *  @author aleksandra.davitkovic@gmail.com
     *  @date 29.03.2020
     */

    class InputUtils
    {
        /**
         * Ucitavanje integer vrednosti sa konzole.
         *
         * @throws FormatException ukoliko uneti broj nije integer.
         */
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
                throw new FormatException("Uneti broj nije ceo broj (int)! Molimo proverite Vas unos!" + ex);
            }
        }

        /**
         * Ucitavanje double vrednosti sa konzole.
         *
         * @throws FormatException ukoliko uneti broj nije double.
         */
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
                throw new FormatException("Uneti broj nije broj dvostruke preciznosti (double)! Molimo proverite Vas unos!" + ex);
            }

        }
    }
}
