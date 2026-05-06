using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Centro_Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;

            while (opcao != 4)     // != diferente
            {

                Console.Clear();  // limpa a tela 

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine(@"
█▀█ █▀█ █▄▀ █▀▀ █▀▄▀█ █▀█ █▄░█
█▀▀ █▄█ █░█ ██▄ █░▀░█ █▄█ █░▀█");

                Console.ResetColor();
                Console.WriteLine("\n seja bem vindo ao cemtro Pokemon!\n");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n 1 - cadastrar Pokemon");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n 2 - consultar Pokemon");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n 3 - apagar Pokemon");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n 4 - sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("tchau tchau");
                        System.Threading.Thread.Sleep(2000);
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("opção invalida!!!");
                        Console.ResetColor();
                        System.Threading.Thread.Sleep(2000);      //espera de 2 segundos
                        break;
                }

            }





        }
    }
}
