using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 2 - Criando Variáveis");
             
            int idade;
            idade = 24 ;
            Console.WriteLine("Minha idade é " + idade);

            idade = 27 - 3;
            Console.WriteLine(idade);

            idade = 5 * 2 - 6; //neste caso vai fazer  a multiplicação 1°;
            Console.WriteLine(idade);

            idade = (5 - 2) * 3; // Se eu quiser que a adção ou subtração seja lido 1° precisa de parenteses;
            Console.WriteLine(idade);

            Console.WriteLine("Tecle enter para continuar");
            Console.ReadLine();


            //Posso escrever usando somente o WRITE em vez do WRITELINE, porem ele não faz quebra de linha, fica por exexmplo: 9Tecle para continuar (o 9 junto com a frase);

        }
    }
}
