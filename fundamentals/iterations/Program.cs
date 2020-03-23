using System;
using static System.Console;

namespace iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            string newline = Environment.NewLine + Environment.NewLine;

            Write(newline);
            Write("for loop\n");
            for (int i = 0; i < 20; i++)
            {
                Write(i + "\t");
            }

            Write(newline);
            Write("foreach\n");
            string[] cities = { "Paris", "London", "New York", "Copenhagen" };
            foreach (var city in cities)
            {
                WriteLine($"{city} has {city.Length} characters");
            }

            Write(newline);
            Write("while loop\n");
            int x = 0;
            while (x < 10)
            {
                Write(x + "\t");
                x++;
            }

            Write(newline);
            Write("do while \n");
            int y = 0;
            do
	        {
                Write(y + "\t");
                y++;
	        } while (y < 10);
        }
    }
}
