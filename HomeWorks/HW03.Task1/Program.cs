using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HW03.Task1
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

            Console.WriteLine("Write number:");
            string y = Console.ReadLine();
            int Num4 = Convert.ToInt32(y);
            Console.WriteLine("Write number:");
            string y2 = Console.ReadLine();
            int Num5 = Convert.ToInt32(y2);
            int Num6 = Num4 - Num5;
            Console.WriteLine(Num6);
            
            Console.WriteLine("Write number:");
            string a = Console.ReadLine();
            int Faktor1 = Convert.ToInt32(a);
            Console.WriteLine("Write number:");
            string b = Console.ReadLine();
            int Faktor2 = Convert.ToInt32(b);
            int Produktc = Faktor1 * Faktor2;
            Console.WriteLine(Produktc);
            
            Console.WriteLine("Write number:");
            string k = Console.ReadLine();
            int Dividend = Convert.ToInt32(k);
            Console.WriteLine("Write number:");
            string s = Console.ReadLine();
            int Divisor = Convert.ToInt32(s);
            int Quotient = Dividend / Divisor;
            Console.WriteLine(Quotient);

            Console.WriteLine("Write number:");
            string t = Console.ReadLine();
            int Faktor3 = Convert.ToInt32(t);            
            int Prozent = Quotient % Faktor3;
            Console.WriteLine(Prozent);

            Console.WriteLine("Write number:");
            string r = Console.ReadLine();
            double Radius = Convert.ToInt32(r);
            double Mult = Radius * Radius;         
            double Area = Math.PI * Mult;
            Console.WriteLine(Area);
            Console.ReadKey();

          
        }
    }
}
