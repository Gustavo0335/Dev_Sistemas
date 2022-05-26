using System;

namespace Exer
{
    class Program
    {
        static void Main(string[] args)
        {
            var array3D = new int[5, 10, 7]; 
            var random = new Random();
            var Soma = 0;
            var Media = 0;

            for (int i = 0; i < array3D.GetLength(0); i++)
            {
            for (int x = 0; x < array3D.GetLength(1); x++)
            {
            for (int y = 0; y < array3D.GetLength(2); y++)
            {
            array3D[i, x, y] = random.Next();
            Soma += array3D[i, x, y];
            Media = Soma / array3D.Length;
            }
            }

            }
            Console.WriteLine($"Soma = {Soma}, Media = {Media}");
        }
    }
}
