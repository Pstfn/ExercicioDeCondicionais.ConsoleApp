    using System;

namespace Exercicio5.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro valor: ");
            int valorA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            int valorB = Convert.ToInt32(Console.ReadLine());

            int resultado = 0;

            if (valorA == valorB)
                resultado = valorA + valorB;
            else
                resultado = valorA * valorB;

            Console.WriteLine("Resultado: " + resultado);
        }
    }
}
