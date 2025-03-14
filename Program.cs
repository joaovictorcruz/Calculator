using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Subtracao();
        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro número");
            float v1 = float.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Digite o segundo número");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;
            Console.WriteLine($"O resultado da some é: {resultado}");
            Console.ReadKey();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro número");
            float v1 = float.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Digite o segundo número");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é: {resultado}");
            Console.ReadKey();
        }
    }
}
