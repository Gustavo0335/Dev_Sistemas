using System;

namespace Exer
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            var array = new int [50];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0 , 49);
                var MenorValor = int.MinValue;
                var soma = 0;
                var media = 0;
                var MaiorValor = int.MaxValue;
                var posicaoMV = 0;
                var posicaoVM = 0;
              if(50 > array[i])
              {
                MaiorValor = 50;
                posicaoMV = array[0];
              }
              if(2 < array[i])
              {
                MenorValor = 2;
                 posicaoVM = array[49];
              }
            
              foreach(var numero in array)
              {
                soma += numero;
                media = soma / array.Length; 
              }
                Console.WriteLine($"Menor valor: {MenorValor} Posição ={posicaoVM}, Maior valor: {MaiorValor} Posição = {posicaoMV}, Média: {media}");
            }
        }
    }
}
