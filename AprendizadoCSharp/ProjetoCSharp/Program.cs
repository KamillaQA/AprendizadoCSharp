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

        ExibirMensagemDeBoasVindas(mensagemDeBoasVindas);
        ExibirOpcoesDoMenu();

        // Aguarda o usuário pressionar Enter antes de fechar o console
        Console.ReadLine();

        static void ExibirMensagemDeBoasVindas(string mensagem)
        {
            Console.WriteLine("**************************");
            Console.WriteLine(mensagem);
            Console.WriteLine("**************************");
        }

        void ExibirLogo()
        {
            Console.WriteLine(@"
            ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
            ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
            ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
            ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
            ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
            ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
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
                    Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
                    break;
                case 2:
                    Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
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
       
    }

    /*Primeiro desafio sobre C#
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


    /*Segundo desafio de C#
    // Função para verificar a nota e exibir uma mensagem
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
}
