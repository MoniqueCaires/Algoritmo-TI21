using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float peso, altura;
            float imc;

            Console.WriteLine("Qual é sua peso? ");
            peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual sua altura? ");
            altura = float.Parse(Console.ReadLine());

            imc = peso / (altura * altura);


            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso. ");
            }
            else if (imc < 24.9)
            {
                Console.WriteLine("Seu peso está ideal! ");
            }
            else if (imc < 29.9)
            {
                Console.WriteLine("Você está levemente a cima do peso.");
            }
            else if (imc < 34.9)
            {
                Console.WriteLine(" Obesiddade grau 1 ");
            }
            else if (imc < 39.9)
            {
                Console.WriteLine(" Obesidade grau 2 (Severa) ");
            }
            else
                Console.WriteLine(" Obesidade grau 3 (mórbida");






            Console.ReadKey();
        }
    }
}
