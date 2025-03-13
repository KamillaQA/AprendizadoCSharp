using Alura.Filmes;
using AprendizadoCSharp.DesafioCurso;
using AprendizadoCSharp.Modelos; // Namespace para o desafio

internal class Program
{
    private static void Main(string[] args)
    {
        // Screen Sound
        string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
        // List<string> listaDasBandas = new List<string> { "Maverick", "Upperoom", "Adele" };
        //Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
        Dictionary<string, Banda> bandasRegistradas = new Dictionary<string, Banda>();

        Banda EKK = new Banda("EKK");
        EKK.AdicionarNota(new Avaliacao(10));
        EKK.AdicionarNota(new Avaliacao(8));
        EKK.AdicionarNota(new Avaliacao(6));
        Banda Upperoom = new("Upperoom");
       
        bandasRegistradas.Add(EKK.Nome, EKK);
        bandasRegistradas.Add(Upperoom.Nome, Upperoom);


        Album albumEKK = new Album("Canções que eu amo");

        Musica musica1 = new Musica(EKK, "give you")
        {
            Duracao = 273,
            Disponivel = true,
        };
       
        
        Musica musica2 = new Musica(EKK, "story")
        {
            Duracao = 367,
            Disponivel = false,
        };

        Episodio ep1 = new(2, "Técnicas de facilitação", 45);
        ep1.AdicionarConvidados("Maria");
        ep1.AdicionarConvidados("Marcelo");

        Episodio ep2 = new(1, "Tecnicas de aprendizado", 67);
        ep2.AdicionarConvidados("Fernando");
        ep2.AdicionarConvidados("Marcos");
        ep2.AdicionarConvidados("Flavia");

        Podcast podcast = new("Especial", "Daniel", TimeSpan.FromMinutes(12));
        podcast.AdicionarEpisodio(ep1);
        podcast.AdicionarEpisodio(ep2);
        podcast.ExibirDetalhes();

        albumEKK.AdicionarMusica(musica1);
        albumEKK.AdicionarMusica(musica2);
        EKK.AdicionarAlbum(albumEKK);

        musica1.ExibirFichaTecnica();
        musica2.ExibirFichaTecnica();
        albumEKK.ExibirMusicasDoAlbum();
        EKK.ExibirDiscografia();
        
 

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
            Console.Write("Registro das bandas\n");
            Console.Write("Digite o nome da banda que deseja registrar: ");
            string nomeDaBanda = Console.ReadLine()!;
            Banda banda = new Banda(nomeDaBanda);
            bandasRegistradas.Add(nomeDaBanda, banda);
            Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
            Thread.Sleep(4000);
            Console.Clear();
            ExibirOpcoesDoMenu();
        }
        void RegistrarAlbum()
        {
            Console.Clear();
            ExibirTituloDaOpcao("Registro de álbuns");
            Console.Write("Digite a banda cujo álbum deseja registrar: ");
            string nomeDaBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                Console.Write("Agora digite o título do álbum: ");
                string tituloAlbum = Console.ReadLine()!;
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                Banda banda = bandasRegistradas[nomeDaBanda];
                banda.AdicionarNota(nota);
                banda.AdicionarAlbum(new Album(tituloAlbum));
                Console.WriteLine($"O álbum {tituloAlbum} de {nomeDaBanda} foi registrado com sucesso!");
                Thread.Sleep(4000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            }

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
                Banda banda = bandasRegistradas[nomeDaBanda];
                Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
                int nota = int.Parse(Console.ReadLine()!);
                banda.AdicionarNota(new Avaliacao(nota)); 
                Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
                Thread.Sleep(2000);
                Console.Clear();
                ExibirOpcoesDoMenu();
            }
        }
        void ExibirDetalhes()
        {
            Console.Clear();
            ExibirTituloDaOpcao("Exibir detalhes da banda");
            Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
            string nomeDaBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                Banda banda = bandasRegistradas[nomeDaBanda];
                Console.WriteLine($"\nA média da banda {nomeDaBanda} é {banda.Media}.");
                Console.WriteLine("Digite uma tecla para votar ao menu principal");
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
                Console.WriteLine($"\nA média da banda {nomeDaBanda} é {bandasRegistradas[nomeDaBanda].Media}.");
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
            Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
            Console.WriteLine("Digite 3 para mostrar todas as bandas");
            Console.WriteLine("Digite 4 para avaliar uma banda");
            Console.WriteLine("Digite 5 para exibir os detalhes de uma banda");
            Console.WriteLine("Digite 6 para exibir a média de uma banda");
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
                    RegistrarAlbum();
                    break;
                case 3:
                    MostrarBandasRegistradas();
                    break;
                case 4:
                    AvaliarUmaBanda();
                    break;
                case 5:
                    ExibirDetalhes();
                    break;
                case 6:
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
        //11 desafio: Instanciar um objeto do tipo Conta e um do tipo Titular e mostrar as informações de Titular, a partir da Conta.
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


        //12 desafio: Modelar um sistema para um restaurante com classes como Restaurante, Mesa, Pedido e Cardapio. A classe Restaurante deve ter mesas que podem ser reservadas e um cardápio com itens que podem ser pedidos. Os pedidos podem estar associados a uma mesa.
        // Criando o restaurante e o cardápio
        /*Restaurante restaurante = new Restaurante();
        ProdutoRestaurante pizza = new ProdutoRestaurante { Nome = "Pizza", Preco = 50.00m };
        ProdutoRestaurante suco = new ProdutoRestaurante { Nome = "Suco", Preco = 10.00m };

        restaurante.Cardapio.AdicionarProduto(pizza);
        restaurante.Cardapio.AdicionarProduto(suco);

        // Criando mesas
        Mesa mesa1 = new Mesa { Numero = 1 };
        Mesa mesa2 = new Mesa { Numero = 2 };

        restaurante.Mesas.Add(mesa1);
        restaurante.Mesas.Add(mesa2);

        // Reservando mesa e fazendo pedidos
        mesa1.Reservar();
        mesa1.RealizarPedido(pizza, 2);
        mesa1.RealizarPedido(suco, 1);

        // Exibindo pedidos da mesa 1
        mesa1.ExibirPedidos();*/

        //13 desafio:Criar um programa Program.cs, instanciar seus 5 filmes favoritos, guardá-los em uma lista e mostrar as suas informações no console.
        //Instanciando 5 filmes favoritos
        /*
        var filme1 = new Filme("O Poderoso Chefão", 175);
        var filme2 = new Filme("Matrix", 136);
        var filme3 = new Filme("Inception", 148);
        var filme4 = new Filme("O Senhor dos Anéis: A Sociedade do Anel", 178);
        var filme5 = new Filme("Gladiador", 155);

        // Criando artistas
        var artista1 = new ArtistaFilme("Marlon Brando", 80);
        var artista2 = new ArtistaFilme("Keanu Reeves", 60);
        var artista3 = new ArtistaFilme("Leonardo DiCaprio", 50);
        var artista4 = new ArtistaFilme("Elijah Wood", 43);
        var artista5 = new ArtistaFilme("Russell Crowe", 60);

        // Adicionando filmes aos artistas
        artista1.AdicionarFilme(filme1);
        artista2.AdicionarFilme(filme2);
        artista3.AdicionarFilme(filme3);
        artista4.AdicionarFilme(filme4);
        artista5.AdicionarFilme(filme5);

        // Adicionando artistas ao elenco dos filmes
        filme1.AdicionarArtista(artista1);
        filme2.AdicionarArtista(artista2);
        filme3.AdicionarArtista(artista3);
        filme4.AdicionarArtista(artista4);
        filme5.AdicionarArtista(artista5);

        // Adicionando os filmes à lista
        var filmesFavoritos = new List<Filme> { filme1, filme2, filme3, filme4, filme5 };

        // Exibindo as informações dos filmes no console
        foreach (var filme in filmesFavoritos)
        {
            filme.ExibirInformacoes();
            Console.WriteLine();  // Linha em branco entre filmes
        }

        // Exibindo as informações dos artistas
        foreach (var artista in new List<ArtistaFilme> { artista1, artista2, artista3, artista4, artista5 })
        {
            artista.ExibirInformacoes();
            Console.WriteLine();  // Linha em branco entre artistas
        }
        */

        //14 Desafio: Modelar um Pet Shop com classes como Pet, Dono, Consulta e médico.

        /*
        // Criando um dono
        Dono dono1 = new Dono("Ana Souza", "11987654321");

        // Criando um pet
        Pet pet1 = new Pet("Thor", "Cachorro", 5, dono1);

        // Criando um veterinário
        Medico vet1 = new Medico("Dr. Carlos", "Clínica Geral");

        // Criando e agendando uma consulta
        Consulta consulta1 = new Consulta(pet1, vet1, DateTime.Now, "Check-up de rotina");
        pet1.AgendarConsulta(consulta1);

        // Exibindo informações
        pet1.ExibirInformacoes();
        consulta1.ExibirDetalhes();*/

        //15 desafio: Modelar o funcionamento de uma oficina automobilistica.

        // Criando um cliente
        /* Cliente cliente1 = new Cliente("Carlos Silva", "11998765432");

         // Criando um carro
         Carro carro1 = new Carro("Toyota Corolla", "ABC-1234", 2020);
         cliente1.AdicionarCarro(carro1);

         // Criando um mecânico
         Mecanico mecanico1 = new Mecanico("João Souza", "Motor e Suspensão");

         // Criando serviços
         Servico servico1 = new Servico("Troca de óleo", 150.00m);
         Servico servico2 = new Servico("Alinhamento e Balanceamento", 200.00m);

         // Criando uma ordem de serviço
         OrdemServico ordem1 = new OrdemServico(cliente1, carro1, mecanico1);
         ordem1.AdicionarServico(servico1);
         ordem1.AdicionarServico(servico2);

         // Exibindo detalhes da ordem de serviço
         ordem1.ExibirDetalhes();*/

        //16 desafio: Escrever um programa que funcione como uma calculadora, que pode realizar as 4 operações básicas, além de calcular raiz quadrada e potências. O usuario deve entrar com dois números e um simbolo que represente a operação a ser feita.

        /*
         var calc = new Calculadora();

        Console.WriteLine("Digite o primeiro número:");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número (caso seja raiz quadrada, digite 0):");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Escolha a operação (+, -, *, /, ^ para potência, √ para raiz quadrada):");
        string operacao = Console.ReadLine();

        double resultado = 0;
        bool operacaoValida = true;

        try
        {
            switch (operacao)
            {
                case "+":
                    resultado = calc.Somar(num1, num2);
                    break;
                case "-":
                    resultado = calc.Subtrair(num1, num2);
                    break;
                case "*":
                    resultado = calc.Multiplicar(num1, num2);
                    break;
                case "/":
                    resultado = calc.Dividir(num1, num2);
                    break;
                case "^":
                    resultado = calc.Potencia(num1, num2);
                    break;
                case "√":
                    resultado = calc.RaizQuadrada(num1);
                    break;
                default:
                    operacaoValida = false;
                    Console.WriteLine("Operação inválida!");
                    break;
            }

            if (operacaoValida)
            {
                Console.WriteLine($"Resultado: {resultado}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }*/
    }

}
