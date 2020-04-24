using System;
using static System.Console;

namespace variablesandtypes
{
    class Program
    {
        static void Main(string[] args)
        {
            /* #region  numeric variables */
            // int
            // default = 0, Memory size = 4 bytes, Type = Value Type
            // .Net Type = System.Int32
            int x = 5;
            WriteLine($"integer is {x}");

            // double
            // default = 0.00, Memory size = 8 bytes, Type = Value Type
            // .Net Type = System.Double
            double d = 10.6;
            WriteLine($"double is {d}");

            // float
            // default = 0.0f, Memory size = 4 bytes, Type = Value Type
            // .Net Type = System.Single
            float f = 9.3f;
            WriteLine($"float is {f}");

            // float
            // default = 0.0m, Memory size = 16 bytes, Type = Value Type
            // .Net Type = System.Decimal
            decimal m = 6.7m;
            WriteLine($"decimal is {m}");
            /* #endregion */

            /* #region  char variable */
            // char
            // default = \0, Memory size = 2 bytes, Type = Value Type
            char letter = 'a';
            WriteLine($"char is {letter}");
            /* #endregion */

            /* #region  string variables */
            // string
            // default = null, Memory size = (2 bytes) * (length of string), Type = Reference Type
            string str = "hello";
            WriteLine($"string is {str}");

            // verbatim strings - prefixed with @ to disable escape characters so that a backslash is a backslash.
            string nameWithTab = "Richard\tJones";
            WriteLine(nameWithTab);

            // string filePath = "C:\tabs\section\*.txt"; --- fila with errors -> Unrecognized escape sequence
            string filePath = @"C:\tabs\section\*.txt";
            WriteLine(filePath);
            /* #endregion */

            /* #region  bool variable */
            // bool
            // default = null, Memory size = (2 bytes) * (length of string), Type = Reference Type
            Random random = new Random();
            bool isTrue = Convert.ToBoolean(random.Next(0, 2));
            if (isTrue)
            {
                WriteLine($"{isTrue} selected");
            }
            else
            {
                WriteLine($"{isTrue} is selected");
            }
            /* #endregion */

        }
    }
}
