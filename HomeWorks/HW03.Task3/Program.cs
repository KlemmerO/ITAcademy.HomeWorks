using System;

namespace HW03.Task3
{
    class Program
    {
        static void Main(string[] arg)
        {

            Console.WriteLine("Write the year of birth yyyy: ");
            string y = Console.ReadLine();
            int Year = Convert.ToInt32(y);
            Console.WriteLine("Write the month number -m: ");
            string m = Console.ReadLine();
            int Month = Convert.ToInt32(m);     

            Console.WriteLine("Write the today's year yyyy:");
            string u = Console.ReadLine();
            int Date = Convert.ToInt32(u);
            Console.WriteLine("Write the today's month -m:");
            string n = Console.ReadLine();
            int Mes = Convert.ToInt32(n);
            int x = 0;
           if (Mes == Month)
            {
               x = + 1;
            }
            int  Age =  Date - Year + x;
            Console.WriteLine(Age);
            Console.ReadKey();



        }
    }
}
