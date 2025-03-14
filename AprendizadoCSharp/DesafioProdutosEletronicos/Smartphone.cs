//Desafio: Criar uma hierarquia de classes representando produtos eletrônicos, como Smartphone, Tablet e Laptop. Utilize herança e o conceito de métodos virtuais para implementar um método ExibirInformacoes que retorne informações específicas de cada produto.
namespace AprendizadoCSharp.DesafioProdutosEletronicos;

public class Smartphone : ProdutoEletronico
{
    public string SistemaOperacional { get; set; }
    public int MemoriaRam { get; set; } // em GB

    // Construtor
    public Smartphone(string nome, decimal preco, string sistemaOperacional, int memoriaRam)
        : base(nome, preco)
    {
        SistemaOperacional = sistemaOperacional;
        MemoriaRam = memoriaRam;
    }

    // Sobrescreve o método ExibirInformacoes para incluir informações do smartphone
    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine($"Sistema Operacional: {SistemaOperacional}");
        Console.WriteLine($"Memória RAM: {MemoriaRam} GB");
    }
}
