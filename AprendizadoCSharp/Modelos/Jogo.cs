// Desafio: Desenvolver uma classe que representa um catálogo de jogos, com uma lista de Jogos e métodos para manipular essa lista, bem como um construtor que faça sua inicialização.
class Jogo
{
    public string Nome { get; set; }
    public string Desenvolvedor { get; set; }

    // Construtor
    public Jogo(string nome, string desenvolvedor)
    {
        Nome = nome;
        Desenvolvedor = desenvolvedor;
    }
}