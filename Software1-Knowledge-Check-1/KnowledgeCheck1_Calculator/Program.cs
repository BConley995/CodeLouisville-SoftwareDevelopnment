using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            string continueChoice;

            do
            {
                Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("Enter 2 integers to add");
                        (int addNumOne, int addNumTwo) = ReadTwoIntegers();
                        if (addNumOne != 0 || addNumTwo != 0)
                        {
                            Console.Write($"{addNumOne} + {addNumTwo} = ");
                            Console.Write(calculator.Add(addNumOne, addNumTwo));
                        }
                        break;

                    case "2":
                        Console.WriteLine("Enter 2 integers to subtract");
                        (int subNumOne, int subNumTwo) = ReadTwoIntegers();
                        if (subNumOne != 0 || subNumTwo != 0)
                        {
                            Console.Write($"{subNumOne} - {subNumTwo} = ");
                            Console.Write(calculator.Subtract(subNumOne, subNumTwo));
                        }
                        break;

                    case "3":
                        Console.WriteLine("Enter 2 integers to multiply");
                        (int multNumOne, int multNumTwo) = ReadTwoIntegers();
                        if (multNumOne != 0 || multNumTwo != 0)
                        {
                            Console.Write($"{multNumOne} X {multNumTwo} = ");
                            Console.Write(calculator.Multiply(multNumOne, multNumTwo));
                        }
                        break;

                    case "4":
                        Console.WriteLine("Enter 2 integers to divide");
                        (double divNumOne, double divNumTwo) = ReadTwoDoubles();
                        if (divNumOne != 0 || divNumTwo != 0)
                        {
                            Console.Write($"{divNumOne} / {divNumTwo} = ");
                            Console.Write(calculator.Divide(divNumOne, divNumTwo));
                        }
                        break;

                    default:
                        Console.WriteLine("Unknown input");
                        break;
                }
                Console.WriteLine("\nWould you like to perform another calculation?\nNOTE *** Any option other than Y or Yes will close the program");
                continueChoice = Console.ReadLine().ToUpper();
            }
            while (continueChoice == "Y" || continueChoice == "YES");
        }


        static (int, int) ReadTwoIntegers()
        {
            var number1 = Console.ReadLine();
            var number2 = Console.ReadLine();

            if (int.TryParse(number1, out int numOne) && int.TryParse(number2, out int numTwo))
            {
                return (numOne, numTwo);
            }
            else
            {
                Console.WriteLine("One or more of the numbers is not an int");
                return (0, 0); // Handle this case appropriately
            }
        }

        static (double, double) ReadTwoDoubles()
        {
            var number1 = Console.ReadLine();
            var number2 = Console.ReadLine();

            if (double.TryParse(number1, out double numOne) && double.TryParse(number2, out double numTwo))
            {
                return (numOne, numTwo);
            }
            else
            {
                Console.WriteLine("One or more of the numbers is not a valid double");
                return (0, 0); // Handle this case appropriately
            }
        }
    }
}
