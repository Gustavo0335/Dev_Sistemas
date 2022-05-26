using System;

namespace Exer
{
    class Program
    {
       public Program()
        {
            byte? exercicio = null;
            while (exercicio !=0)
            {
                Console.WriteLine("Imforme o número do exercício que deseja executar:");

                if(Byte.TryParse(Console.ReadLine(), out byte auxExercicio))
                {
                    exercicio = auxExercicio;
                } 
                else
                {
                    Console.WriteLine("Não foi possivel fazer a conversão. \nInforme um valor númerico inteiro");
                    continue;
                }

                switch (exercicio)
                {
                    case 1:
                    Console.WriteLine("Digite seu Nome:");
                     string Nome=Console.ReadLine();
                    Console.WriteLine("Digite sua Idade:");
                     string Idade=Console.ReadLine();
                    Console.WriteLine($"{Nome} você tem {Idade} anos");
                    Exercicio01(Nome, Idade);
                    break;
                    
                    case 2:
                    int QuantiMin, QuantiMax, soma, QuantiMed;
                    Console.WriteLine("Digite o estoque Minimo!");
                    QuantiMin = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o estoque máximo!");
                    QuantiMax = Convert.ToInt32(Console.ReadLine());
                    soma = (QuantiMin+QuantiMax);
                    Convert.ToInt32(QuantiMed = soma /2);
                    Console.WriteLine($"o estoque médio é {QuantiMed}"); 
                    Exercicio02(QuantiMed);
                    break;

                    case 3:
                    int Base, altura, multi;
                    decimal area;
                    Console.WriteLine("Digite a base");
                    Base = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite a Altura");
                    altura = Convert.ToInt32(Console.ReadLine());
                    multi = (Base * Altura); 
                    area = Convert.ToDecimal(multi/2F); 
                    Console.WriteLine($"area do triangulo é igual a : {area}");
                    Exercicio03(area);
                    break;

                    case 4:
                    float valor1, valor2, soma, resultado;
                    Console.WriteLine("Digite o primeiro valor!");
                    valor1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo valor!");
                    valor2 = float.Parse(Console.ReadLine());
                    soma = valor1 + valor2;
                    resultado = soma * valor1;
                    Console.WriteLine($"O primeiro número lido foi {valor1} , o segundo número lido foi {valor2}. O resultado final é: {resultado}");
                    Exercicio04(valor1, valor2, resultado);
                    break;

                    case 5:
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
                    valormedio = auxvalormedio;
                    parteinteira = Convert.ToInt32(auxvalormedio);
                    Console.WriteLine($"Soma: {total} Média: {valormedio} Parte Inteira: {parteinteira} Carácter: a ");
                    Exercicio05(total, valormedio, parteinteira);
                    break;

                    case 6:
                    Console.WriteLine("Informe a idade");
                    string auxidade = Console.ReadLine();
                    short idade = short.Parse(auxidade);

                     if( idade < 12)
                     {
                      Console.WriteLine("Criança!!!");
                     }
                     {
                     {
                     }
                     }
                     if(idade >= 17)
                     {
                      Console.WriteLine("Adolecente!!!");
                     }
                     else
                     {
                     }
                     if(idade >= 18)
                     {
                      Console.WriteLine("Adulto!!!");
                     }
                     else
                     {
                     }
                     Exercicio06(idade);
                     break;

                    case 7: 
                   int nota1, nota2, nota3, nota4, nota5, soma;
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
                   Exercicio07(MediaFinal);
                   break;

                   case 8:
                   double valor, aux1, aux2, aux3, aux4;
                   Console.WriteLine("Digite o Valor da nota fiscal");
                   valor = Convert.ToDouble(Console.ReadLine());
         
                   if(valor <=999)
                   {
                   aux1 = Convert.ToDouble(valor * 2 /100);
                   Console.WriteLine($"O preço de 2% do imposto é {aux1}");
                   {
                   }
                   if(valor >= 1000 && valor <= 2999)
                   {
                   aux2 = Convert.ToDouble(valor * 2.5 /100);
                   Console.WriteLine($"O preço de 2,5% do imposto é {aux2}");
                   }
                   else
                   {
                   }
                   if(valor >= 3000 && valor <= 6999);
                   {
                   aux3 = Convert.ToDouble(valor * 2.8 /100);
                   Console.WriteLine($"O preço de 2,8% do imposto é {aux3}");
                   }
         
                   if(valor >= 7.000)
                   {
                   aux4 = Convert.ToDouble(valor * 3 /100 );
                   Console.WriteLine($"O preço de 3% do imposto é {aux4}");
                   }
                   else
                   {
                   }
                   }
                   Exercicio08(valor);
                   break;


                   case 9:
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
                   Exercicio09(valor1, valor2);
                   break;
                   
                   case 10:
                   int valor = 15;
                   string mensagem;
                   Console.WriteLine(valor > 10 ?  "maior que dez" : "Menor que dez");
                   Exercicio10(valor, mensagem);
                   break;

                   case 11:
                   for(int i = 10; i >= 0; i--)
                   {
                   double aux1 = (double) i;
                   double divis = aux1 / 4;
                   int inte = (int) aux1/ 4;
                   float fraci = (float) aux1 % 4f;
                   int div = (int) aux1 % 4;
                   Console.WriteLine(i);
                   Console.WriteLine(divis);
                   Console.WriteLine(inte);
                   Console.WriteLine(fraci);
                   Console.WriteLine(div);
                   }
                   Exercicio11(div);
                   break;
         
     


                    }
                }       
            }
        }
        public void Exercicio01(string nome, string idade)
        {
            Console.WriteLine($" \n{nome} você tem {idade} anos.");
        }
        public void Exercicio02(int QuantiMed)
        {
            Console.WriteLine($"o estoque médio é {QuantiMed}");
        }
        static void Main(string[] args)
        {
            new Program();
    }
} 

