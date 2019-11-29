using System;

namespace GatewareTeste
{
    class Program
    {
        private static readonly Exercicio1 _exercicio1 = new Exercicio1();
        private static readonly Exercicio2 _exercicio2 = new Exercicio2();
        private static readonly Exercicio3 _exercicio3 = new Exercicio3();

        static void Main(string[] args)
        {
            Menu();
        }

        static public void Menu()
        {
            Console.WriteLine("Escolha a opção desejada:");
            Console.WriteLine();
            Console.WriteLine("1 - Exercício 1");
            Console.WriteLine("2 - Exercício 2");
            Console.WriteLine("3 - Exercício 3");
            Console.WriteLine("4 - Exercício 4");
            Console.WriteLine("5 - Exercício 5");
            Console.WriteLine("6 - Sair");

            int opcao;
            int.TryParse(Console.ReadLine(), out opcao);

            switch (opcao)
            {
                case 1:
                    _exercicio1.MaiorDoArray();
                    Menu();
                    break;
                case 2:
                    _exercicio2.BuscaArquivos();
                    Menu();
                    break;
                case 3:
                    _exercicio3.ManipularArquivos();
                    Menu();
                    break;
                case 4:
                    Console.WriteLine("Favor abrir a pasta Exercicio4 do projeto.\n");
                    Menu();
                    break;
                case 5:
                    Console.WriteLine("Favor abrir a pasta Exercicio5 do projeto.\n");
                    Menu();
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida.\n");
                    Menu();
                    break;
            }
        }
    }
}
