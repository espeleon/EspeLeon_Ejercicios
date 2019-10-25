using System;

namespace LletresRepetides
{
    class Program
    {
        /*FASE 1
        Crea una array de caracteres(char[]) amb el teu nom on cada posició correspongui a una lletra.
        Fes un bucle que recorri aquest array ii mostri per consola cadascuna de les lletres.
        */

        static void Main(string[] args)
        {
            //create the char array
           char[] nameArray = new char[9]{ 'E', 's', 'p', 'e', 'r', 'a', 'n', 'z', 'a' };


            for (int i=0; i< nameArray.Length; i++)
            {

                Console.WriteLine(Char.ToUpper(nameArray[i]));
            }

            Console.ReadLine();

            
        }
    }
}
