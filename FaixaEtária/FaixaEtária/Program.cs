using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaixaEtária
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if(idade <= 12)
            {
                Console.WriteLine("Classificação Criança! ");
            }
            else if(idade <= 17)
            {
                Console.WriteLine("Classificação Adolescente! ");
            }
            else if(idade  <= 59)
            {
                Console.WriteLine("Classificação Adulto! ");
            }
            else  
                Console.WriteLine("Classificação Idoso! ");
            

            
            Console.ReadKey();




             
        }
    }
}
