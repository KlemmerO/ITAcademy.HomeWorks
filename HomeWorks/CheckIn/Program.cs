using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CheckIn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Your Passport Number");
            string text = Console.ReadLine();
            int x = Convert.ToInt32(text);
            Greetings greeting = new Greetings();     
            List<Passenger> passengers1 = new List<Passenger>();
            passengers1.Add(new Passenger("Vadzim Papko"));
            List<Passenger> passengers2 = new List<Passenger>();
            passengers2.Add(new Passenger("Olga Klemmer"));
            List<Passenger> passengers3 = new List<Passenger>();
            passengers3.Add(new Passenger("Vasja Pupkin"));
            List<Passenger> passengers4 = new List<Passenger>();
            passengers4.Add(new Passenger("False Number"));        
            if (x == 1)
            {
                foreach (var client in passengers1)
                {
                    Console.WriteLine($"Name:{client.FullName} ");
                }
            }
            if (x == 2)
            {
                foreach (var client in passengers2)
                {
                    Console.WriteLine($"Name:{client.FullName}");
                }   
            }
            if (x == 3)
            {
                foreach (var client in passengers3)
                {
                    Console.WriteLine($"Name:{client.FullName}");
                }
            }

            if (x >= 4 || x<= 0)
            {
                foreach (var client in passengers3)
                {
                    Console.WriteLine($"Name:{client.FullName}");
                }
            }
        }        
    }
}


