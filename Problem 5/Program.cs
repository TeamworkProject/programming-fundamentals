using System;

namespace Character_Stats
{
    public class Class1
    {
        public static void Main(string[] args)
        {
			//character name
            var name = Console.ReadLine();
			//character current health
            var health = int.Parse(Console.ReadLine());
			//character max name
            var MaxHealth = int.Parse(Console.ReadLine());
			//character current energy
            var energy = int.Parse(Console.ReadLine());
			//character max energy
            var MaxEnergy = int.Parse(Console.ReadLine());
			//current health/energy strings - add '|' equal to health, max health, energy, max energy
            string currentHealth = "|" + new string('|', health) + new string('.', MaxHealth - health) + "|";
            string currentEnergy = "|" + new string('|', energy) + new string('.', MaxEnergy - energy) + "|";
			//print strings
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: {currentHealth}");
            Console.WriteLine($"Energy: {currentEnergy}");
        }
    }
}