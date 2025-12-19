using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculator";
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n\t\t\t\t\tDo yo want to use Calculator");
            Console.WriteLine("\t\t\t\t\tType 'yes' to continue or 'no' to exit:");
            Console.Write("\t\t\t\t\t=====================================\t");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string response = Console.ReadLine();
            Console.WriteLine("\t\t\t\t\t=====================================");
            List<string> history = new List<string>();
           
            while (response == "yes")
              
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t\t\t\t\tWelcome to the Calculator!");
                Console.WriteLine("\t\t\t\t\tThis is a simple calculator application.");
                Console.WriteLine("\t\t\t\t\t========================================");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\t\t\t\t\tPlease Select Which Operation do You want \n\t\t\t\t\t1) Addition \n\t\t\t\t\t2) Subtraction \n\t\t\t\t\t3)" +
                    "Multiplication \n\t\t\t\t\t4) Division \n\t\t\t\t\t5)Percentage" +
                    " \n\t\t\t\t\t6)Square \n\t\t\t\t\t6)Cube \n\t\t\t\t\t8)Square Root \n\t\t\t\t\t9)Power " +
                    "\n\t\t\t\t\t10)Logaritham \t ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                string operation = Console.ReadLine();

               if (operation == "+" || operation == "1")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\t\t\t\t\tWelcome to Addition Program");
                    Console.WriteLine("\t\t\t\t\t=====================================");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\t\t\t\t\tEnter First Number:\t");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    double num1;
                    while (!double.TryParse(Console.ReadLine(), out num1))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\t\t\t\t\tInvalid Input. Please enter a valid number:\t");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\t\t\t\t\tEnter Second Number:\t");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    double num2;
                    while (!double.TryParse(Console.ReadLine(), out num2))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\t\t\t\t\tInvalid Input. Please enter a valid number:\t");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    double result = num1 + num2;
                    string record = $"{num1} + {num2} = {result}";
                    history.Add(record);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\n\t\t\t\t\tThe Result is: " + result + "\t");
                    Console.WriteLine("\t\t\t\t\t___________________________");
                }
                else if (operation == "-" || operation == "2")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\t\t\t\t\tWelcome to Subtraction Program");
                    Console.WriteLine("\t\t\t\t\t=====================================");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\t\t\t\t\tEnter First Number:\t");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    double num1;
                    while (!double.TryParse(Console.ReadLine(), out num1))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\t\t\t\t\tInvalid Input. Please enter a valid number:\t");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\t\t\t\t\tEnter Second Number:\t");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    double num2;
                    while (!double.TryParse(Console.ReadLine(), out num2))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\t\t\t\t\tInvalid Input. Please enter a valid number:\t");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    double result = num1 - num2;
                    string record = $"{num1} - {num2} = {result}";
                    history.Add(record);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\n\t\t\t\t\tThe Result is: " + result + "\t");
                    Console.WriteLine("\t\t\t\t\t___________________________");
                }
                else if (operation == "*" || operation == "3")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\t\t\t\t\tWelcome to Multiplication Program");
                    Console.WriteLine("\t\t\t\t\t=====================================");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\t\t\t\t\tEnter First Number:\t");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    double num1;
                    while (!double.TryParse(Console.ReadLine(), out num1))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\t\t\t\t\tInvalid Input. Please enter a valid number:\t");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\t\t\t\t\tEnter Second Number:\t");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    double num2;
                    while (!double.TryParse(Console.ReadLine(), out num2))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\t\t\t\t\tInvalid Input. Please enter a valid number:\t");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    double result = num1 * num2;
                    string record = $"{num1} * {num2} = {result}";
                    history.Add(record);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\n\t\t\t\t\tThe Result is: " + result + "\t");
                    Console.WriteLine("\t\t\t\t\t___________________________");
                }
                else if (operation == "/" || operation == "4")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\t\t\t\t\tWelcome to Division Program");
                    Console.WriteLine("\t\t\t\t\t=====================================");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\t\t\t\t\tEnter First Number:\t");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    double num1;
                    while (!double.TryParse(Console.ReadLine(), out num1))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\t\t\t\t\tInvalid Input. Please enter a valid number:\t");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\t\t\t\t\tEnter Second Number:\t");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    double num2;
                    while (!double.TryParse(Console.ReadLine(), out num2))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\t\t\t\t\tInvalid Input. Please enter a valid number:\t");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    if (num2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\t\t\t\t\tError:Division by zero is not possible");
                    }
                    else
                    {
                        double result = num1 / num2;
                        string record = $"{num1} / {num2} = {result}";
                        history.Add(record);
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("\t\t\t\t\tThe Result is: " + result);
                        Console.WriteLine("\t\t\t\t\t___________________________");
                    }
                }
                else if (operation == "%" || operation == "5")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\t\t\t\t\tWelcome to Modulus Program");
                    Console.WriteLine("\t\t\t\t\t=====================================");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\t\t\t\t\tEnter First Number:\t");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    double num1;
                    while (!double.TryParse(Console.ReadLine(), out num1))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\t\t\t\t\tInvalid Input. Please enter a valid number:\t");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\t\t\t\t\tEnter Second Number:\t");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    double num2;
                    while (!double.TryParse(Console.ReadLine(), out num2))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\t\t\t\t\tInvalid Input. Please enter a valid number:\t");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    double result = (num1 / num2) * 100;
                    string record = $"{num1} % {num2} = {result}";
                    history.Add(record);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\t\t\t\t\tThe Result is: " + result);
                    Console.WriteLine("\t\t\t\t\t___________________________");
                }
               else if(operation == "6")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\t\t\t\t\tWelcome to Square Program");
                    Console.WriteLine("\t\t\t\t\t=====================================");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\t\t\t\t\tEnter Number:\t");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    double num;
                    while (!double.TryParse(Console.ReadLine(), out num))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\t\t\t\t\tInvalid Input. Please enter a valid number:\t");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    double result = num * num;
                    string record = $"Square of {num} = {result}";
                    history.Add(record);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\t\t\t\t\tThe Result is: " + result);
                    Console.WriteLine("\t\t\t\t\t___________________________");
                }
               else if(operation == "7")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\t\t\t\t\tWelcome to Cube Program");
                    Console.WriteLine("\t\t\t\t\t=====================================");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\t\t\t\t\tEnter Number:\t");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    double num;
                    while (!double.TryParse(Console.ReadLine(), out num))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\t\t\t\t\tInvalid Input. Please enter a valid number:\t");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    double result = num * num * num;
                    string record = $"Cube of {num} = {result}";
                    history.Add(record);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\t\t\t\t\tThe Result is: " + result);
                    Console.WriteLine("\t\t\t\t\t___________________________");
                }
               else if(operation == "8") {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\t\t\t\t\tWelcome to Square Root Program");
                    Console.WriteLine("\t\t\t\t\t=====================================");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\t\t\t\t\tEnter Number:\t");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    double num;
                    while (!double.TryParse(Console.ReadLine(), out num)|| num <0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\t\t\t\t\tInvalid Input. Please enter a valid number:\t");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    
                    double result = Math.Sqrt(num);
                    string record = $"Square Root of {num} = {result}";
                    history.Add(record);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\t\t\t\t\tThe Result is: " + result);
                    Console.WriteLine("\t\t\t\t\t___________________________");
                }
               else if(operation == "9")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\t\t\t\t\tWelcome to Power Program");
                    Console.WriteLine("\t\t\t\t\t=====================================");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\t\t\t\t\tEnter Base Number:\t");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    double baseNum;
                    while(!double.TryParse(Console.ReadLine(),out baseNum))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\t\t\t\t\tInvalid Input. Please enter a valid number:\t");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\t\t\t\t\tEnter Exponent Number:\t");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    double exponentNum;
                    while(!double.TryParse(Console.ReadLine(),out exponentNum))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\t\t\t\t\tInvalid Input. Please enter a valid number:\t");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    double result = Math.Pow(baseNum, exponentNum);
                   string record = $"{baseNum} ^ {exponentNum} = {result}";
                    history.Add(record);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\t\t\t\t\tThe Result is: " + result);
                    Console.WriteLine("\t\t\t\t\t___________________________");
                }
               else if(operation == "10")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\t\t\t\t\tWelcome to Log program");
                    Console.Write("\t\t\t\t\t=============================");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Enter Your Number\t");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    double num;
                    while(!double.TryParse(Console.ReadLine(),out num))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Invalid Output:Please Enter Correct Input\t");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    double result = Math.Log(num);
                    string record = $"log10{num} = {result}";
                    history.Add(record);
                    Console.WriteLine("\t\t\t\t\tThe result is" + result);
                    Console.WriteLine("__________________________");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t\t\t\t\tInvalid Operation Selected");
                }

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("\n\t\t\t\t\tThanks For Using Calculator App");
                Console.WriteLine("\t\t\t\t\t=====================================");
                Console.Write("\t\t\tDo you want to see Calculation History? (type 'yes' to view or 'no' to skip)\t");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                operation = Console.ReadLine();
                if (operation == "yes")
                {
                    Console.WriteLine("\n\t\t\t\t\tCalculation History:");
                    if (history.Count == 0)
                    {
                        Console.WriteLine("\t\t\t\t\tNot History Yet");
                    }
                    else
                    {
                        foreach (string entry in history)
                        {
                            Console.WriteLine("\t\t\t\t\t"+entry);
                        }
                    }
                }

                Console.Write("\n\n\t\t\t\t\tDo yo want to use Calculator\t");
                response = Console.ReadLine();
                Console.Clear();

            }
            while (response != "yes")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t\t\t\t\tThank You for Visiting Calculator App");
                break;
            }
            Console.ReadKey();

        }
    }
}
