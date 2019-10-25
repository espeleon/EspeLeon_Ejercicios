using System;
using System.Collections.Generic;

namespace LletresRepetides_FASE2
{
    class Program
    {

            /*
             * FASE 2
            Canvia el array per una llista(List<char>)
            Al bucle, si la lletra és una vocal imprimeix a la consola: ‘VOCAL’. Sinó, 
            imprimeix: ‘CONSONTANT’.
            Si trobes un numero, mostra per pantalla: ‘Els noms de persones no contenen números!’.
            */
        static void Main(string[] args)
        {

            //create the char LIST
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
            nameList.Add('9');

            try
            {
               
                // start the bucle
                for (int i = 0; i < nameList.Count; i++)
                {
                    

                    if (char.IsLetter(nameList[i])) // if is letter
                    {
                        var charLetter= char.ToUpper(nameList[i]); // convert to Upper all

                        switch (charLetter)
                        {
                            // case is vocal
                            case 'A':
                            case 'E':
                            case 'I':
                            case 'O':
                            case 'U':
                                Console.WriteLine(charLetter + " es ..... VOCAL");
                                break;
                            // case is consonant
                            default:
                                Console.WriteLine(charLetter + " es ..... CONSONANTE");
                                break;
                        }
                    }

                    else // if is a number 
                    {
                        Console.WriteLine( nameList[i]+ " es ... Els noms de persones no contenen números!");
                 
                    }

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
