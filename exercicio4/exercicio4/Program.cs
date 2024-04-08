using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int baseTriang, alturaTriang;
            double area;

            Console.WriteLine("Digite o valor da base do triângulo: ");
            baseTriang = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura do triângulo: ");
            alturaTriang = int.Parse(Console.ReadLine());

            area = (baseTriang *  alturaTriang)/2;

            Console.WriteLine("O valor da sua área é: " + area);

            Console.ReadKey();
        }
    }
}
