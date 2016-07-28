using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            bool procced = true;
            while (procced)
            {
              char selecction =  printMenu();
                switch (selecction)
                {
                    case 'a':
                        addValues();
                        break;
                    case 'b':
                        ConcatenateStrings();
                        break;
                    case 'c':
                        LoopNumber();
                        break;
                    case 'd':
                        procced = false;
                        break;
                    default:
                        Console.WriteLine("Opcion Incorrecta.");

                        break;
                }
            }
        }

        private static void LoopNumber()
        {
            int value;
            Console.WriteLine("Por favor ingrese un numero");
            Console.ReadLine();
            value = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < value; i++)
            {
                Console.WriteLine("El valor de i es " + i);
            }

            Console.WriteLine(value);
            Console.ReadKey();
        }

        private static void ConcatenateStrings()
        {
            Console.WriteLine("Ingrese el primer texto");
            Console.ReadLine();
            string text1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo texto");
            string text2 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("El valor concatenado es " + text1 + " " + text2);
            Console.Read();

        }

        private static void addValues( )
        {
            
            int result = 0;

            Console.WriteLine("Ingrese el primer valor");
            Console.ReadLine();
            int valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo valor");
            int valor2 = Convert.ToInt32(Console.ReadLine());
            result = valor1 + valor2;
            Console.WriteLine("El resultado de la suma es " + result);

        }

        private static char printMenu()
        {
            try
            {
                Console.WriteLine("Seleccione una opcion");
                Console.WriteLine("a - Sumar dos valores");
                Console.WriteLine("b - Concatenar dos String");
                Console.WriteLine("c - Iterar un numero");
                Console.WriteLine("e - Salir");
                char option = (char)Console.Read();
                Console.WriteLine();
                return option;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
