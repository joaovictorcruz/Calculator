using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro número");
            float v1 = float.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Digite o segundo número");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;
            Console.WriteLine("O resultado é: " + resultado);
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine($"O resultado é: {v1 + v2}");
        }
    }
}
