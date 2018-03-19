using System;

public class Test
{
    public static void Main()
    {
        int a, b, c, d;
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());
        d = int.Parse(Console.ReadLine());
        Console.WriteLine($"{a:d4} {b:d4} {c:d4} {d:d4}");
    }
}