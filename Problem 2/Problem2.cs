//CONFIRMED from <doctard>
using System;

namespace p02_RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
	    //read width and heith from console
            double width = double.Parse(Console.ReadLine());
            double heith = double.Parse(Console.ReadLine());

	    //calculate rectangle area
            double result = width * heith;

	    //write result on console
            Console.WriteLine($"{result:F2}");

        }
    }
}
