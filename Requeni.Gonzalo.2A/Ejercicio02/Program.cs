using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 01";

            int numero;
            int cuadrado;
            int cubo;

            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());
            while(numero <= 0)
            {
                Console.Write("ERROR. ¡Reingresar número!: ");
                numero = int.Parse(Console.ReadLine());
            }
        }
    }
}
