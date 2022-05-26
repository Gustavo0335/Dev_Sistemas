using System;

namespace ExemploBreakProblema
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i <=500000; i++)
            {

                if ( (i !=49) && (i % 49==0) )
                {

                    Console.WriteLine("O primeiro número divisível por 49 que não seja ele mesmo é:" +i);

                }
            }
        }
    }
}
