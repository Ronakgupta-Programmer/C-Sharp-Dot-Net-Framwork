using System;

class FibonacciSeries
{
    static void Main()
    {
        Console.WriteLine("--- Fibonacci Series Generator ---");
        Console.Write("Enter the number of terms: ");

        if (int.TryParse(Console.ReadLine(), out int terms))
        {
            if (terms <= 0)
            {
                Console.WriteLine("Please enter a positive integer.");
            }
            else
            {
                Console.WriteLine($"Fibonacci Series up to {terms} terms:");
                PrintFibonacci(terms);
            }
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a valid integer.");
        }
    }

    // Method to print the Fibonacci series
    static void PrintFibonacci(int n)
    {
        int a = 0, b = 1, next;

        for (int i = 1; i <= n; i++)
        {
            Console.Write(a + " ");
            next = a + b;
            a = b;
            b = next;
        }
        Console.WriteLine();
    }
}
