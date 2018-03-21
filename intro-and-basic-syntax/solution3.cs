using System;

public class Test
{
    public static void Main()
    {
        // We recieve from the Console miles (double). 
        double miles;
        miles = double.Parse(Console.ReadLine());

        //Miles are converted to kilometers and then they are printed. The output is formated to the 2nd decimal place. 
        Console.WriteLine($"{miles * 1.60934:f2}");
    }
}