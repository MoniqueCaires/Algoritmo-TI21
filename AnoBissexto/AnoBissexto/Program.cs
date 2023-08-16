using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnoBissexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float ano;

            Console.Write("Digite um ano: ");
            ano= float.Parse(Console.ReadLine());

            if(ano % 4 == 0 && ano % 100 != 0 || ano % 400 == 0 )
            {
                Console.Write(ano + " Esse ano é Bissexto! ");
            }
            else
            {
                Console.Write(ano + " Esse ano não é Bissexto! ");
            }






            Console.ReadKey();
        }
    }
}
