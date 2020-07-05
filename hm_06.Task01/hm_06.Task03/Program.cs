using System;

namespace hm_06.Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Solution");
            sb4.Clear();
            sb4.Append("1++2++3++4++5");
            sb4.Replace("++", "--", 0, 7); // в диапазоне от 0 до 7
            Console.WriteLine("sb4 = {0}", sb4); // sb4 = 1--2--3++4++5
        }
    }
}
