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

//////////////////////////// 4 - CONVERSÕES E OUTROS TIPOS - ///////////////////////////////////////////////////////////////


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            double salario;
            salario = 3000.15;
            Console.WriteLine(salario);

            int salarioInteiro;
            salarioInteiro = (int)salario; //convertendo variável do tipo float para int (int);
            Console.WriteLine(salarioInteiro);

            long x;
            x = 222200000000; // int é até 32bts passou é long
            Console.WriteLine(x);

            short y =
            y = 15000; //menos que int (valores menores);
            Console.WriteLine(y);

            float altura;
            altura = 1.62f; //dava erro ai coloca f
            //Da também pra fazer da seguinte forma float altura = 1.62f
            Console.WriteLine(altura);

            Console.WriteLine("Tecle ok para continuar");
            Console.ReadLine();
        }
    }
}
