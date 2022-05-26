using System;

namespace Exer
{
    class Program
    {
        static void Main()
        {
           int [,] arrayBN = new int [10,10];
           for(int linha = 0; linha = arrayBN.GetLength(0); linha++)
           {
               for(int coluna = 0; coluna = arrayBN.GetLength(1); coluna++)
               {
                   Console.WriteLine("Resultado = {0}", arrayBN[linha,coluna]);
               }
               Console.WriteLine();
           }

        }
    }
}
