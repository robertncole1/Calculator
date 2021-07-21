using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose to multiply or square!");
            var letsCalculate = Console.ReadLine();

            Console.WriteLine("Enter in a string of numbers separated by commas.");
            var stringOfNumbers = Console.ReadLine();

            switch (letsCalculate.ToLower())
            {
                case "multiply":
                    var multiplication = stringOfNumbers.Split(',');
                    Console.WriteLine(int.Parse(multiplication[0]) * int.Parse(multiplication[1]) * int.Parse(multiplication[2]));
                    break;
                case "square":
                    var exponents = stringOfNumbers.Split(',');
                    Console.WriteLine(int.Parse(exponents[0]) * int.Parse(exponents[0]) + "," + int.Parse(exponents[1]) * int.Parse(exponents[1]) + "," + int.Parse(exponents[2]) * int.Parse(exponents[2]));
                    break;
                default:
                    Console.WriteLine("Please enter multiply or square.");
                    break;
            }

        }
    }
}
