using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem 1
            int age = 37;
            Console.WriteLine("age: " + age);

            // Problem 2
            int MAX_SCORE = 100;
            int score = 50;
            double percent = (float) score / MAX_SCORE;
            Console.WriteLine("percent: " + percent);
        }
    }
}
