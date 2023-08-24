using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace calcul
{
    class calclator
    { public static double DoOperation(double num1, double num2, String op)
        {
            double result = double.NaN;
            switch (op)
            {
                case "a":
                    result = num1 + num2;
                    break;
                case "s":
                    result = num1 - num2;
                    break;
                case "m":
                    result = num1 * num2;
                    break;
                case "d":
                    if (num2 != 0) {
                        result = num1 / num2;
                    }

                    break;
                default:
                    break;

            }
            return result;
        }
    }
    class program {
        static void Main(string[] args)
        {
            bool endApp = false;
            Console.WriteLine("console calculator in c#\r");
            Console.WriteLine("---------------");
            while (!endApp)
            {
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;
                Console.WriteLine("type a number and then press enter");
                numInput1 = Console.ReadLine();
                double cleannum1 = 0;
                while (!double.TryParse(numInput1, out cleannum1))
                {
                    Console.WriteLine("this not valid input, please enter an integr value");
                    numInput1 = Console.ReadLine();
                }
                Console.WriteLine("type another number and then press enter");
                numInput2 = Console.ReadLine();
                double cleannum2 = 0;
                while (!double.TryParse(numInput2, out cleannum2))
                {
                    Console.WriteLine("this not valid input, please enter an integr value");
                    numInput2 = Console.ReadLine();
                }
                Console.WriteLine("choose an operator fromthe following list :");
                Console.WriteLine("\ta- add");
                Console.WriteLine("\ts-substract");
                Console.WriteLine("\tm- multiply");
                Console.WriteLine("\td- divide");
                Console.WriteLine("your option!");
                string op = Console.ReadLine();
                try
                {
                    result = calclator.DoOperation(cleannum1, cleannum2, op);
                        if (double.IsNaN(result))
                    {
                        Console.WriteLine("this operation will result a mathmtical error .\n");
                    }
                    else Console.WriteLine("you result: {0:0.##}\n", result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("oh no there is an exception  ! ");
                    Console.WriteLine(ex.Message);

                }
                Console.WriteLine("------------\n");
                Console.WriteLine("press n to close the app");
                if (Console.ReadLine() == "n")
                    endApp = true;
            }
            return;
        }
    } }
    

