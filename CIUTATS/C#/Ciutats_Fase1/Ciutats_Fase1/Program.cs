using System;

namespace Ciutats_Fase1
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

            Console.WriteLine("Los nombres de las ciudades son: \n- "+sCity1+ "\n- " +sCity2 
                +"\n- "+sCity3+ "\n- " +sCity4 + "\n- "+sCity5+ "\n- " +sCity6);





            Console.ReadKey();
        }
    }
}
