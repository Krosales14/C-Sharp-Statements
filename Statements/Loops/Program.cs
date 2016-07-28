using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            int value;
            Console.WriteLine("Por favor ingrese un numero");
            value = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < value; i++)
            {
                Console.WriteLine("El valor de i es " + i);
            }

            //int u = value;
            //while (u > 0)
            //{
            //    Console.WriteLine("El valor de u es " + u);
            //    u--;
            //}

            //bool active = true;
            //while (active)
            //{
            //    Console.WriteLine("El estado es "+ active);
            //}

            Console.WriteLine(value);
            Console.ReadKey();
        }
    }
}
