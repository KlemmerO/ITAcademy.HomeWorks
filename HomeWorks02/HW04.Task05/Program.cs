using System;

namespace HW04.Task05
{
    class Program
    {
        static void Main()
        {


            for (byte b = 1; b < 255; b++)
            { 
                if (b < 65 || (b > 90 && b < 97) || (b > 122 && b < 192)) continue;
                if (b % 4 == 0) s += "\n";
                char[] ch = Encoding.GetEncoding(0).GetChars(new byte[] { b });
                label1.Text += ch[0].ToString() + " - " + b.ToString() + "\t";
            }


        }
    }
}
