using System;

namespace p02_RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double heith = double.Parse(Console.ReadLine());

            double result = width * heith;

            Console.WriteLine($"{result:F2}");

        }
    }
}
