using System;

namespace Exer
{
    class Program
    {
        static void Main(string[] args)
        {
          for(int i = 0; i <= 10; i ++)
          {
          if( (i !% 3 == 0) && (i !% 5 == 0) )
          {
          Console.WriteLine($"Valor atual:{i}");
          }
          if( (i % 3 == 0) && (i % 5 == 0) )
          {
            Console.WriteLine($"Descartado: {i}");
            break;
          }
          
          }
        }
    }
}
