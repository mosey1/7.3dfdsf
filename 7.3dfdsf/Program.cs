using System;
using MyLib;
namespace _7._3dfdsf
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mas = new int[5, 8];
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    mas[i, j] = rnd.Next(-100, 100);
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }

            int res = MyLib.Class1.SumNegative(mas);
        }
    }
}
