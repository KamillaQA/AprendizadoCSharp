//Desafio: Criar uma classe que representa um filme, com dados como seu titulo, duração e elenco. Após isso, colocá-la no namespace Alura.Filmes.
//Desafio: Modificar as classes Artista e Filme do namespace Alura.Filmes para que elas sejam consistentes uma com a outra, ou seja, sempre que for adicionado um artista a um filme, terá de ser adicionado também o filme à lista de filmes do artista.

namespace Alura.Filmes
{
    public class Filme
    {
        public string TituloFilme { get; set; }
        public int DuracaoFilme { get; set; }
        public List<ArtistaFilme> Elenco { get; set; }

        public Filme(string titulo, int duracao)
        {
            TituloFilme = titulo;
            DuracaoFilme = duracao;
            Elenco = new List<ArtistaFilme>();
        }

        public void AdicionarArtista(ArtistaFilme artista)
        {
            if (!Elenco.Contains(artista))
            {
                Elenco.Add(artista);
            }

            if (!artista.FilmesAtuados.Contains(this))
            {
                artista.AdicionarFilme(this);
            }
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Título: {TituloFilme}");
            Console.WriteLine($"Duração: {DuracaoFilme} minutos");
            Console.WriteLine("Elenco: ");
            foreach (var artista in Elenco)
            {
                Console.WriteLine($"- {artista.Nome}");
            }
        }
    }
}
