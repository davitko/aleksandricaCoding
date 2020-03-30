using System;
using System.Collections.Generic;
using System.Text;

namespace InformatikaVezbanje
{
    class ZapreminaBazena
    {
        public static void zapreminaBazena()
        {
            Console.WriteLine("Upisi duzinu bazena ");
            int duzina = InputUtils.readInt();
            Console.WriteLine("Upisi sirinu bazena ");
            int sirina = InputUtils.readInt();
            Console.WriteLine("Upisi dubinu bazena ");
            int dubina = InputUtils.readInt();
            Double zapremina = duzina * sirina * dubina;
            Console.WriteLine("Zapremina bazena je " + zapremina);
        }
        
        
    }
}
