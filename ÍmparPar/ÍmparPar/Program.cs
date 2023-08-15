using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÍmparPar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero;
            float divisao;

            Console.Write(" Digite um número: ");
            numero = float.Parse(Console.ReadLine());

            divisao = numero % 2;
            Console.WriteLine(divisao);

            if(divisao == 1)
            {
                Console.Write("Esse número é ímpar!");
            }
            else if (divisao == 0)
            {
                Console.Write(" Esse número é par!");
            }





            Console.ReadKey();

        }
    }
}
