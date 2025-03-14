using AprendizadoCSharp.Modelos;

namespace AprendizadoCSharp.Menus;

internal class MenuRegistrarAlbum : Menu
{       public override void Executar(Dictionary<string, Banda> bandasRegistradas)
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
    }
}
