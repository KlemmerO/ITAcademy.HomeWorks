using System;
using System.ComponentModel.DataAnnotations;

namespace HM_06.Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "I am from this World";
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();
            string[] str = input.Split(new Char[] { ' ', ',', '.', ':', '!', '?', ';' }, StringSplitOptions.RemoveEmptyEntries);
            int maxlen = 0, index = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length > maxlen)
                {
                    maxlen = str[i].Length;
                    index = i;
                }
            }
            Console.Write("Самое длинное слово: {0}", str[index]);
            Console.ReadLine();
            //Console.WriteLine(str.Remove(MaxLengthAttribute));
        }
    }
}
