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


                Console.WriteLine("\n digite a opção escolhida: ");

                opcao = int.Parse(Console.ReadLine());







                switch (opcao)
                {
                    case 1:
                        cadrastoPokemon(); //abre a fumção
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
        static void cadrastoPokemon()
        {
            Console.Clear(); // limpar a tela 
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
           
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n digite o nome do seu Pokemon:");

            string nomePokemon = Console.ReadLine();    // sttring = textos 
            Console.WriteLine("\n digite o tipo do seu Pokemon:");

            string tipoPokemon = Console.ReadLine();    // string
            Console.WriteLine("\n digite o tamanho do seu Pokemon:");

            double alturaPokemon = double.Parse(Console.ReadLine());  // double = casa decimal 

            Console.WriteLine("\n digite o peso do seu Pokemon:");
            double pesoPokemon = double.Parse(Console.ReadLine());  // double = casa decim


            //fraqueza
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("fraqueza ele tem?:");
            int qtdfraqueza = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdfraqueza; i++)
            {
                Console.WriteLine($"fraqueza? {i}: ");  // {i} --- colocar a variavel no texto 
                string fraquezaPokemon = Console.ReadLine();
            }

            //fraqueza
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("quantas evoluções ele tem?:");
            int qtdEvolucao = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdEvolucao; i++)
            {
                Console.WriteLine($"evolução ele tem? {i}: ");  // {i} --- colocar a variavel no texto 
                string evolucaoPokemon = Console.ReadLine();
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n parabens... pokemon cadastrado");
            Thread.Sleep(3000);
            Console.ResetColor();


        }
    }
    }

