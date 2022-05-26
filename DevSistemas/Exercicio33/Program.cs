using System;

namespace Exercicio33
{
    class Program
    {
        static void Main(string[] args)
        {
         string [] codigo = new string[15];
         string [] estado = new string[15];
         for(int i = 0; i < 14; i++)
         {
             Console.WriteLine("Digite os codigos das peças");
             codigo [i] = Console.ReadLine();

             Console.WriteLine("Digite o estado das peças (aprovado ou reprovado)");
             estado [i] = Console.ReadLine();
         }
         foreach(string codigofinal in codigo)
         {
             Console.WriteLine($" Codigo: {codigofinal}");
         }
         foreach(string estadofinal in estado)
         {
             Console.WriteLine($"Estado: {estadofinal}");
         }
            
            
        }
    }
}
