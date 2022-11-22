using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_HW29
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[8];
            Random random = new Random();
            Console.WriteLine("Массив из 8 чисел: ");
            for (int i = 0; i < array.Length; i++)  //создание массива
            {
                array[i] = random.Next(-100, 100);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine("\nСортировка массива по модулю: ");
            int temp = 0;
            for (int i = 0; i < array.Length; i++)  //сортировка массива методом пузырька
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    array[i] = Math.Abs(array[i]);  //получение абсолютного значения элемента массива
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)  //вывод отсортированного массива
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
