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

            bool acompanhado = quantidadePessoas > 1;

            string textoAdc; //Quando descomenta ela perde as letras maiusculas da palavra;

            if(acompanhado == true)
            {
                 textoAdc = "João está acompanhado"; //string - declarando dentro das chaves, em vez de declarar lá em cima, mas da erro noo segundo escopo
            }
            else
            {
                  textoAdc = "João não está acompanhado";
            }

            if (idadeJoao >= 18 || acompanhado) 
            {
                Console.WriteLine(textoAdc);
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
