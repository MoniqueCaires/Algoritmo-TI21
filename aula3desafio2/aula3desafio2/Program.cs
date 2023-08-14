using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula3desafio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float compra, pagamento ;
            float valor;
            float troco;
            float subtracao;



            Console.Write("Digite o valor da compra: ");
            compra = float.Parse(Console.ReadLine());

            Console.Write("Digite o valor pago pelo cliente: ");
            pagamento = float.Parse(Console.ReadLine());

            if (compra > pagamento)
            {
                Console.Write("Seu valor é insulficiente ");
                Console.ReadKey();

            }
            else
            {
                subtracao = pagamento - compra;
                Console.WriteLine("Seu troco é: " + subtracao);
            }
           



            Console.ReadKey();



        }
    }
}
