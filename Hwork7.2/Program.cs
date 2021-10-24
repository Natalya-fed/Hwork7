using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hwork7._2
{
    class Program
    {
            static void Cub(double a, out double V, out double S)
            {
                V = Math.Pow(a, 3);
                S = 6 * Math.Pow(a, 2);
                Console.WriteLine($"Площадь куба S= {S:f2}\nОбъем куба V= {V:f2}");
            }
            static void Main(string[] args)
            {
                //Создать метод для вычисления объема и площади поверхности куба по длине его ребра.
                double a, S, V;
                Console.Write("Введите длину ребра куба A=");
                a = Convert.ToDouble(Console.ReadLine());
                Cub(a, out V, out S);
                Console.ReadKey();
            }
    }
}
