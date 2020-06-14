using System;
using System.IO;

namespace hm_06.Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the poem into one stroke with semicolon between");
            string data = Console.ReadLine();
            string[] separator = { ";"};
            string[] strokes = data.Split (separator, StringSplitOptions.None);
            foreach (var stroke in strokes)
            Console.WriteLine (stroke.Replace("o", "a"));          
            Console.ReadKey();
        }
    }
}
