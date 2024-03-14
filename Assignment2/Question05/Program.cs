//Adult ticket cost $3.75 and child ticket cost $2.25. Write a program to prompt the user for the amount of adult and child ticket that she needs. The program will display a user-friendly message of the number of tickets brought as well as the total cost. (Use the "C" format-string for currency).
using System;
class Program
{
    static void Main()
    {
        int adultTickets, childTickets;

        Console.Write("How many adult tickets are needed: ");
        if (!int.TryParse(Console.ReadLine(), out adultTickets) || adultTickets < 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid positive integer for adult tickets.");
            return;
        }

        Console.Write("\nHow many child tickets are needed: ");
        if (!int.TryParse(Console.ReadLine(), out childTickets) || childTickets < 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid positive integer for child tickets.");
            return;
        }

        decimal adultTicketCost = 3.75M;
        decimal childTicketCost = 2.25M;
        decimal totalCost = (adultTickets * adultTicketCost) + (childTickets * childTicketCost);

        Console.WriteLine($"\nNumber of adult tickets: {adultTickets}");
        Console.WriteLine($"Number of child tickets: {childTickets}");
        Console.WriteLine($"Total cost: {totalCost:C}\n");
    }
}
