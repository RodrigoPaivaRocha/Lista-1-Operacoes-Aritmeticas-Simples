using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aresta;

            Console.WriteLine("Digite o valor da aresta: ");
            aresta = int.Parse(Console.ReadLine());

            double area = Math.Pow(aresta,2);

            Console.WriteLine("O valor da sua área é: " + area);

            Console.ReadKey();
        }
    }
}
