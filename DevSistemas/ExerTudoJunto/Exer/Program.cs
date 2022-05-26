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
                Console.WriteLine("Informe o número do exercício que deseja executar:");

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
                    Exercicio02(QuantiMed);
                    break;
                    case 3:
                    Console.WriteLine("Digite a base");
                    int Base = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite a Altura");
                    int alt = Convert.ToInt32(Console.ReadLine());
                    int multi = (Base * alt); 
                    decimal area = Convert.ToDecimal(multi/2F); 
                    Exercicio03(Base, alt, multi, area);
                    break;
                    case 4:
                    Console.WriteLine("Digite o primeiro valor!");
                    float valor1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo valor!");
                    float valor2 = float.Parse(Console.ReadLine());
                    float auxsoma = (valor1 + valor2);
                    float resultado = (auxsoma * valor1);
                    Exercicio04(valor1, valor2, auxsoma, resultado);
                    break;
                    
                    case 5:
                    Console.WriteLine("Digite o primeiro valor");
                    byte valorb = Convert.ToByte(Console.ReadLine());
                    Console.WriteLine("Digite o segundo valor");
                    short valors = short.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o terceiro valor");
                    int valori = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o quarto valor");
                    long valorl = long.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o quinto Valor");
                    float valorf = float.Parse(Console.ReadLine());
                    double total = Convert.ToDouble(valorb + valors + valori + valorl + valorf);
                    decimal valormedio = Convert.ToDecimal (total /5);
                    decimal aux = valormedio;
                    int bat = Convert.ToInt32(aux);
                    char parteinteira = Convert.ToChar(bat);
                    Exercicio05(total, valormedio, parteinteira);
                    break;
                   
                    case 6:
                    Console.WriteLine("Informe a idade");
                    string auxidade = Console.ReadLine();
                    short idade = short.Parse(auxidade);

                     if( idade >=3 && idade <= 12)
                     {
                      Console.WriteLine("Criança!!!");
                     }
                     if(idade >= 13 && idade <= 17)
                     {
                      Console.WriteLine("Adolecente!!!");
                     }
                     if(idade >= 18)
                     {
                      Console.WriteLine("Adulto!!!");
                     }
                     Exercicio06(idade);
                     break; 

                     case 7: 
                   int nota1, nota2, nota3, nota4, nota5, aux1soma;
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
                   aux1soma = nota1 + nota2 + nota3 + nota4 + nota5;
                   MediaFinal = Convert.ToDouble(aux1soma / 5F);
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
                   }
                   Exercicio08(valor);
                   break;

                   case 9:
                   Console.WriteLine(" Informe o Primeiro Valor");
                   int resu1 = Convert.ToInt32(Console.ReadLine());
                   Console.WriteLine("Informe o Segundo Valor");
                   int resu2 = Convert.ToInt32(Console.ReadLine());
                   if(resu1 >= 0 && resu2 <= 100)
                   {
                   }
                   if(resu1 < 0 && resu2 > 100)
                   {
                   Console.WriteLine("valor1, esta fora da faixa de valor permitida");
                   }
                   if(resu2 < resu1)
                   {
                   Console.WriteLine("Errou! Deveria ter digitado um valor maior");
                   }
                   if(resu2 > resu1)
                   {
                   Console.WriteLine("Errou! Deveria ter digitado um valor menor");
                   }
                   if(resu1 == resu2)
                   {
                   Console.WriteLine("Parabens! você acertou o numero!");
                   }
                   Exercicio09(resu1, resu2);
                   break;

                   case 10:
                   int var = 15;
                   string mens;
                   Exercicio10(var);
                   break;
                   case 11:
                   for(int i = 10; i >= 0; i--)
                   {
                   double auxi1 = (double) i;
                   double divis = (double) auxi1 / 4;
                   int inte = (int) auxi1/ 4;
                   float fraci = (float) auxi1 % 4f;
                   int dev = (int) auxi1 % 4;
                   Console.WriteLine($"{i}/4");
                   Console.WriteLine(divis);
                   Console.WriteLine(inte);
                   Console.WriteLine(fraci);
                   Console.WriteLine(dev);
                   
                   Exercicio11(i, divis, inte, fraci, dev);
                   }
                   break;

                   case 12:
                   for(int e = 5; e <= 5; e++)
                   {
                    for(int d = 0; d <= 10; d++)
                    {
                    Console.WriteLine(e + " X " + d + " = " + e * d);
                    Exercicio12(e, d);
                    }
                    } 
                    break;
                    
                    case 13:
                    for(int icog = 0; icog <= 10; icog++)
                    {
                    int total1 = icog + icog;
                    if(icog % 3 == 0)
                    {
                    Console.WriteLine($"Descartado:{icog}");
                    continue;
                    }
                    if(icog % 5 == 0)
                    { 
                    Console.WriteLine($"Descartado:{icog}");
                    continue;
                    }
                 Console.WriteLine($"Valor atual:{icog} , Total:{total1}");
                 Exercicio13(icog, total1);
                 continue;
                    }
                 break;

                 case 14:
                 for( int i = 1; i <= 100000; i++)
                 {
                 if( i % 11 == 0)
                 {
                 if( i % 13 == 0)
                 {
                 if(i % 17 == 0)
                 {
                 Console.WriteLine(i);
                 Exercicio14(i);
                 break;
                 }
                 }
                 }
                 }
                 break;

                 case 15:
                 for(int i = 33;i <= 126; i ++)
                 { 
                 int resi= i;
                 char carac = (char)(resi);
                 Exercicio15(resi, carac);
                 }
                 break;

                 case 16:
                 Console.WriteLine("Qual é o valor da sua bolsa??");            
                 int bolsa = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("Quanto tempo de estagio você possui??");
                 int tempo = Convert.ToInt32(Console.ReadLine());         
                  Exercicio16(bolsa, tempo);
                  break;
                  case 17:
                  Random rnd = new Random();
                  int valorSorteado = rnd.Next(1,100);
                  Console.WriteLine(valorSorteado);
                  banana:
                  Console.WriteLine("Informe um numero de 1 a 100!!");
                  int valorResposta = Convert.ToInt32(Console.ReadLine());
                  for(int s = 1; s <= 100;s++)
                  {
                  if(valorResposta == valorSorteado)
                  {
                  Console.WriteLine("acertou");
                  break;
                  }
                  if(valorResposta >= valorSorteado)
                  {
                    Console.WriteLine("tente um valor menor");
                    goto banana;
                  }
                  if(valorResposta <= valorSorteado)
                  {
                   Console.WriteLine("tente um valor maior");
                   goto banana;
                  }
                  }  
                  Exercicio17(valorResposta, valorSorteado);
                  break; 
                  
                  
                  case 18:
                  
                  Console.WriteLine("Digite um valor");
                  int x = Convert.ToInt32(Console.ReadLine());
                   Exercicio18(x);
                   break;

                   case 19:
                   int[] valores = new int[10];
                   for(int v = 0; v < valores.Length; v++)
                   {
                    Console.WriteLine("Digite {0}ª valor!!" , v);
                   int auxvalores = Convert.ToInt32(Console.ReadLine());
                   valores[v] = auxvalores;
                    Console.WriteLine(" Primeiro arrey:", valores[v]);
                   }
         
                   
                   int mediavetor = default, somavetor = default;
                   foreach(int v in valores)
                   {
                       somavetor += v;
                   }
                   mediavetor = somavetor / valores.Length;
                   Console.WriteLine("Média: {0}", mediavetor);
                  
                   Exercicio19(mediavetor, somavetor);
                   break;

                   case 20:
                   var array = new int [50];
                   var random = new Random();
                   random.Next();
                   int menorNumero;
                   int posicaoMenorNumero;
                   int maiorNumero;
                   int posicaoMaiorNumero;

                   for(int a = 0; a < array.Length; a++)
                   {
                   for(int b = 0; b < array.Length; b++)
                   {
                   if(array[a] <= array[b]) 
                   {
                   menorNumero = array[a];
                   posicaoMenorNumero = a;
                   } 
                   else if(array[a] >= array[b]) 
                   {
                   maiorNumero = array[a];
                   posicaoMaiorNumero = a;
                   }
                   }
                   }
                   Console.WriteLine($"Menor numero: {menorNumero} {posicaoMenorNumero}, Maior Numero: {maiorNumero} {posicaoMaiorNumero}");
                 Exercicio20(menorNumero, maiorNumero);
                  break;
                  




                           
                 
                 
                 
                
                
                
                
                 
                 
                 
                 
                 
                 
                 
                 
                 
                 
                 
                  
                  
                
                            
            }
        }
    } 
    public void Exercicio01(string nome, string idade)
        {
        Console.WriteLine($"{nome} você tem {idade} anos");
        }   
        public void Exercicio02(int QuantiMed)
        {
        Console.WriteLine($"o estoque médio é {QuantiMed}");
        }
        public void Exercicio03(int Base, int alt, int multi, decimal area)
        {
        Console.WriteLine($"area do triangulo é igual a : {area}");
        }
        public void Exercicio04(float valor1, float valor2, float auxsoma, float resultado)
        {
        Console.WriteLine($"O primeiro número lido foi {valor1} , o segundo número lido foi {valor2}. O resultado final é: {resultado}");
        }
        public void Exercicio05(double total, decimal valormedio, char parteinteira)
        {
        Console.WriteLine($"Soma: {total} Média: {valormedio} Parte Inteira: {parteinteira} Carácter: a ");
        }
        public void Exercicio06(short idade)
        {
            if( idade >=3 && idade <= 12)
            {
            }
           if(idade >= 13 & idade <= 17)
           {
           }
           if(idade >= 18)
           {
           } 
        }
        public void Exercicio07(double MediaFinal)
        {
        if(MediaFinal >= 7)
        {
        }
        if(MediaFinal < 7 && MediaFinal >= 4)
        {
        }
        if(MediaFinal < 4)
        {
        }
        }
        public void Exercicio08(double valor)
        {
         if(valor <=999)
         {
         }
         if(valor >= 1000 && valor <= 2999)
         {
         }
         if(valor >= 3000 && valor <= 6999);
         {
         }
         if(valor >= 7.000)
         {
         }
        } 
        public void Exercicio09(int resu1, int resu2)
        {
        if(resu1 >= 0 && resu2 <= 100)
        {
        if(resu1 < 0 && resu2 > 100)
        {
        }
        if(resu2 < resu1)
        {
        }
        if(resu2 > resu1)
        {
        }
        if(resu1 == resu2)
        {
        }
        }
        }
         public void Exercicio10(int var)
        {
         Console.WriteLine(var > 10 ?  "maior que dez" : "Menor que dez");
        }
         public void Exercicio11(int i, double divis, int inte, float fraci, int dev)
         {
        Console.WriteLine(i);
        Console.WriteLine(divis);
        Console.WriteLine(inte);
        Console.WriteLine(fraci);
        Console.WriteLine(dev);   
         }
         public void Exercicio12(int e, int d)
        {
        Console.WriteLine(e + " X " + d + " = " + e * d);
        }
         public void Exercicio13(int icog, int total1)
        {
        if(icog % 3 == 0)
        { 
        }
        if(icog % 5 == 0)
        {
        }
         Console.WriteLine($"Valor atual:{icog} , Total:{total1}");
        }
         public void Exercicio14(int i)
        {
         if( i % 11 == 0)
        {
        if( i % 13 == 0)
        {
        if(i % 17 == 0)
        {
        }
        }
        }
        }
        
         public void Exercicio15(int resi, char carac)
        {
         Console.WriteLine("Numero:"+resi + "Caractere:"+ carac);   
        }
        public void Exercicio16(int bolsa, int tempo)
        {
        Console.WriteLine(bolsa >= 750 && bolsa <= 950 ? "Parabens, você participara do treinamento" : "Não participara");
        Console.WriteLine(tempo >= 2 ? "Parabens, você participara do treinamento" : "Não participara"); 
        }
        public void Exercicio17(int valorResposta, int valorSorteado)
        {
          if(valorResposta == valorSorteado)
          {
          }
          if(valorResposta >= valorSorteado)
          {
          }
          if(valorResposta <= valorSorteado)
          {
          }
        }
        public void Exercicio18(int x)
        {
                  int y = 0;
                  while(y != 1)
                  {
                      
                   if(x % 2 == 0)
                   {
                       y = x / 2;
                   }
                   else
                   {
                       y = 3 * x + 1;
                   }
                   Console.WriteLine(y +" => ");

                   x = y;
                  }
         }
        public void Exercicio19(int mediavetor, int somavetor)
        {
        } 
        public void Exercicio20(int menorNumero, int maiorNumero)
        {
        for(int a = 0; a < array.Length; a++)
        {
        }
        for(int b = 0; b < array.Length; b++)
        {
        }
        if(array[a] <= array[b]) 
        {
        }
        else if(array[a] >= array[b]) 
        {
        }
        Console.WriteLine($"Menor numero: {menorNumero} {posicaoMenorNumero}, Maior Numero: {maiorNumero} {posicaoMaiorNumero}");
        }   
        static void Main(string[] args)
        {
            new Program();
        }
    }
}
