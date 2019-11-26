using System;
using System.Collections.Generic;
using System.Threading;

namespace Alumnos1
{
    class Program
    {
        static char EscapeCharacter = 'R';
        static string EscapeWord = "RUNYOUFOOLS";
        static char OptionChar = ' ';
        static char ExitChar = 'e';
        static string CurrentOption;
        static string currentEstadicticaOpcion;
        static List<double> notasDeAlumnos { get; set; } // creo constructor


        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            notasDeAlumnos  = new List<double>(); // inicializo 
            Console.WriteLine("Bienvenid@ al programa para gestión de alumnos\n\n");
            showMenu();

            OptionChar = Console.ReadKey().KeyChar;    

           
            var keepDoing = true;

            while (true)
            {

                if (OptionChar == 'm')
                {
                    Console.Clear();
                    showMenu();
                }

                if (OptionChar == 'n')
                {
                    Console.Clear();
                    AddNotesOpcion();
                    //OptionChar = 'm';
                    //break;
                    OptionChar = Console.ReadKey().KeyChar;

                }

                if (OptionChar == 'c')
                {
                    Console.Clear(); // limpiamos consola
                    Console.BackgroundColor = ConsoleColor.Yellow; // cambiamos el color de fondo a yellow
                    Console.ForegroundColor = ConsoleColor.Black; // cambiamos el color del texto a negro

                    CurrentOption = "c"; // asignamos valor a la variable

                    Console.WriteLine("Estadística de notas \n");
                    Console.WriteLine($"Qué datos desea consultar ? \n");
                    EstadisticasMenu();
                    OptionChar = Console.ReadKey().KeyChar;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }

                if (OptionChar == 'e')
                {
                    Console.Clear();
                    Console.WriteLine("Esta pantalla se cerrará en 5 segundos");
                    Thread.Sleep(5000);
                    break;
                }

                    //Console.WriteLine($"Nota del alumno {notasDeAlumnos.Count + 1}:");
                    //var notaText = Console.ReadLine();

                    //if (notaText == EscapeWord)
                    //{
                    //    keepDoing = false;
                    //}
                    //else
                    //{
                    //    var nota = 0.0;

                    //    if (double.TryParse(notaText.Replace(".", ","), out nota))
                    //    {
                    //        notasDeAlumnos.Add(nota);
                    //    }
                    //    else
                    //    {
                    //        Console.WriteLine("La nota introducida es incorrecta melón!");
                    //    }
                    //}


                    Console.ReadKey();
            }

            
        }

