namespace Oficina
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public List<Carro> Carros { get; set; }

        public Cliente(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
            Carros = new List<Carro>();
        }

        public void AdicionarCarro(Carro carro)
        {
            Carros.Add(carro);
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"👤 Cliente: {Nome}, Telefone: {Telefone}");
            Console.WriteLine("🚘 Carros:");
            foreach (var carro in Carros)
            {
                Console.WriteLine($"  - {carro.Modelo} ({carro.Placa})");
            }
        }
    }
}
