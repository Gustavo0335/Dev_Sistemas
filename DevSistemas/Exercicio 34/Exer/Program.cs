using System;

namespace Exer
{
    class Program
    {
        static void Main(string[] args)
        {
           int [,] array2D = new int [4, 5];
           var soma = 0;
           var media = 0;
           array2D[0, 0] = 10; 
           array2D[0, 1] = 20;
           array2D[0, 2] = 30;
           array2D[0, 3] = 40;
           array2D[0, 4] = 50;
           array2D[1, 0] = 60; 
           array2D[1, 1] = 70;
           array2D[1, 2] = 80;
           array2D[1, 3] = 90;
           array2D[1, 4] = 10;
           array2D[2, 0] = 15;
           array2D[2, 1] = 20;
           array2D[2, 2] = 25;
           array2D[2, 3] = 30;
           array2D[2, 4] = 35;
           array2D[3, 0] = 40;
           array2D[3, 1] = 45;
           array2D[3, 2] = 50;
           array2D[3, 3] = 55;
           array2D[3, 4] = 60; 

          for (int l = 0; l < array2D.GetLength(0); l++)
          {
            for (int c = 0; c < array2D.GetLength(1); c++)
            {
                soma += array2D[l,c];
            }
          }

         media = soma / array2D.Length;
 
         Console.WriteLine($"Soma: {soma} Média {media}");
        }
    }
}
