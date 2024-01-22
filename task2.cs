using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            Console.WriteLine("Введите А:");
            A = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите B:");
            B = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите C:");
            C = Convert.ToInt16(Console.ReadLine());
            if (B == C)
            {
                if (A == B)
                {
                    Console.WriteLine("Все три точки совпадают");
                    Console.ReadKey();
                    return;
                }
                Console.WriteLine("Точки B и C совпадают и расстояние до А равно:");
                Console.WriteLine(Math.Abs(A - B));
                Console.ReadKey();
                return;
            }
            if (Math.Abs(A - B) < Math.Abs(A - C))
            {
                Console.WriteLine("Точка B лежит ближе к А и расстояние до А равно:");
                Console.WriteLine(Math.Abs(A - B));
                Console.ReadKey();
                return;
            }
            else if (Math.Abs(A - B) == Math.Abs(A - C))
            {
                Console.WriteLine("Точки B и C не совпадают, но равноудалены от А, расстояние до А равно:");
                Console.WriteLine(Math.Abs(A - C));
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Точка С лежит ближе к А и расстояние до А равно");
                Console.WriteLine(Math.Abs(A - C));
                Console.ReadKey();
                return;
            }
            Console.ReadKey();
        }
    }
}
