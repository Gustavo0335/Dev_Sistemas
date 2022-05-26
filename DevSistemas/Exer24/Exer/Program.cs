using System;

namespace Exer
{
    class Program
    {
        static void Main(string[] args)
        {
            for( int i = 1; i <= 100000; i++)
            {
             if( i % 11 == 0)
             {
             if( i % 13 == 0)
             {
             if(i % 17 == 0)
             {
                 Console.WriteLine(i);
                 break;
             }
             }
             }
            }
        }
    }
}
