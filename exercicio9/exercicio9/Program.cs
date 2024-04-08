using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double diametro, raio, area;
            Console.WriteLine("Digite o diâmetro de um círculo: ");
            diametro = double.Parse(Console.ReadLine());
            raio = diametro / 2;
            area = Math.PI * Math.Pow(raio,2);
            Console.WriteLine("O valor da área é: " + Math.Round(area,2));            
            Console.ReadKey();
        }
    }
}
