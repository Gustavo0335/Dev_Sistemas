using System;

namespace MediaFinal
{
    class Program
    {
        static void Main(string[] args)
        {
          int nota1, nota2, nota3, nota4;
          int soma;
          double MediaFinal;
          string nome = "Luiz";
          nota1 = 9;
          nota2 = 7;
          nota3 = 8;
          nota4 = 10;
          soma = nota1 + nota2 + nota3 + nota4;
          MediaFinal = soma / 4F;
          Console.WriteLine( nome + ",sua média final é: " + MediaFinal);
          Console.WriteLine($" {nome}, sua média final é {MediaFinal} ");

        }
    }
}
