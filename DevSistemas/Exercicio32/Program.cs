using System;

namespace Exercicio32
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] horario = new string [5];
            string [] data = new string [5];
            string [] descricao = new string [5];
            for(int c = 0; c <= 4; c++)
            {
                Console.WriteLine("Digite o horario do compromisso em horas/minutos/segundos");
                horario[c]= Console.ReadLine();
                Console.WriteLine("Digite a data : Dia/Mes/Ano");
                data[c] = Console.ReadLine();
                Console.WriteLine("Digite a descrição do compromisso");
                descricao[c] = Console.ReadLine(); 
            }
            foreach(string horas in horario)
            {
                Console.WriteLine($"horario: {horas}");
            }
            foreach(string datas in data)
            {
                Console.WriteLine($"Data: {datas}");
            }
            foreach(string tipo in descricao)
            {
                Console.WriteLine($"Descrição: {tipo}");
            }
        }
    }
}
