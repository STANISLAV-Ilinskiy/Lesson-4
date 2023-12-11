using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число или 'q' для выхода.");
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "q")
                {
                    Console.WriteLine("Выход из программы. ");
                    break;
                }

                if (int.TryParse(input, out int number))
                {
                    if (IfSumOfDigitsEven(number))
                    {
                        Console.WriteLine("Сумма цифр числа четная. Программа завершена.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка! Введите корректное целое число или 'q' для выхода.");
                }
            }
        }
        //Функция проверки суммы цифр числа на четность
        static bool IfSumOfDigitsEven(int number)
        {
            int sum = 0;
            while(number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum % 2 == 0;
        }
    }
}
