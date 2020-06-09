using System;

namespace HW04.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue, result, prop;
            string action;
            Console.WriteLine("Write number 1:");
            firstValue = Double.Parse(Console.ReadLine());
            Console.WriteLine("Write number 2:");
            secondValue = Double.Parse(Console.ReadLine());
            Console.WriteLine("Mathematic operations: ");
            action = Console.ReadLine();
                       
            switch (action)
            {
                case "+":
                    Console.WriteLine(result = firstValue + secondValue);
                    break;
                case "-":
                    Console.WriteLine(result = firstValue - secondValue);
                    break;
                case "*":
                    Console.WriteLine(result = firstValue * secondValue);
                    break;
                case "/":
                    if (secondValue == 0)
                    {
                        Console.WriteLine(0);
                    }
                    else
                    Console.WriteLine(result = firstValue / secondValue);
                    break;                    
                default:
                    Console.WriteLine("Unknown Error!");
                    break;
                    }
            Console.WriteLine("Write the results:");
            prop = Convert.ToInt32(Console.ReadLine());           
            if (prop == result)
                Console.WriteLine("Correct");

            else if (prop > result)
                Console.WriteLine("Uncorrect, should be less");

            else if (prop < result)
                Console.WriteLine("Uncorrect, should be more");

            Console.ReadKey();
        }
    }
}
