﻿namespace OperationPerformanceTester
{
    using System;
    using System.Threading;

    using OperationPerformanceTester.Core.TestSuites;

    public class Startup
    {
        private const int RepeatCount = 20000;

        private static void Main()
        {
            var initialThreadPriority = Thread.CurrentThread.Priority;
            Thread.CurrentThread.Priority = ThreadPriority.Highest;

            Console.WriteLine($"Starting simple arithmetic operations tests with {RepeatCount} iterations.");
            var simpleArithmeticOperationsTestSuite = new SimpleArithmeticOperationsTestSuite(RepeatCount);
            var simpleTestsResult = simpleArithmeticOperationsTestSuite.GetTestsSummary();
            Console.WriteLine(simpleTestsResult);

            Console.WriteLine($"Starting complex arithmetic operations tests with {RepeatCount} iterations.");
            var complexArithmeticOperationsTestSuite = new ComplexArithmeticOperationsTestSuite(RepeatCount);
            var complexTestResults = complexArithmeticOperationsTestSuite.GetTestsSummary();
            Console.WriteLine(complexTestResults);

            Thread.CurrentThread.Priority = initialThreadPriority;
        }
    }
}
