using System;

namespace NomeIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu Nome:");
            Console.WriteLine("Digite sua Idade:");

            string Nome=Console.ReadLine();

            string Idade=Console.ReadLine();

            Console.WriteLine($"{Nome} você tem {Idade} anos");

        }
    }
}
