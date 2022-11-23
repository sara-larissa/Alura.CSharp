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
