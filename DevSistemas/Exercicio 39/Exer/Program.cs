using System;

namespace Exer
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto, descriptografia = "";
            Console.WriteLine("Entre com a mensagem para ser descriptografada");

            texto = Console.ReadLine().ToLower();

            for(int t = 0; t < texto.Length; t++)
            {
                int ASCII = (int) texto[t];
                int ASCIIC = ASCII - 4;
                descriptografia += Char.ConvertFromUtf32(ASCIIC);
            }
            Console.WriteLine($"Resultado = {descriptografia}");
        }
    }
}
