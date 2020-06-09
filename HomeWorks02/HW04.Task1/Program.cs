using System;
using System.Security.Cryptography.X509Certificates;

namespace HW04.Task1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Write number:");
            string x = Console.ReadLine();
            int Number1 = Convert.ToInt32(x);
            Console.WriteLine("Write number:");
            string y = Console.ReadLine();
            double Number2 = Convert.ToInt32(y);
            double Summe = Number1 + Number2;
            Console.WriteLine(Summe);
            Console.ReadKey();
         }
    }
}
