using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criando_variáveis.Flutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3 - Variáveis ponto flutuante");

            double salario; //variável  double aceita int, mas int não aceita double
            //salario = 3000.10;

            double idade; 
            idade = 7/5; //para apresentar n° double tem que colocar 7.0 se não ele faz a divisão e desconsidera depois da virgula

            Console.WriteLine(salario);

            Console.WriteLine("Tecle enter para continuar");
            Console.ReadLine();
        }
    }
}
