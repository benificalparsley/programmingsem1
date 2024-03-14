//.Write a program that prompts the user for a number (that may be a fraction). The program reads in the input and print the following: the input as a double, the input as an int and finally the input as a char. e.g. if the input is 65.790, then the output will be 65.790, 65, and A
using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a number or a decimal: ");
        string userInput = Console.ReadLine();
        double userInputDouble;

        if (userInput.Contains("/"))
        {
            string[] fractionParts = userInput.Split('/');
            if (fractionParts.Length == 2 && double.TryParse(fractionParts[0], out double numerator) && double.TryParse(fractionParts[1], out double denominator))
            {
                userInputDouble = numerator / denominator;
            }
            else
            {
                Console.WriteLine("Invalid input.");
                userInputDouble = 0.0;
            }
        }
        else
        {
            if (!double.TryParse(userInput, out userInputDouble))
            {
                Console.WriteLine("Invalid input.");
                userInputDouble = 0.0;
            }
        }
        int userInputInt = (int)userInputDouble;
        char userInputCharConverted = (char)userInputInt;
        Console.WriteLine($"As double: {userInputDouble:F}, As int: {userInputInt}, As char: {userInputCharConverted}\n");
    }
}