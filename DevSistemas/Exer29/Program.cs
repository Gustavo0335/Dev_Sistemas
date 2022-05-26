using System;

namespace Exer29
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] array = new int [10];

           for(int i = 0; i < array.Length; i++)
           {
               Console.WriteLine($"Digite o numero:{i+1}");
               array[i]= int.Parse(Console.ReadLine());
           }
           foreach(var valor in array)
           {
               Console.WriteLine(valor);
           }
           decimal media = default;
           foreach(var valor in array)
           {
               Console.WriteLine(valor);
           }
           media /= array.Length;
           decimal [] array2 = new decimal [array.Length];

           for(int i = 0; i < array2.Length; i++)
           {
               array2[i] = array[1] * media;
               media = array2.Length;
           }
           Console.WriteLine($"media: {media}");
        }
    }
}
