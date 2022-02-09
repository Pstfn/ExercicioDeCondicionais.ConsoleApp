using System;

namespace Exercicio2.ConsoleApp
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
            if (valorUm == valorDois || valorUm == valorTres || valorDois == valorTres)

                Console.WriteLine("Por favor digite somente valores inteiros e diferentes.");

            else if (valorUm > valorDois && valorDois > valorTres)
                Console.WriteLine(" A ordem decrescente é: \n" + valorUm + ", " + valorDois + " ," + valorTres + ".");
            else if (valorUm > valorTres && valorTres > valorDois)
                Console.WriteLine(" A ordem decrescente é: \n" + valorUm + ", " + valorTres + " ," + valorDois + ".");
            else if (valorDois > valorUm && valorUm > valorTres)
                Console.WriteLine(" A ordem decrescente é: \n" + valorDois + ", " + valorUm + " ," + valorTres + ".");
            else if (valorDois > valorTres && valorTres > valorUm)
                Console.WriteLine(" A ordem decrescente é: \n" + valorDois + ", " + valorTres + " ," + valorUm + ".");
            else if (valorTres > valorUm && valorUm > valorDois)
                Console.WriteLine(" A ordem decrescente é: \n" + valorTres + ", " + valorUm + " ," + valorDois + ".");
            else if (valorTres > valorDois && valorDois > valorUm)
                Console.WriteLine(" A ordem decrescente é: \n" + valorTres + ", " + valorDois + " ," + valorUm + ".");
        }
    }
}
