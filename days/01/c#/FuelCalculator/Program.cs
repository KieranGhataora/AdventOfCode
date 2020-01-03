using System;
using System.IO;
using System.Linq;

namespace FuelCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            var fileInput = File.ReadLines("../../input.txt").Select(decimal.Parse).ToList(); 
            
            Console.WriteLine(fileInput
                .Select(calc.CalculateFuelForWeight)
                .Aggregate((prev, curr) => prev + curr));
            
            Console.WriteLine(fileInput
                .Select(calc.CalculateFuelForWeight)
                .Select(calc.CalculateTotalFuel)
                .Aggregate((prev, curr) => prev + curr));
        }
    }
}
