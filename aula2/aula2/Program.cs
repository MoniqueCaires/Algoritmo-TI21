using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double a, b, resultado;

            Console.Write("Digite um número: ");
            a = int.Parse(Console.ReadLine());

            resultado = Math.Pow(a,2);
            Console.WriteLine("O resultado = " + resultado);

            Console.Write("Digite outro número: ");
            b = int.Parse(Console.ReadLine());

            resultado = Math.Sqrt(b);
            Console.Write("O resultado = " + resultado);
  








            Console.ReadKey();
        }
    }
}
