using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13___Break
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 13 -  Encadeando for (Break)");

            //*
            //**
            //***
            //****
            //*****

            for(int contadorLinhas = 0; contadorLinhas <=9; contadorLinhas++)
            {
                for( int contadorColunas = 0; contadorColunas <=9; contadorColunas++)
                {
                    Console.Write("*"); // White e não o WriteLine pq não é para pular linha;
                    if (contadorColunas >= contadorLinhas)
                        break;
                }

                Console.WriteLine();  //ele sozinho sem nada só vai pular as linhas, fazer a função do contadorLinhas;
            }

            for (int contadorLinhas = 0; contadorLinhas <= 9; contadorLinhas++)
            {
                for (int contadorColunas = 0; contadorColunas <= contadorLinhas; contadorColunas++)
                {
                    Console.Write("*"); // White e não o WriteLine pq não é para pular linha;
                    
                       
                }

                Console.WriteLine();  //ele sozinho sem nada só vai pular as linhas, fazer a função do contadorLinhas;
            }

            Console.WriteLine("Digite ok e ENTER, para continuar");
            Console.ReadLine();
        }
    }
}
