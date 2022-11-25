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
            Console.WriteLine("Executando o projeto 10 - Calcula Poupança");

            double investimento = 1000;

            //rendimento de 0.5% (0.005) ao mês;

            //mês 1 (para saber quanto eu teria daqui a 3 meses;
            //investimento = investimento + investimento * 0.005; //o investimento 1 mes depois, vai assumir o valor do investimento + o valor investido * o rendimento (tenho um valor investido, 1 mês dps vou ter esse valor * a porcentagem de acrescimo;
            //mês 2
            //investimento = investimento + investimento * 0.005;
            //mês 3
            //investimento = investimento + investimento * 0.005;
           // Console.WriteLine(investimento);

            int mes = 1;
            while (mes <= 12) //while = enquanto (enquanto o mês for menor ou igual a 12, eu quero executar alguma determinada coisa
            {
                investimento = investimento + investimento * 0.005;
                Console.WriteLine("No mês " + mes + " você tem R$: " + investimento);

                mes = mes + 1; //neste caso mês passa a ser mes + 1 = 2, em algum momento esse m~es passará a valer 13, e qunaod ele passar a valer 13 para a execução;
            }

            Console.WriteLine("Digite ok e ENTER, para continuar");
            Console.ReadLine();
        }
    }
}
