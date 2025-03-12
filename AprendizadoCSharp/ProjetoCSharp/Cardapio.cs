//Desafio: Modelar um sistema para um restaurante com classes como Restaurante, Mesa, Pedido e Cardapio. A classe Restaurante deve ter mesas que podem ser reservadas e um cardápio com itens que podem ser pedidos. Os pedidos podem estar associados a uma mesa.
class Cardapio
{
    public List<ProdutoRestaurante> Itens { get; set; } = new List<ProdutoRestaurante>();

    public void AdicionarProduto(ProdutoRestaurante produto)
    {
        Itens.Add(produto);
        Console.WriteLine($"Produto {produto.Nome} adicionado ao cardápio.");
    }
}