        static void showMenu()
        {
            Console.Clear();
            CurrentOption = "m";
            Console.WriteLine("Menú de opciones principal");
            Console.WriteLine("Opciones:");
            string opcionM= "- Para volver al menú principal:".PadRight(40);
            Console.Write(opcionM);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("- m ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            string opcionN = "- Para añadir notas:".PadRight(40);
            Console.Write(opcionN);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("- n ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            string opcionC = "- Para mostrar estadísticas:".PadRight(40);
            Console.Write(opcionC);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("- c ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            string opcionE = "- Para salir:".PadRight(40);
            Console.Write(opcionE);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("- e ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

        }

        // función para añadir notas
        static void AddNotesOpcion()
        {
            Console.Clear(); // limpiamos consola
            Console.BackgroundColor = ConsoleColor.Green; // cambiamos el color de fondo a verde
            Console.ForegroundColor = ConsoleColor.Black; // cambiamos el color del texto a negro

            CurrentOption = "n"; // asignamos valor a la variable

            Console.WriteLine("Menu de añadir notas. Introduzca las notas y presione el enter\n");
            Console.WriteLine($"Para terminar y volver al menú principal pulse 'm' \n");
            Console.BackgroundColor = ConsoleColor.Black; // cambiamos el color de fondo a negro
            Console.ForegroundColor = ConsoleColor.White;// cambiamos el color del texto a negro

            CurrentOption = "n";

            
            var readingNotes = Console.ReadLine(); // leemos y asignamos

            while(readingNotes!= "m") // mientras no quieras salir
            { 
                double notes;

                if (double.TryParse(readingNotes.Replace('.', ','), out notes)) // reemplazamos y traspasamos a double
                {
                    notasDeAlumnos.Add(notes); // añadimos a la lista
                    Console.WriteLine("Nota introducida correctamente\n");                   
                }
                else
                {
                    Console.WriteLine($"El valor introducidio [{readingNotes}] no es válido");
                }

                readingNotes = Console.ReadLine(); // volvemos a leer
            }
                       
            Console.Clear(); // limpiamos la consola                
            showMenu(); // volvemos a mostrar el menú principal
        }

        // función para menu estadísticas
        static void EstadisticasMenu()
        {
            Console.BackgroundColor = ConsoleColor.Yellow; // cambiamos el color de fondo a verde
            Console.ForegroundColor = ConsoleColor.Black; // cambiamos el color del texto a negro
            string opcionAvg = "- Media de las notas de los alumnos:".PadRight(50);
            Console.Write(opcionAvg);
            Console.WriteLine("- avg ");
           

            string opcionMax = "- Nota máxima de los alumnos:".PadRight(50);
            Console.Write(opcionMax);
            Console.WriteLine("- max ");
           
            string opcionMin = "- Nota mínima de los alumnos:".PadRight(50);
            Console.Write(opcionMin);            
            Console.WriteLine("- min ");
           
            string opcionM = "- Para exit al menú principal:".PadRight(50);
            Console.Write(opcionM);
            Console.WriteLine("- e \n");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            currentEstadicticaOpcion = Console.ReadLine();

            switch (currentEstadicticaOpcion)
            {
                case "avg":
                    Avarage();
                    break;
                case "max":
                    MaximaNota();
                    break;
                case "min":
                    MinimaNota();
                    break;
                case "e":
                    showMenu();
                    break;
                default:
                    Console.WriteLine("Esa opción no es válida");
                    break;
            }

            currentEstadicticaOpcion = Console.ReadLine();
        }

        static void Avarage()
        {

            currentEstadicticaOpcion = "avg";
            
            var suma = 0.0;

            for (var i = 0; i < notasDeAlumnos.Count; i++)
            {
                suma += notasDeAlumnos[i];
            }

            var average = suma / notasDeAlumnos.Count;
            Console.WriteLine("\nLa nota media de los exámenes es: {0}", average +"\n\n");

            currentEstadicticaOpcion = ""; // reseteamos

            EstadisticasMenu(); // volvemos a mostrar el menú de estadísticas
        }

        // función nota máxima
        static void MaximaNota()
        {

            currentEstadicticaOpcion = "max";

            var maximaNota = 0.0;
            var notaActual = 0.0;

            for (var i = 0; i < notasDeAlumnos.Count; i++)
            {
                notaActual = notasDeAlumnos[i];
                if (notaActual > maximaNota)
                {
                    maximaNota = notaActual;
                }
            }
                       
            Console.WriteLine("La nota máxima es de: {0}", maximaNota + "\n\n");

            currentEstadicticaOpcion = ""; // reseteamos
            EstadisticasMenu(); // volvemos a mostrar el menú de estadísticas
        }

        // función nota mínima
        static void MinimaNota()
        {

            currentEstadicticaOpcion = "min";

            var minimaNota = 0.0;
            var notaActual = 0.0;

            for (var i = 0; i < notasDeAlumnos.Count; i++)
            {
                notaActual = notasDeAlumnos[i];
                if (notaActual > minimaNota)
                {
                    minimaNota = notaActual;
                }
            }

            Console.WriteLine("La nota máxima es de: {0}", minimaNota + "\n\n");

            currentEstadicticaOpcion = ""; // reseteamos
            EstadisticasMenu(); // volvemos a mostrar el menú de estadísticas
        }


    }
    
}
