using System;
using System.Collections.Generic;
using System.Linq;

namespace Fase3_LletresRepetides
{
    class Program
    {
        static void Main(string[] args)
        {
            //create the char LIST
            var nameList = new List<char>();

            //create the dictionary
            var dictionaryWords = new Dictionary<int, char>();


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
            nameList.Add('2');

            try
            {

                // start the bucle
                for (int i = 0; i < nameList.Count; i++)
                {
                    var charLetter = char.ToUpper(nameList[i]); // convert to Upper 
                    dictionaryWords.Add(i, nameList[i]); //add elements to the dictionary

                    if (Char.IsLetter(dictionaryWords[i])) // if is letter
                    {
                        switch (charLetter)
                        {
                            // case is vocal
                            case 'A':
                            case 'E':
                            case 'I':
                            case 'O':
                            case 'U':
                                // get de value of the element by the key (position), get the position
                                Console.WriteLine("Lletra: {0}, Posició: {1}", dictionaryWords[dictionaryWords.Keys.ElementAt(i)],
                                    dictionaryWords.Keys.ElementAt(i) + " es ..... VOCAL");
                                break;
                            // case is consonant
                            default:

                                Console.WriteLine("Lletra: {0}, Posició: {1}", dictionaryWords[dictionaryWords.Keys.ElementAt(i)],
                                dictionaryWords.Keys.ElementAt(i) + " es ..... CONSONANTE");
                                break;
                        }
                    }

                    else // if is a number 
                    {
                        Console.WriteLine("{0}, en la posició: {1}", dictionaryWords[dictionaryWords.Keys.ElementAt(i)],
                             dictionaryWords.Keys.ElementAt(i) + " es ... Els noms de persones no contenen números!");

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
