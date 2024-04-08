using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorCelsius, valorFahrenheit;

            Console.WriteLine("Digite a temperatura em celsius: ");
            valorCelsius = double.Parse(Console.ReadLine());

            valorFahrenheit = (valorCelsius * 1.8) + 32;

            Console.WriteLine("A temperatura de Celsius em Fahrenheit é: " + valorFahrenheit);

            Console.ReadKey();
        }
    }
}
