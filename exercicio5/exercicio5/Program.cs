using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, num4, resultado;

            Console.WriteLine("Digite o primeiro número: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número: ");
            num3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o quarto número: ");
            num4 = double.Parse(Console.ReadLine());

            resultado = (num1 + num2 + num3 + num4) / 4;

            Console.WriteLine("O valor da média aritmética é: " + resultado);

            Console.ReadKey();
        }
    }
}
