class Podcast
{
    public List<Episodio> episodios = new List<Episodio>();
    public string Nome { get; }
    public string Host { get; }
    public TimeSpan Duracao { get; set; }
    public int TotalEpisodios => episodios.Count;
    public Podcast(string nome, string host, TimeSpan duracao)
    {
        Nome = nome;
        Host = host;
        Duracao = duracao;
    }
    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }
    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast >|{Nome}|< apresentado por [{Host}]\n");
        foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"\n\nTotal de episódios: {TotalEpisodios}.");
    }
}