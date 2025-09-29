// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;
using System.Reflection.Metadata;
Console.Clear();
Console.WriteLine("-Welcome to the game of sticks!!!!-");
Console.WriteLine("*Cheering from the crowd*");

Console.WriteLine("Players will take turns removing 1 to 3 of the remaining sticks. The player that removes the last stick loses.");
int sticksTotal = 20;
int maxSticks = 3;
int currentPlayer = 1;
while (sticksTotal > 0) 
{
    Console.Clear();

    Console.WriteLine("Sticks Left: " + sticksTotal); 

    int sticksTaken;
    while (true)
    {
         Console.Write("Player " + currentPlayer + ", how many sticks would you like to take?(Type answer on next line)");
        Console.ReadLine();

        string? input = Console.ReadLine();

        if (int.TryParse(input, out sticksTaken))
        {
            if (sticksTaken >= 1 && sticksTaken <= maxSticks && sticksTaken <= sticksTotal)
            {
                break;

            }
            else
            {
                Console.WriteLine($"Invalid! Please try again with a number that will actually work!");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Put a number in!");
        }
    }
    sticksTotal -= sticksTaken;

    if (sticksTotal <= 0)
    {
        Console.WriteLine($"Player " + currentPlayer + " took the last stick! Hahaha, he is a loser face!");
        int winner = (currentPlayer == 1) ? 2 : 1;
        Console.WriteLine($"Player " + winner + " wins! What a good boy!");
    }
    else
    {
        currentPlayer = (currentPlayer == 1) ? 2 : 1;
    }
}
Console.WriteLine("What a game!!! Friendships destroyed and now we have procrastinated our homework even further! Well I guess goodbye for now");
