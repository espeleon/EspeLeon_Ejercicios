using System;

namespace Fase3
{
    public class Program
    {

        // var for the frequency

        const int iFrequency = 4;

        static void Main(string[] args)
        {
            /*
           • Partint de l’any 1948 heu de fer un bucle for i mostrar els anys de traspàs fins arriba al vostre any de naixement. (0, 75 punts)
           ATENCIO! Haureu de canviar el tipus de variable de l’any 1948 per poder modificar - la.
           • Creeu una variable bool que sera certa si l’any de naixement és de traspàs o falsa si no ho és.(0, 75 punts)
           • En cas de que la variable bool sigui certa, heu de mostrar per consola una frase on ho digui, en cas de ser falsa mostrareu
           la frase pertinent.Creeu dues variables string per guardar les frases. (1, 5 punts)
           */

            // vars

            bool bBisiesto = true;
            int iAny = 1948;
            int iBirthday = 1974;
            int iResult = 0;
            string sTrue = "Mi año de nacimiento es bisiesto";
            string sFalse = "Mi año de nacimiento NO es bisiesto";

            
            for ( var i= iAny; i <= iBirthday; i= i+iFrequency)
            {
                Console.WriteLine("Este año es bisiesto: " + i);

            }

            if ( iBirthday % iFrequency == 0)
            {
                bBisiesto = true;
                Console.WriteLine(sTrue);
                Console.ReadLine();
                
            }
            else
            {
                bBisiesto = false;
                Console.WriteLine(sFalse);
                Console.ReadLine();
            }



        }
    }
}
