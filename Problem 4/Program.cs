//CONFIRMED from <ElenaBarutchieva>
using System;

public class Test
{
	public static void Main()
	{
		//beverage name
		string beverageName=Console.ReadLine();
		//beverage volume
		int beverageVolume=int.Parse(Console.ReadLine());
		//beverage energy
		int beverageEnergy=int.Parse(Console.ReadLine());
		//beverage sugar
		int beverageSugar=int.Parse(Console.ReadLine());
		//print volume and name
		Console.WriteLine($"{beverageVolume}ml {beverageName}:");
		//print energy and sugar based on volume
		Console.WriteLine($"{((double)beverageVolume/100)*beverageEnergy}kcal, {((double)beverageVolume/100)*beverageSugar}g sugars");
	}
}