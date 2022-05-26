using System;

namespace EstoqueMedio
{
    class Program
    {
        static void Main(string[] args)
        {
            int QuantiMin;
            int QuantiMax;
            int soma;
            int QuantiMed;
            Console.WriteLine("Digite o estoque Minimo!");
            QuantiMin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o estoque máximo!");
            QuantiMax = Convert.ToInt32(Console.ReadLine());
            soma = (QuantiMin+QuantiMax);
            Convert.ToInt32(QuantiMed = soma /2);
            

             Console.WriteLine($"o estoque médio é {QuantiMed}"); 
        }
    }
}
