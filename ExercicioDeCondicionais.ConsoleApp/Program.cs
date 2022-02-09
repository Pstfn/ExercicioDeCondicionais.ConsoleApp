using System;

namespace Exercicio1.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorUm, valorDois, valorTres, soma;
            Console.WriteLine("digite o primeiro valor:");
            valorUm = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite o segundo valor:");
            valorDois = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite o terceiro valor:");
            valorTres = Convert.ToDouble(Console.ReadLine());
            soma = valorUm + valorDois;
            if (soma < valorTres)
            {
                Console.WriteLine("A soma de " + valorUm + " e " + valorDois + " é menor que " + valorTres + ".");
            }
            else
            {
                Console.WriteLine("A soma de " + valorUm + " e " + valorDois + " é maior que " + valorTres + ".");
            }
        }
    }
}
