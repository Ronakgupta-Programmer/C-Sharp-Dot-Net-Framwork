using System;

class FactorialCalculator
{
    static void Main()
    {
        Console.WriteLine("--- Factorial Finder ---");
        Console.Write("Enter a non-negative integer: ");

        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number < 0)
            {
                Console.WriteLine("Error! Factorial of a negative number doesn't exist.");
            }
            else
            {
                Console.WriteLine($"Factorial of {number} (Iterative): {FactorialIterative(number)}");
                Console.WriteLine($"Factorial of {number} (Recursive): {FactorialRecursive(number)}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a valid non-negative integer.");
        }
    }

    // Iterative method to calculate factorial
    static ulong FactorialIterative(int n)
    {
        ulong result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= (ulong)i;
        }
        return result;
    }

    // Recursive method to calculate factorial
    static ulong FactorialRecursive(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        else
            return (ulong)n * FactorialRecursive(n - 1);
    }
}