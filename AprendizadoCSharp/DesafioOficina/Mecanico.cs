namespace Oficina
{
    public class Mecanico
    {
        public string Nome { get; set; }
        public string Especialidade { get; set; }

        public Mecanico(string nome, string especialidade)
        {
            Nome = nome;
            Especialidade = especialidade;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"🔧 Mecânico: {Nome}, Especialidade: {Especialidade}");
        }
    }
}
