using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class task3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите возраст:");
            int age = Convert.ToInt16(Console.ReadLine());
            int decades = age / 10;
            string result = "";
            switch (decades)
            {
                case 2:
                    result += "Двадцать ";
                    break;
                case 3:
                    result += "Тридцать ";
                    break;
                case 4:
                    result += "Сорок ";
                    break;
                case 5:
                    result += "Пятьдесят ";
                    break;
                case 6:
                    result += "Шестьдесят ";
                    break;
                default:
                    result = "Данные не соответствуют условию задачи";
                    Console.WriteLine(result);
                    Console.ReadKey();
                    return;
            }
            int units = age % 10;
            switch (units)
            {
                case 0:
                    result += "лет";
                    break;
                case 2:
                    result += "два года";
                    break;
                case 3:
                    result += "три года";
                    break;
                case 4:
                    result += "четыре года";
                    break;
                case 5:
                    result += "пять лет";
                    break;
                case 6:
                    result += "шесть лет";
                    break;
                case 7:
                    result += "семь лет";
                    break;
                case 8:
                    result += "восемь лет";
                    break;
                case 9:
                    result += "девять лет";
                    break;
                default:
                    break;
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}