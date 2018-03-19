using System;

public class Test
{
	public static void Main()
	{
string name=Console.ReadLine();
int volume=int.Parse(Console.ReadLine());
int energy=int.Parse(Console.ReadLine());
int sugar=int.Parse(Console.ReadLine());

Console.WriteLine($"{volume}ml {name}:");
Console.WriteLine($"{((double)volume/100)*energy}kcal, {((double)volume/100)*sugar}g sugars");

	}
}