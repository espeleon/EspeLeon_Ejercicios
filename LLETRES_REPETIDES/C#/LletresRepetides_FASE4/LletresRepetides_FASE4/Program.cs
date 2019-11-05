using System;
using System.Collections.Generic;

namespace LletresRepetides_FASE4
{
    class Program
    {
        /*
        FASE 4
        Crea una altra llista amb el teu cognom on cada posició correspongui a una lletra.
        Fusiona les dues llistes en una sola.A més, afegeix una posició amb un espai buit entre la primera i la
        segona.És a dir, partim de la llista name i surname i al acabar l’execució només tindrem una que es dirà
        fullName.
        FullName: [‘N’, ‘A’, ‘M’, ‘E’, ‘ ‘, ‘S’, ‘U’, ‘R‘, ‘N’, ‘A’, ‘M’, ‘E’]
        */

        static void Main(string[] args)
        {
            //create the char list for the name
            var nameList = new List<char>();

            //add elements to the list
            nameList.Add('E');
            nameList.Add('s');
            nameList.Add('p');
            nameList.Add('e');
            nameList.Add('r');
            nameList.Add('a');
            nameList.Add('n');
            nameList.Add('z');
            nameList.Add('a');

            // create the second char list for the surname

            var surnameList = new List<char>();

            // add elements to the list
            surnameList.Add('L');
            surnameList.Add('e');
            surnameList.Add('o');
            surnameList.Add('n');

            // add a white space in the first list
            nameList.Add(' ');

            // join the two list in only one

            nameList.AddRange(surnameList);

            try
            {

                // start the bucle
                for (int i = 0; i < nameList.Count; i++)
                {
                    var charLetter = char.ToUpper(nameList[i]); // convert to Upper all
                    Console.WriteLine(charLetter);
                    
                }

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido el siguiente error: " + ex);

            }



        }
    }
}
