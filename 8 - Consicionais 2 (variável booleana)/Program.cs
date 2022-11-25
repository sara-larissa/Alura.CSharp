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
            Console.WriteLine("Executando projeto 8 -  Consicionais 2 - (variável booleana)");

            int idadeJoao = 17; 
            int quantidadePessoas = 2;

            bool acompanhado = quantidadePessoas > 1; //O acompanhado recebe o quantidadePessoas
            bool grupo = true; //booleano recebe valores/informações de V ou F(true or false).

            if (idadeJoao >= 18 || acompanhado) // || (or/ou) - && (e/and) - Neste caso o acompanhado passou a valer o "quantidadePessoas"
                                   //No lugar do "acompanhado" poderia colocar "grupo" também"
            {
                Console.WriteLine("PODE ENTRAR!");
            }
            else
            {
                 Console.WriteLine("Não pode entrar !");
            }

            Console.WriteLine("digite ok e enter, para continuar");
            Console.ReadLine();
        }
    }
}
