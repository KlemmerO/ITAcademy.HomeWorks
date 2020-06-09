using System;

namespace HW04.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator empty = new Calculator();
            Console.WriteLine("Write number:");
            string x = Console.ReadLine();
            int Num1 = Convert.ToInt32(x);
            Console.WriteLine("Write number:");
            string x2 = Console.ReadLine();
            int Num2 = Convert.ToInt32(x2);
            int Num3 = Num1 + Num2;
            Console.WriteLine(Num3);
        }
    }
}
