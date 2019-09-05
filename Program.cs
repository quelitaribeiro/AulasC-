using System;
using System.Threading;

namespace Decisao
{
    class Program
    {
        static void Main(string[] args)
        {
            float R, A, B;
            int OPCAO;
            Console.Write("Informe o 1o. valor: ");
            A = float.Parse(Console.ReadLine());
            Console.Write("Informe o 2o. valor: ");
            B = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("[1] .............. Adição");
            Console.WriteLine("[2] ........... Subtração");
            Console.WriteLine("[3] ....... Multiplicação");
            Console.WriteLine("[4] ............. Divisão");
            Console.WriteLine();
            Console.Write("Escolha uma opção --> ");
            OPCAO = int.Parse(Console.ReadLine());
            if (OPCAO == 1)
            {
                R = A + B;
                Console.WriteLine("Resultado = " + R);
                Thread.Sleep(3000);
            }
            if (OPCAO == 2)
            {
                R = A - B;
                Console.WriteLine("Resultado = " + R);
                Thread.Sleep(3000);
            }
            if (OPCAO == 3)
            {
                R = A * B;
                Console.WriteLine("Resultado = " + R);
                Thread.Sleep(3000);
            }
            if (OPCAO == 4)
                if (B == 0) Console.WriteLine("ERRO – Divisão por zero!");
                else
                {
                    R = A / B;
                    Console.WriteLine("Resultado = " + R);
                    Thread.Sleep(3000);
                }
        }
    }
}



