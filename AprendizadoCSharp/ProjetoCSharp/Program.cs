using System;
using System.Collections.Generic;
using DesafioCurso; // Namespace para o desafio

class Program
{
    static void Main()
    {
        // Screen Sound
        string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
        List<string> listaDasBandas = new List<string> { "Maverick", "Upperoom", "Adele" };

        ExibirOpcoesDoMenu();

        // Aguarda o usuário pressionar Enter antes de fechar o console
        Console.ReadLine();

        void ExibirLogo()
        {
            Console.WriteLine(@"
            ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
            ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
            ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
            ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
            ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
            ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
            Console.WriteLine(mensagemDeBoasVindas);
        }
        void RegistrarBanda()
        {
            Console.Clear();
            Console.WriteLine("**********************");
            Console.WriteLine("Registro de bandas");
            Console.WriteLine("**********************\n");
            Console.Write("Digite o nome da banda que deseja registrar: ");
            string nomeDaBanda = Console.ReadLine()!;
            listaDasBandas.Add(nomeDaBanda);
            Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
            Thread.Sleep(2000);
            Console.Clear();
            ExibirOpcoesDoMenu();
        }
        void MostrarBandasRegistradas()
        {
            Console.Clear();
            Console.WriteLine("************************************");
            Console.WriteLine("Exibindo todas as bandas registradas");
            Console.WriteLine("************************************\n");

            //for (int i = 0; i < listaDasBandas.Count; i++)
            //{
            //Console.WriteLine($"Banda: {listaDasBandas[i]}");
            //}

            foreach (string banda in listaDasBandas)
            {
                Console.WriteLine($"Banda: {banda}");
            }

            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesDoMenu();

        }
        void ExibirOpcoesDoMenu()
        {
            ExibirLogo();
            Console.WriteLine("\nDigite 1 para registrar uma banda");
            Console.WriteLine("Digite 2 para mostrar todas as bandas");
            Console.WriteLine("Digite 3 para avaliar uma banda");
            Console.WriteLine("Digite 4 para exibir a média de uma banda");
            Console.WriteLine("Digite -1 para sair");

            Console.Write("\nDigite a sua opção: ");
            string opcaoEscolhida = Console.ReadLine()!;
            int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

            switch (opcaoEscolhidaNumerica)
            {
                case 1:
                    RegistrarBanda();
                    break;
                case 2:
                    MostrarBandasRegistradas();
                    break;
                case 3:
                    Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
                    break;
                case 4:
                    Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
                    break;
                case -1:
                    Console.WriteLine("Tchau tchau :)");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
        /*1 desafio sobre C#
     static void DesafioCurso()
     {
         // Criando e exibindo as informações do curso
         Curso curso = new Curso
         {
             CursoEstudado = "C#",
             Nome = "Kamilla",
             Sobrenome = "Prado",
             Instrutores = "Instrutor A, Instrutor B"
         };

         curso.ExibirInformacoes();
     }
       // Executar o desafio do curso
         DesafioCurso();
     */


        /*2 desafio: Função para verificar a nota e exibir uma mensagem
        static void VerificarAprovacao()
        {
            int notaMedia = 6; // Exemplo: atribuímos 6 para a nota
            if (notaMedia >= 5)
            {
                Console.WriteLine("Nota suficiente para aprovação");
            }
            else
            {
                Console.WriteLine("Nota insuficiente para aprovação");
            }
        }

        // Função para exibir uma linguagem de programação da lista
        static void ExibirLinguaDeProgramacao()
        {
            List<string> linguagensDeProgramacao = new List<string> { "C#", "Java", "JavaScript" };
            Console.WriteLine("Linguagem exibida: " + linguagensDeProgramacao[0]); // Exibe "C#"
        }

        // Função para exibir a n-ésima posição da lista
        static void ExibirPosicaoLista()
        {
            List<string> linguagensDeProgramacao = new List<string> { "C#", "Java", "JavaScript" };

            Console.Write("\nDigite um número inteiro n para acessar a n-ésima posição da lista (começando de 0): ");
            int n = int.Parse(Console.ReadLine()!);

            // Verificar se n está dentro dos limites da lista
            if (n >= 0 && n < linguagensDeProgramacao.Count)
            {
                Console.WriteLine($"O valor na posição {n} é: {linguagensDeProgramacao[n]}");
            }
            else
            {
                Console.WriteLine("Número fora do alcance da lista.");
            }
        }
          // Executar o desafio do C#
           VerificarAprovacao();
           ExibirLinguaDeProgramacao();
           ExibirPosicaoLista();
        */

        //3 desafio: Função para exibir as quatro operações básicas
        /*static void ExibirOperacoesBasicas(double a, double b)
        {
            Console.WriteLine($"Adição: {a} + {b} = {a + b}");
            Console.WriteLine($"Subtração: {a} - {b} = {a - b}");
            Console.WriteLine($"Multiplicação: {a} * {b} = {a * b}");

            if (b != 0) // Verificando para não dividir por zero
            {
                Console.WriteLine($"Divisão: {a} / {b} = {a / b}");
            }
            else
            {
                Console.WriteLine("Divisão: Não é possível dividir por zero");
            }
        }
        ExibirOperacoesBasicas(5.5, 2.2);*/

        //4 desafio: Criar uma lista de bandas vazia e adicionar suas bandas preferidas 
        /* List<string> bandasPreferidas = new List<string>();

         // Adicionando as bandas favoritas
         bandasPreferidas.Add("Coldplay");
         bandasPreferidas.Add("Imagine Dragons");
         bandasPreferidas.Add("The Beatles");

         // Chamando a função para mostrar todas as bandas
         MostrarBandas(bandasPreferidas);
         static void MostrarBandas(List<string> bandas)
         {
             Console.WriteLine("Minhas bandas favoritas:");

             // Usando o 'for' para exibir todas as bandas
             for (int i = 0; i < bandas.Count; i++)
             {
                 Console.WriteLine(bandas[i]);
             }
         }*/

        //5 desafio: Calcular a soma de todos os elementos inteiros em uma lista
        /*List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };

        // Calculando e exibindo a soma
        int soma = CalcularSoma(numeros);
        Console.WriteLine($"A soma de todos os elementos é: {soma}");
        static int CalcularSoma(List<int> lista)
        {
            int soma = 0;

            // Somando todos os elementos da lista
            for (int i = 0; i < lista.Count; i++)
            {
                soma += lista[i];
            }

            return soma;
        }*/
    }

}
