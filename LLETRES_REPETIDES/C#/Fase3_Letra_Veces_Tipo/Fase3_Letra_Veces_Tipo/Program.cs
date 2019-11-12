using System;
using System.Collections.Generic;
using System.Linq;

namespace Fase3_Letra_Veces_Tipo
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<char, int>();

            var characters = "Esperanza".ToCharArray();

            
            for (var i = 0; i < characters.Length; i++)
            {
                var currentCharacter = characters[i];
                currentCharacter = char.ToUpper(currentCharacter);     
               
                if (!dict.ContainsKey(currentCharacter))
                    dict.Add(currentCharacter, 1);
                else
                    dict[currentCharacter] += 1;
            }
         
            foreach (var item in dict)
            {
                Console.WriteLine($"La letra: {item.Key} Aparece: {item.Value} veces ");
            }

            Console.ReadKey();
        }
    }
}
