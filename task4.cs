using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class task4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int number = Convert.ToInt16(Console.ReadLine());
            string result = "";
            int hundreds = number / 100;
            switch (hundreds)
            {
                case 1:
                    result += "Сто";
                    break;
                case 2:
                    result += "Двести";
                    break;
                case 3:
                    result += "Триста";
                    break;
                case 4:
                    result += "Четыреста";
                    break;
                case 5:
                    result += "Пятьсот";
                    break;
                case 6:
                    result += "Шестьсот";
                    break;
                case 7:
                    result += "Семьсот";
                    break;
                case 8:
                    result += "Восемьсот";
                    break;
                case 9:
                    result += "Девятьсот";
                    break;
                default:
                    result = "Данные не соответствуют условию задачи";
                    Console.WriteLine(result);
                    Console.ReadKey();
                    return;
            }
            int decades = number % 100;
            if (decades < 20 && decades > 10)
            {
                int units = decades % 10;
                switch (units)
                {
                    case 1:
                        result += " одиннадцать ";
                        break;
                    case 2:
                        result += " двенадцать";
                        break;
                    case 3:
                        result += " тринадцать";
                        break;
                    case 4:
                        result += " четырнадцать";
                        break;
                    case 5:
                        result += " пятнадцать";
                        break;
                    case 6:
                        result += " шестнадцать";
                        break;
                    case 7:
                        result += " семнадцать";
                        break;
                    case 8:
                        result += " восемнадцать";
                        break;
                    case 9:
                        result += " девятнадцать";
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (decades / 10)
                {
                    case 0:
                        result += " ";
                        break;
                    case 1:
                        result += " десять ";
                        break;
                    case 2:
                        result += " двадцать ";
                        break;
                    case 3:
                        result += " тридцать ";
                        break;
                    case 4:
                        result += " сорок ";
                        break;
                    case 5:
                        result += " пятьдесят ";
                        break;
                    case 6:
                        result += " шестьдесят ";
                        break;
                    case 7:
                        result += " семьдесят ";
                        break;
                    case 8:
                        result += " восемьдесят ";
                        break;
                    case 9:
                        result += " девяносто ";
                        break;

                    default:
                        break;
                }
                int units = decades % 10;
                switch (units)
                {
                    case 1:
                        result += "одни";
                        break;
                    case 2:
                        result += "два";
                        break;
                    case 3:
                        result += "три";
                        break;
                    case 4:
                        result += "четыре";
                        break;
                    case 5:
                        result += "пять";
                        break;
                    case 6:
                        result += "шесть";
                        break;
                    case 7:
                        result += "семь";
                        break;
                    case 8:
                        result += "восемь";
                        break;
                    case 9:
                        result += "девять";
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}