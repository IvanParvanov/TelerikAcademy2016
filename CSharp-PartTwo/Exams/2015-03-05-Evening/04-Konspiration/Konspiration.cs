﻿using System;
using System.Text.RegularExpressions;

namespace _04_Konspiration
{
    internal class Konspiration
    {
        public static string _output = string.Empty;

        private static void Main()
        {   //TODO: 30/100

            //(?<!\bnew \b) check for new keyword
            const string regexPattern = @"(?<!\bnew \b)(?!\bif\b|\bfor\b|\bwhile\b|\bswitch\b|\btry\b|\bcatch\b)(\b[\w]+\b)[\s\n\r]*(?=\(.*\))";
            const RegexOptions regexOptions = RegexOptions.Singleline;

            int n = int.Parse(Console.ReadLine());

            string methodBody = string.Empty;
            int openingBrackets = 0;
            int closingBrackets = 0;
            bool inMethod = false;
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Trim();

                methodBody = methodBody + line;
                if (line =="{" && inMethod)
                {
                    openingBrackets++;
                }
                else if (line.StartsWith("}") && inMethod)
                {
                    closingBrackets++;
                }
                if (line.Contains("static"))
                {
                    string methodDeclaration = Regex.Match(line, regexPattern).Value;
                    _output = methodDeclaration + " -> ";
                    methodBody = string.Empty;
                    openingBrackets = 0;
                    closingBrackets = 0;
                    inMethod = true;
                }

                if (AreEqualAndModified(openingBrackets, closingBrackets))
                {
                    var listOfMethods = Regex.Matches(methodBody, regexPattern, regexOptions);
                    var listOfMethodsCount = listOfMethods.Count;
                    if (listOfMethodsCount == 0)
                    {
                        _output = _output + "None";
                        Console.WriteLine(_output);
                        _output = string.Empty;
                    }
                    else
                    {
                        _output = _output + listOfMethodsCount + " -> ";

                        for (int j = 0; j < listOfMethodsCount; j++)
                        {
                            string comma = ", ";
                            if (j == listOfMethodsCount - 1)
                            {
                                comma = string.Empty;
                            }
                            _output = _output + listOfMethods[j].Value + comma;
                        }
                        Console.WriteLine(_output);
                        _output = string.Empty;
                    }
                    openingBrackets = 0;
                    closingBrackets = 0;
                    methodBody = string.Empty;
                    inMethod = false;
                }
            }
            //Delete before submitting
            //Console.ReadLine();
            //Console.Clear();
            //Main();
        }

        private static bool AreEqualAndModified(int first, int second)
        {
            return first == second && first > 0 && second > 0;
        }
    }
}