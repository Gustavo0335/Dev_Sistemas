using System;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
           int valor1, valor2;
           Console.WriteLine(" Informe o Primeiro Valor");
           valor1 = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Informe o Segundo Valor");
           valor2 = Convert.ToInt32(Console.ReadLine());
            if(valor1 >= 0 && valor2 <= 100)
            {
            }
            if(valor1 < 0 && valor2 > 100)
            {
                Console.WriteLine("valor1, esta fora da faixa de valor permitida");
            }
            if(valor2 < valor1)
            {
                Console.WriteLine("Errou! Deveria ter digitado um valor maior");
            }
            if(valor2 > valor1)
            {
                Console.WriteLine("Errou! Deveria ter digitado um valor menor");
            }
            if(valor1 == valor2)
            {
                Console.WriteLine("Parabens! você acertou o numero!");
            }
           }
        }
    }
