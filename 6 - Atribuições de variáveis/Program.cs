using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6___Atribuições_de_variáveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 6");

            int idade = 24;
            int idadeSara = idade;
            Console.WriteLine(idadeSara);

            idade = 25; // se declarar a baixo a idade nova, não muda na hora que imprime;



            Console.WriteLine("Tecle ENTER para continuar");
            Console.ReadLine();
        }
    }
}
