using System;

namespace AgoraEuEntendo
{
    class Program
    {
        static void Main(string[] args)
        {
            byte valor1;
            short valor2;
            int valor3;
            long valor4;
            float valor5;
            double total;
            decimal valormedio;
            char parteinteira;
            Console.WriteLine("Digite o primeiro valor");
            valor1 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor");
            valor2 = short.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro valor");
            valor3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o quarto valor");
            valor4 = long.Parse(Console.ReadLine());
            Console.WriteLine("Digite o quinto Valor");
            valor5 = float.Parse(Console.ReadLine());
            total = Convert.ToDouble(valor1 + valor2 + valor3 + valor4 + valor5);
            valormedio = Convert.ToDecimal (total /5);
             //Armazenar em char uma variavel decimal convertendo para inteira 
             Convert.ToInt32(valormedio);
            parteinteira = (int) (valormedio);

            //Fim do código
            Console.WriteLine($"Soma: {total} Média: {valormedio} Parte Inteira: {parteinteira} Carácter: a ");
        }
    }
}
