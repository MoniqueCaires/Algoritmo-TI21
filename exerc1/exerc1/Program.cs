using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float pagamento, valor, troco;
            int menu;



            Console.WriteLine("Menu: ");
            Console.WriteLine("1- Média de três números ");
            Console.WriteLine("2- Troco de compra ");
            Console.WriteLine("3- Coversão de temperatura ");
            Console.Write("Escolha a opção: ");
            menu= int.Parse(Console.ReadLine());

            if (menu == 1)
            {
                float a, b, c;
                float soma, media;

                Console.Write("Digite o 1° número: ");
                a = float.Parse(Console.ReadLine());

                Console.Write("Digite o 2° número: ");
                b = float.Parse(Console.ReadLine());

                Console.Write("Digite o 3° número: ");
                c = float.Parse(Console.ReadLine());


                soma = a + b + c;
                media = soma / 3;

                Console.WriteLine("O valor da média é: " + media);

            } else if (menu == 2)
            {
                Console.WriteLine(" Digite o valor da compra: ");
                valor = float.Parse(Console.ReadLine());

                Console.WriteLine(" Digite o valor pelo cliente: ");
                pagamento = float.Parse(Console.ReadLine());

                if(valor > pagamento)
                {
                    Console.WriteLine(" O valor do pagemento é insuficiente para concluir a comprar ");

                }
                else
                {
                    troco = pagamento - valor;
                    Console.WriteLine(" O valor do seu troco é: R$" + troco);

                }
                
            }else
            {
                float celsius, fahrenheit;

                Console.WriteLine("Digite a temperatura em celsius: ");
                celsius = float.Parse(Console.ReadLine());

                fahrenheit = celsius * 9 / 5 + 32;
                Console.WriteLine("A temperatura em fahrenheit é: " + fahrenheit);
            }
                 

                

            


             Console.ReadKey();


            








        }
    }
}
