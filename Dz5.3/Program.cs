using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyMatrix mn = new MyMatrix(3, 7);
            mn.Show();
            mn.Change(10, 10);
            mn.Show();
            Console.ReadKey();
        }
    }
    class MyMatrix
    {
        public int[,] matrix;
        public MyMatrix(int x, int y)
        {
            matrix = new int[x, y];
        }
        public void Change(int x, int y)
        {
            matrix = new int[x, y]; 
        }
        public void Show()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine(matrix[i, 0]);

            }
        }
    }
}
