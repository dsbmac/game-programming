using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class Program
    {
        // convert a temperature from Fahrenheit to Celsius and back again
        static void Main(string[] args)
        {
            float celsius;
            float originalFahrenheit;
            float calculatedFahrenheit;
            Console.Write("Enter temperature (Fahrenheit): ");
            originalFahrenheit = float.Parse(Console.ReadLine());
            celsius = (originalFahrenheit - 32) / 9 * 5;
            Console.WriteLine(originalFahrenheit + " degrees Fahrenheit is " + 
                celsius + " degrees Celsius");
            calculatedFahrenheit = celsius * 9 / 5 + 32;
            Console.WriteLine(celsius + " degrees Celsius is " +                 calculatedFahrenheit + " degrees Fahrenheit");
        }
    }
}
