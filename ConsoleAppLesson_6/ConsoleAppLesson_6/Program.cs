using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // синтаксис обьявления многомерных массивов

            int[,] array = new int[3, 5];

            int count = 1;

            // заполнение двумерного массива с клавитуры

            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        Console.WriteLine("Enter the " + count + " number");
            //        count++;
            //        array[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine();

            // именно в квадратных скобках мы указываем скольки мерный будет массив
            // например: [,] - двумерный
            //           [,,] - трехмерный и т.д.

            // перебор массива при помощи цикла foreach

            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();

            // перебор массиваа при помощи вложенных циклов

            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i,j] + " ");
                }
            }

            Console.WriteLine();

            // метод GetLength() позволяет получить колличество элементво в измерении, нумерация измерения начинается с 0

            // заполнение двумерного массива случайными числами

            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(100);
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
