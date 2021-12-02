using System;
using System.Threading;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double input1 = 0;
            double input2 = 0;
            string function;
            string answer;
            
            try
            {
                Console.Write("Enter the first number: ");
                input1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the second number: ");
                input2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Must enter a valid number");
                Thread.Sleep(2000);
                
                Main(args);//Restarts the application
                

            }

            Console.Write("Enter the function you would like to use (+ , - , * or /): ");
            function = Console.ReadLine();

            while (function != "+" && function != "-" && function != "*" && function != "/")
            {
                Console.WriteLine("Please enter a valid function!");
                Thread.Sleep(1000);
                Console.Write("Enter the function you would like to use (+ , - , * or /): ");
                function = Console.ReadLine();
            }   
            
            if (function == "+")
            {
                Console.WriteLine("{0} + {1} = {2}",input1,input2, Add(input1, input2));

            }
            else if (function == "-")
            {
                Console.WriteLine("{0} - {1} = {2}", input1, input2, Subtract(input1, input2));
            }
            else if (function == "*")
            {
                Console.WriteLine("{0} x {1} = {2}", input1, input2, Multiply(input1, input2));
            }
            else if (function == "/")
            {
                if(input2 == 0){
                    Console.WriteLine("Cannot divide by 0.. restarting");
                    Thread.Sleep(1000);
                    Main(args);
                }
                else
                {
                    Console.WriteLine("{0} ÷ {1} = {2}", input1, input2, Divide(input1, input2));
                }
            }

            Console.WriteLine("Would you like to go again? Enter 'Y' if yes, anything else if not:  ");
            answer = Console.ReadLine().ToLower();
            if(answer == "y")
            {
                Main(args);//Restart
            }
            Environment.Exit(0);


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
