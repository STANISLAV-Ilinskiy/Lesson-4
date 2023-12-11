using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Задайте массив заполненный случайными трёхзначными числами. 
 * Напишите программу, которая покажет количество чётных чисел в массиве.*/

namespace _2_Zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = GenerateRandomArray(10, 100, 999);
            Console.WriteLine("Сгенерированный массив: ");
            for(int i=0; i<array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            int evenCount = CountEvenNum(array);
            Console.WriteLine("Количество четных чисел в массиве: " + evenCount);
        }
        //Функция для создания и рандомного заполнения массива
        static int[] GenerateRandomArray(int lenght, int min, int max)
        {
            Random rnd = new Random();
            int[] array = new int[lenght];
            for(int i=0;i<lenght; i++)
            {
                array[i] = rnd.Next(min, max + 1);
            }
            return array;
        }
        
        //Функция счетчик четных чисел
        static int CountEvenNum(int[] array)
        {
            int count = 0;
            foreach(int number in array)
            {
                if (number % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
