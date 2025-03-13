namespace Oficina
{
    public class OrdemServico
    {
        public Cliente Cliente { get; set; }
        public Carro Carro { get; set; }
        public Mecanico Mecanico { get; set; }
        public List<Servico> Servicos { get; set; }
        public DateTime DataServico { get; set; }

        public OrdemServico(Cliente cliente, Carro carro, Mecanico mecanico)
        {
            Cliente = cliente;
            Carro = carro;
            Mecanico = mecanico;
            Servicos = new List<Servico>();
            DataServico = DateTime.Now;
        }

        public void AdicionarServico(Servico servico)
        {
            Servicos.Add(servico);
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($" Ordem de Serviço - {DataServico:dd/MM/yyyy}");
            Cliente.ExibirInformacoes();
            Carro.ExibirInformacoes();
            Mecanico.ExibirInformacoes();
            Console.WriteLine(" Serviços:");
            decimal total = 0;
            foreach (var servico in Servicos)
            {
                servico.ExibirDetalhes();
                total += servico.Preco;
            }
            Console.WriteLine($" Total: R${total:F2}");
        }
    }
}
