// Desafio: Desenvolver uma classe que representa um catálogo de jogos, com uma lista de Jogos e métodos para manipular essa lista, bem como um construtor que faça sua inicialização.

class CatalogoDeJogos
{
    public List<Jogo> Jogos { get; set; } = new List<Jogo>();

    // Construtor
    public CatalogoDeJogos(List<Jogo> jogos)
    {
        Jogos = jogos;
    }

    // Método para adicionar um jogo ao catálogo
    public void AdicionarJogo(Jogo jogo)
    {
        Jogos.Add(jogo);
        Console.WriteLine($"Jogo {jogo.Nome} adicionado ao catálogo.");
    }

    // Método para exibir todos os jogos do catálogo
    public void ExibirJogos()
    {
        Console.WriteLine("Jogos no catálogo:");
        foreach (var jogo in Jogos)
        {
            Console.WriteLine($"{jogo.Nome} - Desenvolvedor: {jogo.Desenvolvedor}");
        }
    }
}
