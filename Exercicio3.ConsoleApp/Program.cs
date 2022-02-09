using System;

namespace Exercicio3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso, altura, pesoXaltura;
            Console.WriteLine("Digite seu peso:");
            peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite sua altura:");
            altura = Convert.ToDouble(Console.ReadLine());
            pesoXaltura = (altura * altura) / peso;
            if (pesoXaltura < 18.5)
                Console.WriteLine("Você está abaixo do peso");
            if (pesoXaltura >= 18.5 && pesoXaltura < 25)
                Console.WriteLine("Você está no peso normal");
            if (pesoXaltura >= 25 && pesoXaltura < 30)
                Console.WriteLine("Você está acima do peso");
            if (pesoXaltura > 30)
                Console.WriteLine("Você está obeso");
        }
    }
}
