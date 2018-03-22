//CONFIRMED from KalinKarolev
using System;

public class Test
{
    public static void Main()
    {
        int d1, d2, d3, d4;
        d1 = int.Parse(Console.ReadLine());
        d2 = int.Parse(Console.ReadLine());
        d3 = int.Parse(Console.ReadLine());
        d4 = int.Parse(Console.ReadLine());
        Console.WriteLine($"{d1:d4} {d2:d4} {d3:d4} {d4:d4}");
    }
}