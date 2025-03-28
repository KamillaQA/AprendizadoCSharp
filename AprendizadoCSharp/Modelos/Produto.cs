﻿//Desafio: Desenvolver a classe Produto, com os atributos nome, marca, preco e estoque. Além disso, garantir que o preço e o estoque do produto sejam valores positivos e criar uma propriedade que mostra detalhadamente as informações do produto, para que seja usado pela equipe de vendas.
//Desafio: Desenvolver uma classe que represente um estoque de produtos, e que tenha as funcionalidades de adicionar novos produtos, e exibir todos os produtos no estoque.
internal class Produto
{
    private double preco;
    private int estoque;
    public string Nome { get; set; }
    public string Marca { get; set; }
    public double Preco
    {
        get => preco;
        set
        {
            if (value > 0)
            {
                preco = value;
            }
            else
            {
                preco = 10;
            }
        }
    }
    public int Estoque
    {
        get => estoque;
        set
        {
            if (value > 0)
                estoque = value;
            else
                estoque = 10;
        }
    }
    public string Descricao => $"{this.Nome} {this.Marca} - {this.Preco} - Quantidade: {this.Estoque}";
}

class EstoqueDeProdutos
{
    private List<Produto> Produtos { get; set; } = new List<Produto>();

    public void AdicionarProduto(Produto produto)
    {
        Produtos.Add((produto));
        Console.WriteLine($"Produto {produto.Nome} adicionado ao estoque");
    }

    public void ExibirProdutos()
    {
        if (Produtos.Count == 0)
        {
            Console.WriteLine("Estoque vazio. Nenhum produto disponível");
        }
        else
        {
            Console.WriteLine("Lista de produtos no estoque:");
            foreach (var produto in Produtos)
            {
                Console.WriteLine(produto.Descricao);
            }
        }
    }
}