using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un caracter");
            char c = (Char)Console.Read();
            //c = Convert.ToChar(Console.Read());

            //Condicion tipo if

            if (Char.IsLetter(c)) {
                if (Char.IsLower(c)) {

                   Console.WriteLine("El caracter no es mayuscula");

                }
                else
                {
                    Console.WriteLine("El caracter es mayuscula");

                }

                Console.WriteLine("El caracter si es una letra");

            }
            else
            {
                Console.WriteLine("El caracter no es una letra");
            }
            Console.ReadKey();
        }
    }
}
