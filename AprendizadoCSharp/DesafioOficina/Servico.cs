namespace Oficina
{
    public class Servico
    {
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public Servico(string descricao, decimal preco)
        {
            Descricao = descricao;
            Preco = preco;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"🛠️ Serviço: {Descricao}, Preço: R${Preco:F2}");
        }
    }
}
