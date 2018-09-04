using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase05
{
    class Program
    {
        static void Main(string[] args)
        {
            Tinta obj1 = new Tinta();
            Tinta obj2 = new Tinta(ConsoleColor.Red);

            if(obj1 == obj2)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("Son distintos");
            }
            Console.ReadLine();
        }
    }
}
