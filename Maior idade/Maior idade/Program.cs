using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maior_idade
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int idade;

            Console.Write("Qual a sua idade? ");
            idade = int.Parse(Console.ReadLine());

            if (idade <=17)
            {
                Console.WriteLine("Você é menor de idade! ");
            }
            else if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade! ");

            }



            
            Console.ReadKey();

        }
    }
}
