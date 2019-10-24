using System;

namespace Fase2
{
    public class Program
    {

        const int iAny = 1948;
        const int iFrequency = 4;
        const int iBirthday = 1974;


        static void Main(string[] args)
        {

            /*
            Sabent que l’any 1948 es un any de traspàs:
            • Creeu una variable constant amb el valor de l’any(1948).
            • Creeu una variable constant que guardi cada quan hi ha un any de traspàs.
            • Calculeu quants anys de traspàs hi ha entre 1948 i el vostre any de naixement i emmagatzemeu el valor resultant en una variable.
            • Mostreu per pantalla el resultat del càlcul.
            */

            int iResult = (iBirthday-iAny)/iFrequency;
                        
            Console.WriteLine("Nací en " +iBirthday+ " y el nº de años bisiestos entre " + iAny+ " y mi fecha de nacimiento es: " +iResult);
            Console.ReadLine();
        }
    }
}
