using System;

namespace Ciutats_Fase1_Bucle
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              FASE 1 (2 punts)
             • Crea sis variables tipu string buides. (0,5 punts)
             • Demana per consola que s’introdueixin els noms. (0,5 punts)
             • Introdueix els següents noms de ciutats (Barcelona, Madrid, Valencia, Malaga, Cadis, Santander) per teclat. (0,5 punts)
             • Mostra per consola el nom de les 6 ciutats. (0,5 punts)
             */

            string[] aCiudades = new string[6];

            for (int i=0; i<6; i++)
            {
                Console.WriteLine("Introduce la ciudad número: " + (i + 1));
                aCiudades[i] = Convert.ToString(Console.ReadLine());             
            }

            Console.WriteLine("\nLas ciudades introducidas son: ");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("\n-" + aCiudades[i]);
            }



            Console.ReadKey();
        }
    }
}
