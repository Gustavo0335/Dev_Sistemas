using System;

namespace Exer
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 33;i <= 126; i ++)
          { 
            char cara;
            cara = (char) Convert.ToChar(i);
           Console.WriteLine("Numero:"+i + "Caractere:"+ cara);
          }
        }
    }
}
