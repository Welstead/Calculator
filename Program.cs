using System;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double input1 = 0;
            double input2 = 0;
            
            try
            {
                Console.WriteLine("Enter the first number: ");
                input1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the second number: ");
                input2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Must enter a valid number");
                Thread.Sleep(2000);
                Main(args);//Restarts the application
                

            }
            Console.WriteLine("Enter the operator you would like to use (+ , - , * or /): ");
            string userOperator = Console.ReadLine();
            if(userOperator == "+")
            {
                Console.WriteLine(Add(input1, input2));

            }
            else if(userOperator == "-")
            {
                Console.WriteLine(Subtract(input1, input2));
            }
            else if (userOperator == "*")
            {
                Console.WriteLine(Multiply(input1, input2));
            }
            else if(userOperator == "/")
            {
                Console.WriteLine(Divide(input1, input2));
            }
            else {
                Console.WriteLine("Enter a valid operator");
            }


            
        }
        public static double Add(double input1, double input2)
        {
            return input1 + input2;
        }
        public static double Subtract(double input1, double input2)
        {
            return input1 - input2;
        }
        public static double Multiply(double input1, double input2)
        {
            return input1 * input2;
        }
        public static double Divide(double input1, double input2)
        {
            return input1 / input2;
        }

    }
}
