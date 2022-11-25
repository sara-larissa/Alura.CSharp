using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12___Investimento_a_longo_prazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 12 - Investindo a longo prazo");

            double fatorRendimento = 1.005; //ou fatorRendimento = 1.005 (1*005)
            double investimento = 1000;

            for(int anos = 1; anos <= 5; anos++)
            {
                for(int mes = 1; mes <=12; mes++)
                {
                    investimento *= fatorRendimento;
                }

                fatorRendimento = fatorRendimento + 0.001;
     
            }
            Console.WriteLine("Depois de 5 anos você tera R$" + investimento);

            Console.WriteLine("Digite ok e ENTER, para continuar");
            Console.ReadLine();
        }
    }
}
