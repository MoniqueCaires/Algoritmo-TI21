using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula3desafio3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            float celsius, fahrenheit ;
            float soma, subtracao, divisao;


            Console.Write(" Qual a temperatura em  Celsius:");
            celsius = float.Parse(Console.ReadLine());

            fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine("A temperatura equivalente em Fahrenheit:"+ fahrenheit);

            
                






            Console.ReadKey();  

        }
    }
}
