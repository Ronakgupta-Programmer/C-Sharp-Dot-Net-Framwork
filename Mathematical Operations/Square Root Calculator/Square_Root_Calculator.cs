using System;

class SquareRootCalculator
{
    static void Main()
    {
        Console.WriteLine("--- Square Root Calculator ---");
        Console.Write("Enter a non-negative number: ");

        if (double.TryParse(Console.ReadLine(), out double number))
        {
            if (number < 0)
            {
                Console.WriteLine("Error! The square root of a negative number is not defined.");
            }
            else
            {
                double squareRoot = Math.Sqrt(number);
                Console.WriteLine($"The square root of {number} is {squareRoot}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a valid non-negative number.");
        }
    }
}
