using System;
using System.Collections.Generic;
using DesafioCurso; // Namespace para o desafio

class Program
{
    static void Main()
    {
        // Screen Sound
        string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
        // List<string> listaDasBandas = new List<string> { "Maverick", "Upperoom", "Adele" };
        Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
        bandasRegistradas.Add("Novo amor", new List<int> { 10, 8, 6});
        bandasRegistradas.Add("Betel", new List<int>());

        Musica musica1 = new Musica();
        musica1.nome = "The story I'll god";
        musica1.artista = "Upperoom";
        musica1.duracao = 273;
        musica1.disponivel = true;

        Musica musica2 = new Musica();
        musica2.nome = "The graces";
        musica2.artista = "Upperoom";
        musica2.duracao = 367;
        musica2.disponivel = false;

        musica1.ExibirFichaTecnica();
        musica2.ExibirFichaTecnica();

        Console.WriteLine($"Nome da música: {musica1.nome}\n");
        Console.WriteLine($"Artista: {musica1.artista}\n");

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
        void ExibirTituloDaOpcao(string titulo)
        {
            int quantidadeDeLetras = titulo.Length;
            string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
            Console.WriteLine(asteriscos);
            Console.WriteLine(titulo);
            Console.WriteLine(asteriscos + "\n");
        }
        void RegistrarBanda()
        {
            Console.Clear();
            Console.WriteLine("**********************");
            Console.WriteLine("Registro de bandas");
            Console.WriteLine("**********************\n");
            Console.Write("Digite o nome da banda que deseja registrar: ");
            string nomeDaBanda = Console.ReadLine()!;
            bandasRegistradas.Add(nomeDaBanda, new List<int> { 1 });
            Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
            Thread.Sleep(2000);
            Console.Clear();
            ExibirOpcoesDoMenu();
        }
        void MostrarBandasRegistradas()
        {
            Console.Clear();
            ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplicação");

            //for (int i = 0; i < listaDasBandas.Count; i++)
            //{
            //Console.WriteLine($"Banda: {listaDasBandas[i]}");
            //}

            foreach (string banda in bandasRegistradas.Keys)
            {
                Console.WriteLine($"Banda: {banda}");
            }

            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesDoMenu();

        }
        void AvaliarUmaBanda()
        {
            Console.Clear();
            ExibirTituloDaOpcao("Avaliar banda");
            Console.Write("Digite o nome da banda que deseja avaliar: ");
            string nomeDaBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
                int nota = int.Parse(Console.ReadLine()!);
                bandasRegistradas[nomeDaBanda].Add(nota);
                Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
                Thread.Sleep(2000);
                Console.Clear();
                ExibirOpcoesDoMenu();
            }
            else
            {
                Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
                ExibirOpcoesDoMenu();
            }
        }

        void ExibirMedia()
        {
            Console.Clear();
            ExibirTituloDaOpcao("Exibir média da banda");
            Console.Write("Digite o nome da banda que deseja exibir a média: ");
            string nomeDaBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
                Console.WriteLine($"\nA média da banda {nomeDaBanda} é {notasDaBanda.Average()}.");
                Console.WriteLine("Digite uma tecla para votar ao menu principal");
                Console.ReadKey();
                Console.Clear();
                ExibirOpcoesDoMenu();

            }
            else
            {
                Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
                ExibirOpcoesDoMenu();
            }
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
                    AvaliarUmaBanda();
                    break;
                case 4:
                    ExibirMedia();
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

        //6 desafio: Criar um dicionário que represente um aluno, com uma lista de notas, e mostre a média de suas notas na tela;
        /* MediaNotasAluno();
         static void MediaNotasAluno()
         {
             Dictionary<string, List<double>> aluno = new Dictionary<string, List<double>>();
             Console.Write("Digite o nome do aluno: ");
             string nome = Console.ReadLine();
             aluno[nome] = new List<double>();

             Console.Write("Quantas notas deseja adicionar? ");
             int qtdNotas = int.Parse(Console.ReadLine());
             for (int i = 0; i < qtdNotas; i++)
             {
                 Console.Write($"Digite a {i + 1}ª nota: ");
                 double nota = double.Parse(Console.ReadLine());
                 aluno[nome].Add(nota);
             }

             double media = aluno[nome].Average();
             Console.WriteLine($"A média do aluno {nome} é: {media:F2}");
         }*/

