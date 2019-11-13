using System;

namespace Ciutats_Fase3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
           FASE 3 (3 punts)
            • Cambieu les vocals “a” dels noms de les ciutats per el numero 4 i guardeu els noms modificats
              en un nou array(ArrayCiutatsModificades). (2 punts)
            • Mostreu per consola l’array modificat i ordenat per ordre alfabetic. (1 punt)
           */

            string sCity1 = "";
            string sCity2 = "";
            string sCity3 = "";
            string sCity4 = "";
            string sCity5 = "";
            string sCity6 = "";

            string[] ArrayCiutatsModificades = new string[6];

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
