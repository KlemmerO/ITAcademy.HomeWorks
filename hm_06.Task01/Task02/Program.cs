using System;
using System.Runtime.CompilerServices;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Remove result = new Remove;
            string input = "righteousness fidelity loylity freedom";
            string[] str = input.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int maxlen = 0, index = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length > maxlen)
                {
                    maxlen = str[i].Length;
                    index = i;
                }
            }
            Console.WriteLine("The longest world: {0}", str[index]);
            Console.ReadLine();
        }
        public static void MaxValue()
        {
        
        }

    }
}
