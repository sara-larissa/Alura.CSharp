using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 -  Consicionais");

            int idadeJoao = 17; // menor de 18 anos vai imprimir na tela não pod entrar!
            int quantidadePessoas = 2; // se for 0 não vai poder entrar 

            if(idadeJoao >=18)
            {
                Console.WriteLine("PODE ENTRAR!");
            }
            else
            {
                if(quantidadePessoas > 0)
                {
                    Console.WriteLine("Ele está acompanhado, entrada liberada !");
                }
                else
                {
                    Console.WriteLine("Não pode entrar !");
                }
            }


            Console.WriteLine("Digite ok e ENTER, para continuar");
            Console.ReadLine();
        }
    }
}
