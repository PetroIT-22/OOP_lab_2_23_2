using System;

namespace OOP_lab_2_23_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (double x = -1; x <= 25; x += 1.25)
            {
                double y = Math.Exp(x) / (3 * x - 12);

                Console.WriteLine("x = {0:f2} y = {1:f4}", x, y);
            }
        }
    }
}
