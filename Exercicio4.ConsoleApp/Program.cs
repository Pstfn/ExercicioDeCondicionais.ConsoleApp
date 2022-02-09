using System;

namespace Exercicio4.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
                Console.WriteLine("O numero é par");
            else
                Console.WriteLine("O numero é impar");

            Console.ReadLine();
        }
    }
}
