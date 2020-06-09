using System;

namespace HW04.Task2
{
    class Program
    {
        static void Main()
        {
            int sum1, sum2, sum3, sum4;
            Console.WriteLine("Write number 1:");
            sum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write number 2:");
            sum2 = Convert.ToInt32(Console.ReadLine());
            sum3 = sum1 + sum2;
            Console.WriteLine("Write the summ of previous numbers:");
            sum4 = Convert.ToInt32(Console.ReadLine());
            if (sum3 == sum4 )
            
                Console.WriteLine("Correct");
                else
                Console.WriteLine("Uncorrect");
            
            Console.ReadKey();
        }
    }
}

