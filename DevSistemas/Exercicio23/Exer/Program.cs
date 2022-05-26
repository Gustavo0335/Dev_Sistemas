using System;

namespace Exer
{
    class Program
    {
        static void Main(string[] args)
        {
           for(int i = 0; i <= 10; i++)
           {
               int total = i + i;
               if(i % 3 == 0)
               {
                  Console.WriteLine($"Descartado:{i}");
                  continue;
               }
                  if(i % 5 == 0)
                  { 
                  Console.WriteLine($"Descartado:{i}");
                  continue;
                  }
              
               Console.WriteLine($"Valor atual:{i} , Total:{total}");
               continue;
           }
        }
    }
}
