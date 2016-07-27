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
            throw new NotImplementedException();
        }

        private static void ConcatenateStrings()
        {
            throw new NotImplementedException();
        }

        private static void addValues()
        {
            throw new NotImplementedException();
        }

        private static char printMenu()
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
    }
}
