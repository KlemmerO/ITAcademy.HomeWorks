using System;

namespace AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            int time;
            int uniform = Motocycle.uniform;
            Motocycle relocation = new Motocycle();
            result = relocation.FindMovement(300);
            time = result / uniform;  
            Console.WriteLine(time);
            Console.ReadKey();
        }
    }
}
