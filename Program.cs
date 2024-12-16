using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();
        
        Console.WriteLine("Stopwatch Program:\n1 - Start\n2 - Stop\n3 - Reset\n4 - Exit");

        while (true)
        {
            Console.Write("Enter your choice: ");
            string? input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    if (!stopwatch.IsRunning)
                    {
                        stopwatch.Start();
                        Console.WriteLine("Stopwatch started.");
                    }
                    else
                    {
                        Console.WriteLine("Stopwatch is already running.");
                    }
                    break;

                case "2":
                    if (stopwatch.IsRunning)
                    {
                        stopwatch.Stop();
                        Console.WriteLine($"Stopwatch stopped at {stopwatch.Elapsed}.");
                    }
                    else
                    {
                        Console.WriteLine("Stopwatch is not running.");
                    }
                    break;

                case "3":
                    stopwatch.Reset();
                    Console.WriteLine("Stopwatch reset.");
                    break;

                case "4":
                    Console.WriteLine("Exiting program. Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid input. Please enter 1, 2, 3, or 4.");
                    break;
            }
        }
    }
}
