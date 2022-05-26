using System;

namespace ABCBolinhasTEST
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;
            for (int i = 0; i <= 10; i++)
            {
                if(i % 2 == 0)
                {
                    i = valor;
                    Console.WriteLine($"{valor}");
                    break;
                }
            }
           



        }
    }
}
