﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5__Caractere
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executar o projeto 5 - caracteres e textos");
            //char - ARMAZENA CARACTERE

            char letra = 'a'; //entende como um número internamnete pelo computador;
            Console.WriteLine(letra);

            letra = (char)65; //A no char e 65 no decimal - site Ascii Table
            Console.WriteLine(letra);

            letra = (char)(65 + 1); // 65 = a + 1 = 66
            Console.WriteLine(letra);

            Console.WriteLine("Tecle ok para continuar");
            Console.ReadLine();
        }
    }
}
