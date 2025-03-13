//Desafio: Criar um programa Program.cs, instanciar seus 5 filmes favoritos, guardá-los em uma lista e mostrar as suas informações no console.
//Desafio: Criar uma classe Artista, que representa uma pessoa que atua em filmes, no namespace Alura.Filmes. A classe deve conter atributos como o nome, idade e uma lista de filmes onde o artista atuou.

namespace Alura.Filmes
{
    public class ArtistaFilme
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public List<Filme> FilmesAtuados { get; set; }

        public ArtistaFilme(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
            FilmesAtuados = new List<Filme>();
        }

        public void AdicionarFilme(Filme filme)
        {
            if (!FilmesAtuados.Contains(filme))
            {
                FilmesAtuados.Add(filme);
            }
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade} anos");
            Console.WriteLine("Filmes atuados:");
            foreach (var filme in FilmesAtuados)
            {
                Console.WriteLine($"- {filme.TituloFilme}");
            }
        }
    }
}
