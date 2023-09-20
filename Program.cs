using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana5_ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad requerida: ");

            int cantidad =int.Parse(Console.ReadLine());

            Random r =new Random();

            for (int i = 1; i <= cantidad; i++)
            {
                Console.WriteLine("Aleatorio "+i+": "+r.Next(1,100));


            }

            Console.ReadKey();
        }
    }
}
