using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignment_1
{
    // class to calculate gold collecting performance
    class Program
    {
        // main method to calculate gold collecting performance
        static void Main(string[] args)
        {
            Console.WriteLine("Gold Collecting Performance");
            Console.Write("Enter total gold collected: ");
            int gold = int.Parse(Console.ReadLine());

            Console.Write("Enter total hours played: ");
            float hours = float.Parse(Console.ReadLine());

            float minutes = hours * 60;
            float gold_per_minute = gold / minutes;

            // print results
            Console.WriteLine("\nGold: " + gold);
            Console.WriteLine("Hours: " + hours);
            Console.WriteLine("Gold/Minute: " + gold_per_minute);
        }
    }
}
