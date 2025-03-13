//Desafio: Modelar um sistema para um restaurante com classes como Restaurante, Mesa, Pedido e Cardapio. A classe Restaurante deve ter mesas que podem ser reservadas e um cardápio com itens que podem ser pedidos. Os pedidos podem estar associados a uma mesa.
class Mesa
{
    public int Numero { get; set; }
    public bool Reservada { get; set; } = false;
    public List<Pedido> Pedidos { get; set; } = new List<Pedido>();
    public void Reservar()
    {
        if (Reservada)
        {
            Console.WriteLine("A mesa já está reservada.");
        }
        else
        {
            Reservada = true;
            Console.WriteLine($"Mesa {Numero} reservada com sucesso.");
        }
    }

    public void RealizarPedido(ProdutoRestaurante produto, int quantidade)
    {
        if (quantidade <= 0)
        {
            Console.WriteLine("Quantidade inválida.");
            return;
        }

        Pedido pedido = new Pedido { Produto = produto, Quantidade = quantidade };
        Pedidos.Add(pedido);
        Console.WriteLine($"Pedido de {quantidade} {produto.Nome} realizado na mesa {Numero}.");
    }

    public void ExibirPedidos()
    {
        Console.WriteLine($"Pedidos da Mesa {Numero}:");
        foreach (var pedido in Pedidos)
        {
            Console.WriteLine($"{pedido.Quantidade}x {pedido.Produto.Nome} - R$ {pedido.Produto.Preco:F2}");
        }
    }
}


