using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula3desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, c ;
            float soma, divisao;

            Console.Write("Digite um número: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite um número: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Digite um número:");
            c = int.Parse(Console.ReadLine());  

            soma = a + b + c;
            Console.WriteLine(" A soma do valores: " + soma);

            divisao = soma / 3;
            Console.WriteLine("O resultado da média: " + divisao);












            Console.ReadKey();

        }
    }
}
