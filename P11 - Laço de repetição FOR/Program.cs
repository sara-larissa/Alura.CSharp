using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10___Laço_de_repetição_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 10 - Calcula Poupança 2 (Ultilizando laço for)");

            /* while (mes <= 12) 
           {
               investimento = investimento + investimento * 0.005;
               Console.WriteLine("No mês " + mes + " você tem R$: " + investimento);

               mes = mes + 1;
           } */

            double investimento = 1000;

            for ( int mes = 1; mes <= 12; mes = mes + 1)
            {
                Console.WriteLine("No mês " + mes + " você tem R$: " + investimento);
            }

            //FOR recebe 3 parâmetros, onde 1 será nossa variável inicialização, a nossa condição e nosso contador;


            Console.WriteLine("Digite ok e ENTER, para continuar");
            Console.ReadLine();
        }
    }
}
