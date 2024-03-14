//Write a program to calculate the area of a circle. The user will enter the radius of the circle and the program will calculate and display the area according to the formula (area = 3.14 * radius * radius). You must accept fractions as the input. If the user enters 1.2 for the radius then the area will be 4.52. (Use the "F" format-specifier for floating point values).
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter radius of circle (as a fraction or a number): ");
        string userInput = Console.ReadLine();
        double radius;
        string[] fractionParts = userInput.Split('/');
        if (fractionParts.Length == 2 && double.TryParse(fractionParts[0], out double numerator) && double.TryParse(fractionParts[1], out double denominator))
        {
            radius = numerator / denominator;
        }
        else if (double.TryParse(userInput, out radius))
        {

        }
        else
        {
            Console.WriteLine("\nInvalid input. Please use numbers or fractions.\n");
            return;
        }

        double area = Math.PI * radius * radius;
        Console.WriteLine($"\nThe area of the circle is: {area:F}\n");
    }
}