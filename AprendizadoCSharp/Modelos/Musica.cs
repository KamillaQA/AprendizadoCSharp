namespace AprendizadoCSharp.Modelos;
internal class Musica
{
    //definindo obrigatóriedade para o campo
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    //Tipos Primitivos
    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    //Propriedade (começa com pascal case)
    public bool Disponivel { get; set; }
    //Lambda
    public string DescricaoResumida =>$"A música {Nome} pertence à banda {Artista}";

    public void EscreveDisponivel(bool value)
    {
        Disponivel = value;
    }
    public bool LerDisponivel()
    {
        return Disponivel;
    }
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }
}
