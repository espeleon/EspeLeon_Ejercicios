using System;

namespace Ciutats_Fase2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            FASE 2 (2 punts)
            • Un cop tenim els noms de les ciutats guardats en variables haurem de pasar l’informacio 
            a un array (arrayCiutats). (1 punt)
            • Quan tinguem l’array ple, haurem de mostrar per consola el nom de les ciutats ordenadas
            per ordre alfabetic. (1 punt) 
            */

            string sCity1 = "";
            string sCity2 = "";
            string sCity3 = "";
            string sCity4 = "";
            string sCity5 = "";
            string sCity6 = "";

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
            string[] arrayCiutats = new string[6] { sCity1, sCity2, sCity3, sCity4, sCity5, sCity6};

            Console.WriteLine("\nLas ciudades ordenadas alfabéticamente son las siguientes: \n");

            Array.Sort(arrayCiutats); // ordenamos
        
            foreach (string str in arrayCiutats) // recorremos
            {
                Console.Write(str + " ");
            }


            Console.ReadKey();
        }
    }
}
