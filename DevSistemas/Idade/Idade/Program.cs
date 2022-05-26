using System;

namespace Idade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a idade");
            String auxidade = Console.ReadLine();
            short idade = short.Parse(auxidade);

        if( idade >= 3 && idade <= 12)
        {
            Console.WriteLine("Criança!!!");
        }
        {
        {
        }
        }
        if(idade >= 13 && idade <= 17)
        {
            Console.WriteLine("Adolecente!!!");
        }
        else
        {
        }
         if(idade >= 18)
         {
             Console.WriteLine("Adulto!!!");
         }
         else
         {
         }
       }   
    } 
}
