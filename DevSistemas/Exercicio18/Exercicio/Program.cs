using System;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
        double valor, aux1, aux2, aux3, aux4;
        Console.WriteLine("Digite o Valor da nota fiscal");
         valor = Convert.ToDouble(Console.ReadLine());
         if(valor <= 0 && valor <=999)
         {
          aux1 = Convert.ToDouble(valor * 2 /100);
          Console.WriteLine($"O preço de 2% do imposto é {aux1}");
         {
         }
         if(valor >= 1000 && valor <= 2999)
         {
             aux2 = Convert.ToDouble(valor * 2.5 /100);
             Console.WriteLine($"O preço de 2,5% do imposto é {aux2}");
         }
         else
         {
             Console.WriteLine(!passed);
         }
         if(valor >= 3000 && valor <= 6999);
         {
             aux3 = Convert.ToDouble(valor * 2.8 /100);
          Console.WriteLine($"O preço de 2,8% do imposto é {aux3}");
         }
         
         if(valor >= 7.000)
         {
             aux4 = Convert.ToDouble(valor * 3 /100 );
             Console.WriteLine($"O preço de 3% do imposto é {aux4}");
         }
         else
         {
         }
         }
         
        }
    }
}