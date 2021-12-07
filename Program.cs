using System;
using System.Threading;

namespace Calculator
{
    internal class Program
    {
        private static double input1 = 0;
        private static double input2 = 0;
        private static double answer = 0;
        private static string function;
        private static string tryAgain;
        private static bool running = true;
        static void Main(string[] args)
        {
            while (running)
            {
                try
                {
                    GetNumbers();
                    GetFunction();
                    DisplayAnswer();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    function = "";
                    TryAgain();
                }
            }

        }
        public static void GetNumbers()
        {
            Console.Write("Enter the first number: ");
            input1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            input2 = Convert.ToDouble(Console.ReadLine());
        }
        public static void GetFunction()
        {
            while (function != "+" && function != "-" && function != "*" && function != "/")
            {
                Console.Write("Enter the function you would like to use (+ , - , * or /): ");
                function = Console.ReadLine();
            }
        }
        public static void DisplayAnswer()
        {
            if (input2 == 0 && function == "/")
            {
                Console.WriteLine("Cannot divide by 0!");
            }
            else
            {
                answer = HandleEquation(input1, input2, function);
                Console.WriteLine($"{ input1 } { function } { input2 } = { answer }");
            }
        }
        public static void TryAgain()
        {
            Console.WriteLine("Enter 'q' to quit, or press enter to go again: ");
            tryAgain = Console.ReadLine().ToLower();
            if (tryAgain == "q")
            {
                running = false;
            }
        }
        public static double HandleEquation(double input1, double input2, string func)
        {
            switch (func)
            {
                case "+":
                    return input1 + input2;
                case "-":
                    return input1 - input2;
                case "*":
                    return input1 * input2;
                case "/":
                    return input1 / input2;
                default:
                    return 0;
            }
        }
    }
}
