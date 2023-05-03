using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b = 0;
            Random random = new Random();
            int[] Array = new int[random.Next(2, 8)];
            for (int i = 0; i < Array.Length; i++)
            {
                int v = random.Next(1, 20);
                Array[i] = v;
            }
            array ara = new array(Array);
            ara.Suma();
            ara.BiggestNumb();
            ara.SmallestNumb();
            ara.OddNumbers();
            Console.ReadKey();
        }
        class array
        {
            int[] ints;
            public array(int[] array)
            {
                ints = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    ints[i] = array[i];
                }
            }
            public void Suma()
            {
                int B = 0;
                for (int i = 0; i < ints.Length; i++)
                {
                    B += ints[i];
                }
                Console.WriteLine("сума всіх елементів: " + B);
            }
            public void BiggestNumb()
            {
                Console.WriteLine("найбільше значення: " + ints.Max());
            }
            public void SmallestNumb()
            {
                Console.WriteLine("найменше значення: " + ints.Min());
            }
            public void OddNumbers()
            {
                Console.Write("непарні числа:");
                for (int i = 0; i < ints.Length; i++)
                {
                    if (ints[i] % 2 == 1)
                    {
                        Console.Write(ints[i] + " ");
                    }
                }
            }
        }
    }
}
