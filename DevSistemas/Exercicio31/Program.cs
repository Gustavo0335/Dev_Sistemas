using System;

namespace Exercicio31
{
    class Program
    {
        static void Main(string[] args)
        {
           int [] num = new int [20];
           for(int i = 0; i < num.Length; i++)
           {
               Console.WriteLine("Digite 20 valores");
               num[i] = int.Parse(Console.ReadLine());
           }
           foreach(var numero in num)
           {
               Console.WriteLine(numero);
           }

            Array.Reverse(num);

           foreach(var revert in num)
           {
               Console.WriteLine(revert);
           }



        }
    }
}
