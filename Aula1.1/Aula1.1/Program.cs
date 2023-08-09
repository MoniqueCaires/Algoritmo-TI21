using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Hello World!");
            //Console.Read();

            int numero1;
            int numero2;
            int numero3;
            int numero4;
            int soma;

            Console.Write("Digite o 1° numero:");
            //int.parse converte uma cadeia de caracter para o tipo INTEIRO
            numero1 = int.Parse(Console.ReadLine());  //Leia a sequência de caracter digitado pelo o usuario
            //estamos utilizando o sinal de + para concatenar o texto digitado + o valor da variavel "numero1"
            Console.WriteLine("O valor digitado foi: " + numero1 );

            //Console.ReadKey(); //Nesse momento o readkey serve para o nosso programa não fechar

            Console.Write("Digite o 2° numero:");
            numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("O valor digitado foi: " + numero2);

            Console.Write("Digite o 3° numero:");
            numero3 = int.Parse(Console.ReadLine());
            Console.WriteLine("O valor digitado foi:" + numero3);

            Console.Write("Digite o 4° numero:");
            numero4 = int.Parse(Console.ReadLine());
            Console.WriteLine("O valor digitado foi:" + numero4);
            
            soma=numero1 + numero2 + numero3 + numero4;
            Console.WriteLine("O valor total foi: "+ soma);
            
            
            Console.ReadKey();
            

            


        }
    }
}
