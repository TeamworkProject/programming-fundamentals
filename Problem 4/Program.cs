using System;

namespace Character_Stats
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var health = int.Parse(Console.ReadLine());
            var MaxHealth = int.Parse(Console.ReadLine());
            var energy = int.Parse(Console.ReadLine());
            var MaxEnergy = int.Parse(Console.ReadLine());

            string currentHealth = "|" + new string('|', health) + new string('.', MaxHealth - health) + "|";
            string currentEnergy = "|" + new string('|', energy) + new string('.', MaxEnergy - energy) + "|";

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: {currentHealth}");
            Console.WriteLine($"Energy: {currentEnergy}");
        }
    }
}