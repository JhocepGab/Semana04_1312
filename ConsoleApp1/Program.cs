using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, disc;
            double x1, x2;
            Console.WriteLine("escriba el valor de a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("escriba el valor de b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el valor de c: ");
            c = int.Parse(Console.ReadLine());
            disc = b * b - (4 * a * c);

            if (disc > 0)
            {
                x1 = (-b + Math.Sqrt(disc)) / (2 * a);
                x2 = (-b - Math.Sqrt(disc)) / (2 * a);

                Console.WriteLine("x1 :" + x1);
                Console.WriteLine("x2 :" + x2);
            }
            else
            {
                if (disc == 0)
                {
                    x1 = -b / 2 * a;
                    Console.WriteLine("x1: " + x1);
                }else
                {
                    Console.WriteLine("no tiene soluciones: ");
                }
            }
        }
    }
}
