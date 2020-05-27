using System;

namespace MiniProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 10;
            int sum = num1 - num2;

            Console.WriteLine("Hello World!");
            Console.WriteLine("Please input a first number");

            string inputedNum1 = Console.ReadLine();
            int num3 = Int32.Parse(inputedNum1);

            Console.WriteLine("Please enter a second number");

            string inputedNum2 = Console.ReadLine();
            int num4 = Int32.Parse(inputedNum2);

            Console.WriteLine("Please choose what type of math operation you want to do (1 - Add, 2 - Substract, 3 -Multiply, 4 -Divide)");
            
            string inputedOperat = Console.ReadLine();
            int num5 = Int32.Parse(inputedOperat);

            switch (num5)
            {
                case 1:
                    Console.WriteLine(num3 + num4);
                    break;
                case 2:
                    Console.WriteLine(num3 - num4);
                    break;
                case 3:
                    Console.WriteLine(num3 * num4);
                    break;
                case 4:
                    Console.WriteLine(num3 / num4);
                    break;
                default:
                    Console.WriteLine("Please choose one of the Math operations");
                    break;
            }
        }
    }
}
