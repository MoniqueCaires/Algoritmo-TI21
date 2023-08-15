using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float nota;

            Console.Write(" Qual foi a nota da avaliação? ");
            nota = float.Parse(Console.ReadLine());

            if ( nota == 10)
            {
                Console.WriteLine(" Sua nota é A ");
            }

            else if(nota >= 8)
            {
                Console.WriteLine("Sua nota é B ");
            }

            else if (nota >= 6)
            {
                Console.WriteLine("Sua nota é C ");
            }

            else if (nota >= 4)
            {
                Console.WriteLine("Sua nota é D ");
            }

            else
            {
                Console.WriteLine("Sua nota é E ");
            }






            Console.ReadKey();


        }
    }
}