        //7 desafio: Criar um programa que gerencie o estoque de uma loja. Utilize um dicionário para armazenar produtos e suas quantidades em estoque e mostre, a partir do nome de um produto, sua quantidade em estoque.
        /*GerenciarEstoque();
        static void GerenciarEstoque()
        {
            Dictionary<string, int> estoqueProdutos = new Dictionary<string, int>
            {
                {"Notebook", 5},
                {"Mouse", 20},
                {"Teclado", 15},
                {"Monitor", 7}
            };

            Console.Write("Digite o nome do produto para verificar o estoque: ");
            string produto = Console.ReadLine()!;

            if (estoqueProdutos.ContainsKey(produto))
            {
                Console.WriteLine($"O produto {produto} tem {estoqueProdutos[produto]} unidades em estoque.");
            }
            else
            {
                Console.WriteLine("Produto não encontrado no estoque.");
            }
        }*/

        //8 desafio:Crie um programa que implemente um quiz simples de perguntas e respostas. Utilize um dicionário para armazenar as perguntas e as respostas corretas.
        /* QuizPerguntas();
         static void QuizPerguntas()
         {
             Dictionary<string, string> quiz = new Dictionary<string, string>
         {
             { "Qual a capital da França?", "Paris" },
             { "Qual é o maior planeta do sistema solar?", "Júpiter" },
             { "Quanto é 2 + 2?", "4" }
         };

             int pontuacao = 0;

             foreach (var pergunta in quiz)
             {
                 Console.WriteLine(pergunta.Key);
                 Console.Write("Resposta: ");
                 string resposta = Console.ReadLine();

                 if (resposta.Equals(pergunta.Value, StringComparison.OrdinalIgnoreCase))
                 {
                     Console.WriteLine("Correto!");
                     pontuacao++;
                 }
                 else
                 {
                     Console.WriteLine($"Errado! A resposta correta é {pergunta.Value}");
                 }
             }

             Console.WriteLine($"Você acertou {pontuacao} de {quiz.Count} perguntas.");
         }*/


        //9 desafio: Criar um programa que simule um sistema de login utilizando um dicionário para armazenar nomes de usuário e senhas.
        /*SistemaLogin();
        static void SistemaLogin()
        {
            Dictionary<string, string> usuarios = new Dictionary<string, string>
        {
            { "usuario1", "senha123" },
            { "kamillaqa", "segredo" },
            { "admin", "admin123" }
        };

            Console.Write("Digite seu nome de usuário: ");
            string usuario = Console.ReadLine();
            Console.Write("Digite sua senha: ");
            string senha = Console.ReadLine();

            if (usuarios.ContainsKey(usuario) && usuarios[usuario] == senha)
            {
                Console.WriteLine("Login bem-sucedido!");
            }
            else
            {
                Console.WriteLine("Usuário ou senha incorretos!");
            }
        }*/

        //10 desafio: Criar um objeto do tipo Conta, adicionar dados e mostrar as informações titular e saldo no console, utilizando interpolação de strings.
       /* // Criando titulares
        Titular titular1 = new Titular("João Silva", "123.456.789-00", "Rua das Flores, 123");
        Titular titular2 = new Titular("George Harrison", "000.000.000-00", "Rua dos Besouros, Liverpool");

        // Criando conta bancária associada ao titular2
        ContaBancaria c = new ContaBancaria(titular2, 1, 2234, 100000);

        Console.WriteLine("\nInformações da Conta Bancária:");
        Console.WriteLine(c.Informacoes);

        // Exibindo informações do titular DA CONTA (titular2)
        Console.WriteLine("\nInformações do Titular da Conta:");
        Console.WriteLine($"Nome: {c.Titular.Nome}");
        Console.WriteLine($"CPF: {c.Titular.Cpf}");
        Console.WriteLine($"Endereço: {c.Titular.Endereco}");
        Console.WriteLine($"Saldo Atual: R$ {c.Saldo:F2}\n");*/


    }

}
