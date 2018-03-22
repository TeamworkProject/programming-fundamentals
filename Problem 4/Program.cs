using System;

public class Test
{
	public static void Main()
	{
		//beverage name
		string name=Console.ReadLine();
		//beverage volume
		int volume=int.Parse(Console.ReadLine());
		//beverage energy
		int energy=int.Parse(Console.ReadLine());
		//beverage sugar
		int sugar=int.Parse(Console.ReadLine());
		//print volume and name
		Console.WriteLine($"{volume}ml {name}:");
		//print energy and sugar based on volume
		Console.WriteLine($"{((double)volume/100)*energy}kcal, {((double)volume/100)*sugar}g sugars");
	}
}