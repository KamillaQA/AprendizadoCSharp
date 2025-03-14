//Desafio: Criar uma hierarquia de classes representando produtos eletrônicos, como Smartphone, Tablet e Laptop. Utilize herança e o conceito de métodos virtuais para implementar um método ExibirInformacoes que retorne informações específicas de cada produto.
namespace AprendizadoCSharp.DesafioProdutosEletronicos;

public class Laptop : ProdutoEletronico
{
    public string Processador { get; set; }
    public int Armazenamento { get; set; } // em GB

    // Construtor
    public Laptop(string nome, decimal preco, string processador, int armazenamento)
        : base(nome, preco)
    {
        Processador = processador;
        Armazenamento = armazenamento;
    }

    // Sobrescreve o método ExibirInformacoes para incluir informações do laptop
    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine($"Processador: {Processador}");
        Console.WriteLine($"Armazenamento: {Armazenamento} GB");
    }
}
