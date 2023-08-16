using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaçãoTriângulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float comprimento, comprimento2, comprimento3 ;


            Console.Write("Digite o 1° número para o comprimento do triângulo: ");
            comprimento = float.Parse(Console.ReadLine());

            Console.Write("Digite o 2° número: ");
            comprimento2 = float.Parse(Console.ReadLine());

            Console.Write("Digite o 3° número: ");
            comprimento3 = float.Parse(Console.ReadLine());

            if (comprimento == comprimento2 && comprimento2 == comprimento3)
            {
                Console.WriteLine("Seu triângulo é equilátero!");
            }
            else if (comprimento == comprimento2 && comprimento3 < comprimento2 && comprimento3 < comprimento)
            {
                Console.Write(" Seu triângulo é isósceles!");
            }
            else if (comprimento < comprimento2 && comprimento > comprimento3 && comprimento2 > comprimento3)
            {
                Console.Write(" Seu triângulo é escalano! ");
            }

            Console.ReadKey();

               





        }
    }
}
