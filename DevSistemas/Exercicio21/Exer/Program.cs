using System;

namespace Exer
{
    class Program
    {
        static void Main(string[] args)
        {
           
           for(int i = 10; i >= 0; i--)
           {
            double aux1 = (double) i;
            double divis = aux1 / 4;
            int inte = (int) aux1/ 4;
            float fraci = (float) aux1 % 4f;
            int div = (int) aux1 % 4;
            Console.WriteLine($"{i}/4");
            Console.WriteLine(divis);
            Console.WriteLine(inte);
            Console.WriteLine(fraci);
            Console.WriteLine(div);
           }
        }
    }
}
