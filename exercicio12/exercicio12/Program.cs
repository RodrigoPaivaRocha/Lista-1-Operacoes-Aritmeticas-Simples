using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorProd1, valorProd2, valorProd3, valorProd4, valorProd5, somatoriaProd, pagamentoProd, trocoProd;

            Console.WriteLine("Digite o valor do primeiro produto: ");
            valorProd1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do segundo produto: ");
            valorProd2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do terceiro produto: ");
            valorProd3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do quarto produto: ");
            valorProd4 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do quinto produto: ");
            valorProd5 = double.Parse(Console.ReadLine());

            somatoriaProd = valorProd1 + valorProd2 + valorProd3 + valorProd4 + valorProd5;

            Console.WriteLine("A soma dos cinco produtos é: " + somatoriaProd);

            Console.WriteLine("Digite o valor do pagamento: ");
            pagamentoProd = double.Parse(Console.ReadLine());

            trocoProd = somatoriaProd - pagamentoProd;

            if (pagamentoProd > somatoriaProd)
            {
                Console.WriteLine("O cobrador terá que devolver: " + Math.Abs(trocoProd));
            }
            else
            if (pagamentoProd < somatoriaProd)
            {
                Console.WriteLine("Para completar o pagamento faltará: " + trocoProd);
            }          
            else
            {
                Console.WriteLine("O PRODUTO FOI PAGO CORRETAMENTE :D");
            }
            Console.ReadKey();
        }
    }
}

