using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double milhasMarit,resultado;

            Console.WriteLine("Digite a quantidade de milhas marítimas para converter para quilômetros: ");
            milhasMarit = double.Parse(Console.ReadLine());

            resultado = milhasMarit * 1852;

            Console.WriteLine("A quantidade de milhas marítimas em quilômetros é: " + resultado);

            Console.ReadKey();
        }
    }
}
