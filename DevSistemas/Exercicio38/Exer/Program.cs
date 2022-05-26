using System;

namespace Exer
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto, criptografia = "";
            Console.WriteLine("Digite um texto para ser criptografado!");
            texto = Console.ReadLine().ToLower();

            for(int t = 0; t < texto.Length; t++)
            {
                int ASCII = (int) texto[t];
                int ASCIIC = ASCII + 4;

                criptografia += Char.ConvertFromUtf32(ASCIIC);
            }
            Console.WriteLine($"Resultado = {criptografia}");
        }
    }
}
