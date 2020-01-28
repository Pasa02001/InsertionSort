using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            int ammount = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[ammount];
            Random random = new Random();
            int x = 0;

            while (x < ammount)
            {
                array[x] = random.Next(1, 100);
                Console.Write(array[x]+" ");
                x++;
            }
            sw.Start();
            int a = 1;
            int b = a;
            int temp = 0;

            while (a < array.Length)
            {
                b = a;
                while (b > 0 && array[b-1] > array[b])
                {
                    temp = array[b];
                    array[b] = array[b-1];
                    array[b - 1] = temp;
                    b--;
                }
                a++;
            }
            sw.Stop();

            for (int i = 0; i<array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("insertion sort tog={0} sekunder", sw.Elapsed);

        } 
    }
}
