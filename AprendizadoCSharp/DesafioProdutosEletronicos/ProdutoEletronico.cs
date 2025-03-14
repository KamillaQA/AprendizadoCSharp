//Desafio: Criar uma hierarquia de classes representando produtos eletrônicos, como Smartphone, Tablet e Laptop. Utilize herança e o conceito de métodos virtuais para implementar um método ExibirInformacoes que retorne informações específicas de cada produto.
namespace AprendizadoCSharp.DesafioProdutosEletronicos;
public class ProdutoEletronico
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }

    // Construtor
    public ProdutoEletronico(string nome, decimal preco)
    {
        Nome = nome;
        Preco = preco;
    }

    // Método virtual para exibir informações do produto
    public virtual void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Preço: {Preco:C}");
    }
}
