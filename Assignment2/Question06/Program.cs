//Write a program to calculate and display the potential difference between the ends of a wire. The program will prompt the user for the current flowing and the resistance of the wire. Potential difference is the product of the current and the resistance of the wire and may include a fractional part. (Again, use the "F" format-specifier for floating point values).
using System;
class Program
{
    static void Main()
    {
        double current, resistance;

        Console.Write("Enter the current: ");
        if (!double.TryParse(Console.ReadLine(), out current))
        {
            Console.WriteLine("Invalid input. Please enter a valid number for current.");
            return;
        }

        Console.Write("Enter the resistance: ");
        if (!double.TryParse(Console.ReadLine(), out resistance))
        {
            Console.WriteLine("Invalid input. Please enter a valid number for resistance.");
            return;
        }

        double potentialDifference = current * resistance;

        Console.WriteLine($"\nYou entered: Current = {current}, Resistance = {resistance}");
        Console.WriteLine($"Potential difference: {potentialDifference:F}\n");
    }
}