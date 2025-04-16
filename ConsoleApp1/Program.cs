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
            /*
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
                }*/
            /*
            int a, b, c, d, not;
            Console.WriteLine("La primera nota es: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("La segunda nota es: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("La tercera nota es: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("La cuarta nota es: ");
            d = int.Parse(Console.ReadLine());
            not = (a + b+ c+ d)/4;

            if (not > 12)
            {
                Console.WriteLine("el alumno esta aprobado");
            }
            else
            {
                Console.WriteLine("El alumno esta desaprobado");
            }
            */
            double a, b, c, d, not;
            Console.WriteLine("La primera nota es (10%): ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("La segunda nota es (20%): ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("La tercera nota es (30%): ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("La cuarta nota es (40%): ");
            d = double.Parse(Console.ReadLine());
            not = (a * 0.1) + (b * 0.2) + (c * 0.3) + (d * 0.4);
            Console.WriteLine("Promedio: " + not);
            if (not >= 11.5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("el alumno esta aprobado");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("El alumno esta desaprobado");
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
