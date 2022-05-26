using System;

namespace Exer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira uma palavra");
            string x = Console.ReadLine();
            foreach(var y in x)
            {
                Console.Write($"{y} =");
                int i = (int) y;
                Console.Write($"{i} \n");
            }

            
                  
        }
    }
}
