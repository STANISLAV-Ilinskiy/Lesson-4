using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = GenerateRandomArray(10, 10, 99);
            Console.WriteLine("Сгенерированный массив: ");
            for(int i=0; i<array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            int[] reversArray = ReverseArray(array);
            Console.WriteLine("Перевернутый массив: ");
            for (int i = 0; i < reversArray.Length; i++)
            {
                Console.Write(reversArray[i] + " ");
            }
            Console.WriteLine();

        }

        static int[] GenerateRandomArray(int length, int min, int max)
        {
            Random rnd = new Random();
            int[] array = new int[length];
            for(int i=0; i < length; i++)
            {
                array[i] = rnd.Next(min, max + 1);
            }
            return array;
        }
        
        static int[] ReverseArray(int[] array)
        {
            int[] newArray= new int[array.Length];
            for(int i=0; i<array.Length; i++)
            {
                int temp = newArray[i];
                newArray[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }
            return newArray;
        }
    }
}
