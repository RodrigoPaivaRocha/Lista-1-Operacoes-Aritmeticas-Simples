using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorX,valorY,resultado;

            Console.WriteLine("Digite o valor da base: ");
            valorX = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do expoente: ");
            valorY = double.Parse(Console.ReadLine());

            resultado = Math.Pow(valorX, valorY);

            Console.WriteLine("O valor da base elevada ao expoente é: " + resultado);

            Console.ReadKey();
        }
    }
}
