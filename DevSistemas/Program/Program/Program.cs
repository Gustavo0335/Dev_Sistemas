using System;

namespace Program
{
    class Program
    {
        public Program()
        {
            Console.WriteLine("Construtor");

            Calcula();
        }
        public void Calcula()
        {
            int x = 10, y = 90;
            int r = x + y;

            Console.WriteLine("Resultado: {0}" , r);
        }


        
        static void Main(string[] args)
        {
            new Program();
        }
    }
}
