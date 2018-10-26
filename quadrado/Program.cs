using System;

namespace quadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrado quadrado = new Quadrado();
            Console.WriteLine("Informe o Lado A: ");

            quadrado.defineValorLadoA(Int32.Parse(Console.ReadLine()));

            Console.WriteLine("Informe o Lado B: ");

            quadrado.defineValorLadoB(Int32.Parse(Console.ReadLine()));

            Console.WriteLine("Informe o Lado C: ");

            quadrado.defineValorLadoC(Int32.Parse(Console.ReadLine()));

            Console.WriteLine("Informe o Lado D: ");

            quadrado.defineValorLadoD(Int32.Parse(Console.ReadLine()));

            Console.WriteLine("Lado A: " + quadrado.getvalorLadoA());
            Console.WriteLine("Lado B: " + quadrado.getvalorLadoB());
            Console.WriteLine("Lado C: " + quadrado.getvalorLadoC());
            Console.WriteLine("Lado D: " + quadrado.getvalorLadoD());
        }
    }
}
