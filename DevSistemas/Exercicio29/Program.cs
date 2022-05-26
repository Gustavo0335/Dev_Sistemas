using System;

namespace Exercicio29
{
    class Program
    {
        static void Main(string[] args)
        {
         var array = new int [50];
         var random = new Random();
         random.Next();
         int menorNumero;
         int posicaoMenorNumero;
         int maiorNumero;
         int posicaoMaiorNumero;

         for(int a = 0; a < array.Length; a++)
         {
         for(int b = 0; b < array.Length; b++)
         {
         if(array[a] <= array[b]) 
         {
         menorNumero = array[a];
         posicaoMenorNumero = a;
         } 
         else if(array[a] >= array[b]) 
         {
         maiorNumero = array[a];
         posicaoMaiorNumero = a;
         }
         }
         }
          Console.WriteLine($"Menor numero: {menorNumero} {posicaoMenorNumero}, Maior Numero: {maiorNumero} {posicaoMaiorNumero}");
        }
    }
}
    

