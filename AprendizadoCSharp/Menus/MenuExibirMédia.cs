using AprendizadoCSharp.Modelos;

namespace AprendizadoCSharp.Menus;

class MenuExibirMédia : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Exibir média da banda");
        Console.Write("Digite o nome da banda que deseja exibir a média: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Console.WriteLine($"\nA média da banda {nomeDaBanda} é {bandasRegistradas[nomeDaBanda].Media}.");
            Console.WriteLine("Digite uma tecla para votar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
