using System;

namespace Exercicio_for_tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int n;
            int multiplicação;
            

            Console.WriteLine("Digite o número para a tabuada:");

            n = int.Parse(Console.ReadLine());

            if (2 < n && n < 100)
            {
               
                for (int i = 0; i < 11; i++)
                {
                    
                    multiplicação = n * i;
                    Console.WriteLine(i + " x " + n + " = " + multiplicação);
                }

            }

            else
            {
                Console.WriteLine("Impossível calcular");
            }


        }
    }
}
