using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int baseRet, alturaRet, area;

            Console.WriteLine("Digite a base do retângulo: ");
            baseRet = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura do retângulo: ");
            alturaRet = int.Parse(Console.ReadLine());

            area = baseRet * alturaRet;

            Console.WriteLine("A área do seu retângulo é: " + area);
            
            Console.ReadKey();
        }
    }
}
