using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cotacaoDol, valorDol, valorReal;

            Console.WriteLine("Digite o valor da cotação do dólar: ");
            cotacaoDol = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite uma quantidade de dólares: ");
            valorDol = double.Parse(Console.ReadLine());

            valorReal = valorDol * cotacaoDol;

            Console.WriteLine("O valor da quantidade de dólares digitada em real é: " + valorReal);

            Console.ReadKey();
        }
    }
}
