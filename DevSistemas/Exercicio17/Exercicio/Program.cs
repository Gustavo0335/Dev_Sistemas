using System;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
          int nota1, nota2, nota3, nota4, nota5;
          int soma;
          double MediaFinal;
          Console.WriteLine("Informe a Primeira Nota");
          nota1 = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Informe a Segunda Nota");
          nota2 = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Informe a Terceira Nota");
          nota3 = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Informe a Quarta Nota");
          nota4 = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Informe a Quinta Nota");
          nota5 = Convert.ToInt32(Console.ReadLine());
          soma = nota1 + nota2 + nota3 + nota4 + nota5;
          MediaFinal = Convert.ToDouble(soma / 5F);

          if(MediaFinal >= 7)
          {
          Console.WriteLine("Aprovado");
          }
          else
          {
          }
          if(MediaFinal < 7 && MediaFinal >= 4)
          {
              Console.WriteLine("Em Prova Final");
          }
          else
          {
          }
          if(MediaFinal < 4)
          {
              Console.WriteLine("Reprovado");
          }
          else
          {
          }
        }
    }
}
