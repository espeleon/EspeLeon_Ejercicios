using System;
using System.Linq;

namespace Ciutats_Fase4
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             FASE 4 (3 punts)
            • Creeu un nou array per cada una de les ciutats que tenim. La mida dels nous arrays sera 
            la llargada de cada string ( string nomCiutat.Length). (0,5 punts)
            • Ompliu els nous arrays lletra per lletra.(2 punts)
            • Mostreu per consola els nous arrays amb els noms invertits (Ex: Barcelona - anolecraB). (0,5 punts)
            */
            
            string sCity1 = "Barcelona";
            string sCity2 = "Madrid";
            string sCity3 = "Valencia";
            string sCity4 = "Malaga";
            string sCity5 = "Cadis";
            string sCity6 = "Santander";

            // create the arrays
            char[] arrayCity1 = new char[sCity1.Length];
            char[] arrayCity2 = new char[sCity2.Length];
            char[] arrayCity3 = new char[sCity3.Length];
            char[] arrayCity4 = new char[sCity4.Length];
            char[] arrayCity5 = new char[sCity5.Length];
            char[] arrayCity6 = new char[sCity6.Length];

            // fill the arrays and reverse letters

            arrayCity1 = (sCity1.Reverse()).ToArray();
            arrayCity2 = (sCity2.Reverse()).ToArray();
            arrayCity3 = (sCity3.Reverse()).ToArray();
            arrayCity4 = (sCity4.Reverse()).ToArray();
            arrayCity5 = (sCity5.Reverse()).ToArray();
            arrayCity6 = (sCity6.Reverse()).ToArray();

            // call the function to print the result
            PrintArray(arrayCity1);
            PrintArray(arrayCity2);
            PrintArray(arrayCity3);
            PrintArray(arrayCity4);
            PrintArray(arrayCity5);
            PrintArray(arrayCity6);
            
            Console.ReadKey();
            
        }

        // function to print the arrays
        static void PrintArray(char[] Ciudades)
        {
            foreach (char ch in Ciudades)
            {
               Console.WriteLine(ch);
            }

            Console.WriteLine("----------");
        }

    }
}
