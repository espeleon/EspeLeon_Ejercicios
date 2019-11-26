using System;
using System.Collections.Generic;


namespace Restaurant_Fase1_2_3
{
    class Program
    {

        static string elegido = "";
        static string[] plats = new string[5];
        static float[] preu = new float[5];
        static List<string> platsList = new List<string>();
        static int numPlatos = 0;
        static List<float> preuList = new List<float>();
        static int posi;
        static float preuTotal= 0.00f;
        static string validaFloat = "";
        static float isFloat = 0.00f;

        static void Main(string[] args)
        {
            /*
            FASE 1 (2 punts)
            • Creeu una variable int per cada un dels bitllets que existeixen des de 5€ a 500€, 
            haureu de crear un altre variable per guardar el preu total del menjar. (1 punt)
            • Creeu dos arrays, un on guardarem el menú (5 plats) i un altre on guardarem el preu de cada 
             plat. (1 punt)             
            */


            int iCinco = 0;
            int iDiez = 0;
            int iVeinte = 0;
            int iCincuenta = 0;
            int iCient = 0;
            int iDoscientos = 0;
            int iQuinientos = 0;
            float fPreuTotal = 0.00f;
                        
            int iAnswer = 0;


            /*FASE 2 (3 punts)
            • Amb un bucle for haurem d’omplir els dos arrays anteriorment creats. Afegirem el nom del plat 
            i després el preu. (1 punt)
            • Un cop plens els dos arrays haurem de mostrar-los i preguntar que es vol per menjar,
            guardarem la informació en una List fent servir un bucle while. (1 punt)
            • Haurem de preguntar si es vol seguir demanant menjar. Podeu fer servir el sistema (1:Si / 0:No), 
            per tant haureu de crear un altre variable int per guardar la informació. (1 punt)*/

            try
            {
                
                // ask and add to arrays
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Introduce un plato: ");
                    plats[i] = Console.ReadLine().ToString();
                    Console.WriteLine("Ahora introduce el precio: ");

                    // validate the correct format of the float
                    validaFloat = Console.ReadLine();
                    preu[i]= VerificaPrecio(validaFloat);                    
                                   
                }

                // show the array of plats
                Console.WriteLine("Hoy tenemos para comer ...\n");
                foreach (string str in plats) // recorremos
                {
                    Console.Write("-" +str + ".\n");
                }

                // ask how many dishes
                Console.WriteLine("Cuántos platos vas a pedir");
                numPlatos = int.Parse(Console.ReadLine());

                // execute function
                IntroPlatos(numPlatos);
            
                // ask if want to demand more
                Console.WriteLine("Desea introducir algún plato más? Pulsa 1 para SÍ, pulsa 0 para NO");
                iAnswer = int.Parse(Console.ReadLine());

                // if the answer is yes
                if (iAnswer == 1)
                {
                    Console.WriteLine("Cuántos platos más vas a pedir");
                    numPlatos = int.Parse(Console.ReadLine());
                    Console.WriteLine("Te recuerdo la lista de platos:" );
                    foreach (string str in plats) // recorremos
                    {
                        Console.Write("-" + str + ".\n");
                    }
                    IntroPlatos(numPlatos);
                    PrintPrices(); 
                   // Console.WriteLine("Bon profit y vigila con la dieta !!!");
                }
                else // if the answer is no, print
                {
                    PrintPrices(); 
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Ups !! Tenemos un error: " + ex.ToString());
            }

            Console.ReadKey();
        }

        // function to add the dishes and price that demand
        public static void IntroPlatos(int numPlatitos)
        {
            int j = 0;

            while (j < numPlatos)
            {
                Console.WriteLine("Introduce el plato nº " +(j+1));
                elegido = Console.ReadLine().ToString();
                if (Array.Exists(plats, element => element == elegido))
                {
                    posi = Array.IndexOf(plats, elegido.ToString()) ;
                    platsList.Add(elegido);
                    preuList.Add(preu[posi]);                    
                    preuTotal = preuTotal + preu[posi];
                }
                else
                {
                    Console.WriteLine("El plato elegido no aparece en la lista, inténtalo de nuevo");
                    ReIntroPlatos(j);
                }
                j++;
            }
        }

        // function to re-add dishes and price that demand
        public static void ReIntroPlatos(int intent)
        {
              Console.WriteLine("Introduce el plato  nº " + (intent + 1) );
                elegido = Console.ReadLine().ToString();
                if (Array.Exists(plats, element => element == elegido))
                {
                posi = Array.IndexOf(plats, elegido.ToString());
                platsList.Add(elegido); // add the dishes to the list
                preuList.Add(preu[posi]); // add the prices to the list
                preuTotal = preuTotal + preu[posi]; // we accumulate prices
            }
                else
                {
                    Console.WriteLine("El plato elegido no aparece en la lista, fíjate más !!!");
                }                            
        }

        // function to print final list and prices
        public static void PrintPrices()
        {
            Console.WriteLine("Has pedido todos estos platos: ");
            foreach (string str in platsList) // recorremos
            {
                Console.Write("-" + str + ".\n");
            }
            Console.WriteLine("Los precios de los platos pedidos son: ");
            foreach (float str in preuList) // recorremos
            {
                Console.Write("*" + str + ".\n");
            }

            Console.WriteLine("La comilona de hoy te sale por un total de .... " + preuTotal+ " euros");
        }
       
        // function to verify that the price is a float
        public static float VerificaPrecio(string precio)
        {
            var precioOk = 0.00f;         

            if (float.TryParse(validaFloat, out isFloat))
            {
                if (validaFloat.Contains("."))
                {
                    precioOk = float.Parse(validaFloat.Replace(".", ","));
                }

                else
                {
                    precioOk = float.Parse(validaFloat);
                }
            }
            else
            {
                Console.WriteLine("El formato introducido no es correcto, debe ser un importe válido");
                Console.WriteLine("Vuelve a introducir un precio: ");

                // validate the correct format of the float
                validaFloat = Console.ReadLine();
                VerificaPrecio(validaFloat);
            }
            return precioOk;
        }

    }
  
    
}
