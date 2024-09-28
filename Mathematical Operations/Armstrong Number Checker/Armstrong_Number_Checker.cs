using System;

class ArmstrongNumberChecker
{
    static void Main()
    {
        Console.WriteLine("--- Armstrong Number Checker ---");
        Console.Write("Enter an integer: ");
        
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (IsArmstrong(number))
            {
                Console.WriteLine($"{number} is an Armstrong number.");
            }
            else
            {
                Console.WriteLine($"{number} is not an Armstrong number.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a valid integer.");
        }
    }

    // Method to check if a number is an Armstrong number
    static bool IsArmstrong(int num)
    {
        int originalNumber = num;
        int sum = 0;
        int numberOfDigits = originalNumber.ToString().Length;

        // Calculate the sum of the digits raised to the power of the number of digits
        while (originalNumber > 0)
        {
            int digit = originalNumber % 10;
            sum += (int)Math.Pow(digit, numberOfDigits);
            originalNumber /= 10;
        }

        // Check if the sum is equal to the original number
        return sum == num;
    }
}
