using System;
using System.Linq.Expressions;

namespace simple_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepRunning = true;
            while (keepRunning == true)
            {

                Console.WriteLine("This is a simple calculator program.");
                string operatorChoice = "";
                double number1 = 0;
                double number2 = 0;
                bool operatorPicked = false;
                bool number1Picked = false;
                bool number2Picked = false;

                while (operatorPicked == false)
                {
                    Console.WriteLine("Please enter an operator type. (+, -, *, or /)");
                    operatorChoice = Console.ReadLine();
                    if (operatorChoice == "+")
                    {
                        operatorPicked = true;
                    }
                    else if (operatorChoice == "-")
                    {
                        operatorPicked = true;
                    }
                    else if (operatorChoice == "*")
                    {
                        operatorPicked = true;
                    }
                    else if (operatorChoice == "/")
                    {
                        operatorPicked = true;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid operator.");
                    }

                }
                while (number1Picked == false)
                {

                    Console.WriteLine("Please enter number 1 of 2.");
                    try
                    {
                        number1 = double.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("That's not a number...");
                        number1 = 0;
                    }
                    if (number1 != 0)
                    {
                        number1Picked = true;
                    }
                }

                while (number2Picked == false)
                {
                    Console.WriteLine("Please enter number 2 of 2.");
                    try
                    {
                        number2 = double.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("That's not a number...");
                        number2 = 0;
                    }
                    if (number2 != 0)
                    {
                        number2Picked = true;
                    }
                }

                double answer = 0;

                if (operatorChoice == "+")
                {
                    answer = number1 + number2;
                }
                else if (operatorChoice == "-")
                {
                    answer = number1 - number2;
                }
                else if (operatorChoice == "*")
                {
                    answer = number1 * number2;
                }
                else if (operatorChoice == "/")
                {
                    answer = number1 / number2;
                }
                Console.WriteLine("The answer is " + answer);
                bool runAgainResponse = false;
                while (runAgainResponse == false)
                {
                    Console.WriteLine("Do another calculation? Enter 'yes' or 'no'");
                    string response = Console.ReadLine();
                    if (response == "yes")
                    {
                        runAgainResponse = true;
                    }
                    else if (response == "no")
                    {
                        keepRunning = false;
                        runAgainResponse = true;
                    }
                }
            }

        }
    }
}
