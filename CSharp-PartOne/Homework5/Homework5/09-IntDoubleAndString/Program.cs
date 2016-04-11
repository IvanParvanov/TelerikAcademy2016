﻿using System;

//Write a program that, depending on the first line of the input, reads an int, double or string variable.

//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends* at the end.
//Print the result at the console. Use switch statement.

namespace _09_IntDoubleAndString
{
    class Program
    {
        static void Main()
        {
            string type = Console.ReadLine();
            switch (type)
            {
                case "integer":
                    int integer = int.Parse(Console.ReadLine()) + 1;
                    Console.WriteLine(integer);
                    break;
                case "real":
                    double real = double.Parse(Console.ReadLine()) + 1;
                    Console.WriteLine("{0:F2}", real);
                    break;
                case "text":
                    string str = Console.ReadLine();
                    Console.WriteLine(str + "*");
                    break;
                default:
                    Console.WriteLine("invalid input");
                    break;
            }
        }
    }
}
