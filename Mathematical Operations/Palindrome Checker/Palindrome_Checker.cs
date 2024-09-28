using System;

class PalindromeChecker
{
    static void Main()
    {
        Console.WriteLine("--- Palindrome Checker ---");
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        if (IsPalindrome(input))
        {
            Console.WriteLine($"\"{input}\" is a palindrome.");
        }
        else
        {
            Console.WriteLine($"\"{input}\" is not a palindrome.");
        }
    }

    // Method to check if a string is a palindrome
    static bool IsPalindrome(string str)
    {
        // Remove non-alphanumeric characters and convert to lower case
        string cleanedString = CleanString(str);
        int start = 0;
        int end = cleanedString.Length - 1;

        while (start < end)
        {
            if (cleanedString[start] != cleanedString[end])
                return false;
            start++;
            end--;
        }
        return true;
    }

    // Helper method to clean the string
    static string CleanString(string str)
    {
        char[] arr = str.ToLower().ToCharArray();
        string cleanedString = "";
        
        foreach (char c in arr)
        {
            if (char.IsLetterOrDigit(c))
            {
                cleanedString += c;
            }
        }
        return cleanedString;
    }
}
