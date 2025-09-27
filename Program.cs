using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var inventory = new List<string> { "hydraulic pump", "PLC module", "servo motor" };

        Console.WriteLine("Hej. Welcome to the spare parts inventory!");
        Console.Write("Which part do you need? ");

        while (true)
        {
            string input = Console.ReadLine();
            if (input == null) return;

            string part = input.Trim();

            // Exact, case-sensitive match for inventory parts
            if (inventory.Contains(part))
            {
                Console.WriteLine($"I've got {part} here for you 😊");
                break; // Program exits after affirming availability
            }

            // Special queries (case-insensitive, tolerant of phrasing/typos from sample)
            string q = part.ToLowerInvariant();
            if (q.Contains("have any parts") || q.Contains("anything in stock"))
            {
                Console.WriteLine($"We have {inventory.Count} part(s)!");
                foreach (var p in inventory) Console.WriteLine(p);
                Console.Write("Which part do you need? ");
                continue;
            }

            // Not found
            Console.WriteLine($"I am afraid we don't have any {part} in the inventory 😔");
            Console.Write("Which part do you need? ");
        }
    }
}