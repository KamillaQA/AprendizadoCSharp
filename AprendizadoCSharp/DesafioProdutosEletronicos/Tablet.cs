//Desafio: Criar uma hierarquia de classes representando produtos eletrônicos, como Smartphone, Tablet e Laptop. Utilize herança e o conceito de métodos virtuais para implementar um método ExibirInformacoes que retorne informações específicas de cada produto.
namespace AprendizadoCSharp.DesafioProdutosEletronicos;

public class Tablet : ProdutoEletronico
{
    public string TamanhoTela { get; set; } // Ex: "10.5 polegadas"
    public string Conectividade { get; set; } // Ex: "Wi-Fi", "4G", "5G"

    // Construtor
    public Tablet(string nome, decimal preco, string tamanhoTela, string conectividade)
        : base(nome, preco)
    {
        TamanhoTela = tamanhoTela;
        Conectividade = conectividade;
    }

    // Sobrescreve o método ExibirInformacoes para incluir informações do tablet
    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine($"Tamanho da Tela: {TamanhoTela}");
        Console.WriteLine($"Conectividade: {Conectividade}");
    }
}
