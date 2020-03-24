using System;
using static System.Console;

namespace controlflow
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "if statement";
            // if statement
            if (string.IsNullOrEmpty(s))
            {
                WriteLine("Emprty string");
            }
            else 
            {
                WriteLine("string has characters");
            }

            s = "";
            if (string.IsNullOrEmpty(s))
                WriteLine("Empty string");
            else 
                WriteLine("string has characters");


            // if statement - pattern matching
            int x = 10;
            object o = "2";
            if(o is int i)
            {
                WriteLine($"{i} x {x} = {i * x}");
            }
            else
            {
                WriteLine("o is not an integer");
            }

            // switch statement
            var num = (new Random().Next(1,5));
            switch (num)
	        {
                case 1:
                    WriteLine($"switch statement selcted {num}");
                    break;
                case 2:
                    WriteLine($"switch statement selcted {num}");
                    break;
                case 3:
                    WriteLine($"switch statement selcted {num}");
                    break;
                case 4:
                    WriteLine($"switch statement selcted {num}");
                    break;
                case 5:
                    WriteLine($"switch statement selcted {num}");
                    break;
		        default:
                    break;
	        }

        }
    }
}
