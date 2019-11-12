using System;

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

            string[] aBarcelona = new string[6];

            Console.WriteLine("Introduce la primera ciudad");
            sCity1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Introduce la segunda ciudad");
            sCity2 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Introduce la tercera ciudad");
            sCity3 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Introduce la cuarta ciudad");
            sCity4 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Introduce la quinta ciudad");
            sCity5 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Introduce la sexta ciudad");
            sCity6 = Convert.ToString(Console.ReadLine());


            // convert to a string array
            string[] arrayCiutats = new string[6] { sCity1, sCity2, sCity3, sCity4, sCity5, sCity6 };

            Console.WriteLine("\nEl nuevo array ordenado es el siguiente: \n");

            Array.Sort(arrayCiutats); // ordenamos

            foreach (string str in arrayCiutats) // recorremos
            {
                int i = 0;
                var city = str;
                var replacement = city.Replace("a", "4");// reemplazamos
                ArrayCiutatsModificades[i] = replacement; // asignamos valores al nuevo array

                Console.Write(ArrayCiutatsModificades[i] + " "); // mostramos
                i++;
            }


            Console.ReadKey();
        }
    }
}
