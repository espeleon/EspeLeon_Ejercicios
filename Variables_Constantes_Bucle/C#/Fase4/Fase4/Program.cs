using System;
using System.Text;

namespace Fase4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            • Creeu una variable on juntareu el nom i els cognoms(tot en una variable) i un altre on juntareu la data de naixement
            separada per “/” (tot en una variable).
            Mostreu per consola les variables del nom complet, la data de naixement i si l’any de naixement es de traspàs o no.
            */

            var sb = new StringBuilder();
            sb.AppendLine("El meu nom es Espe León Hidalgo.");
            sb.AppendLine(@"Vaig nèixer el 14/11/1974.");
            sb.AppendLine("El meu any de naixament NO es de trespàs.");


            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }
    }
}
