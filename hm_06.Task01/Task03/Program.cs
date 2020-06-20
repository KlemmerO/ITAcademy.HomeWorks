using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stroke = new StringBuilder("Solution");
            stroke.Clear();
            stroke.Append("1a!2.3!!..4.!.?6 7! ..?");
            stroke.Replace("", "!", 0,15);
            Console.WriteLine("stroke = {0}", stroke);
        }
    }
}
