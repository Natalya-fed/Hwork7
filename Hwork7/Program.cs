using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hwork7
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double P, S;
            Console.WriteLine("Введите длины сторон первого треугольника");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            CalcSq(a, b, c, out S, out P);
            double S1 = S;
            Console.WriteLine("Введите длины сторон второго треугольника");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            CalcSq(a, b, c, out S, out P);
            double S2 = S;
            if (S1 > S2)
            {
                Console.WriteLine($"Площадь первого треугольника больше {S1:f2} > {S2:f2}");
            }
            else if (S1 < S2)
            {
                Console.WriteLine($"Площадь второго треугольника больше {S1:f2} < {S2:f2}");
            }
            else
            {
                Console.WriteLine($"Площади первого и второго равны {S1:f2} = {S2:f2}");
            }
            Console.ReadKey();
        }
        static void CalcSq(double a, double b, double c, out double S, out double P)
        {

            P = (a + b + c) / 2;
            S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
        }
    }
    
}
