using System;
using System.Text;

namespace Fase1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             • Crea tres variables string e inicialitzales amb les dades pertinents (nom, cognom1, cognom2).
             • Crea tres variables int e inicialitzales amb les dades pertinents (dia, mes, any).
             • Mostra per pantalla les variables string concatenant-les en aquest ordre (cognom1 + cognom2, + nom).
             • Mostra per pantalla les variables int concatenant-les amb “/” entre cada una d’elles.
             */

            string sNom = "Espe";
            string sCognom1 = "León";
            string sCognom2 = "Hidalgo";
            int iDia = 22;
            int iMes = 10;
            int iAny = 2019;

            // string: another way of do it 

            var sb = new StringBuilder();
            sb.Append ( "Espe ");
            sb.Append ( "León ") ;
            sb.Append("Hidalgo");


            Console.WriteLine("Mi nombre es: "+sNom + " " + sCognom1+ " " + sCognom2);
            Console.WriteLine(@"Y hoy es día: " + iDia + "/" + iMes + "/" + iAny);

            // result with StringBuilder
            Console.WriteLine("Este es con el StringBuilder: " +sb.ToString());

            Console.ReadLine();
        }
    }
}
