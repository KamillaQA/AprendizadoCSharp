//Desafio: Modelar um Pet Shop com classes como Pet, Dono, Consulta e médico.
namespace PetShop
{
    public class Pet
    {
        public string Nome { get; set; }
        public string Especie { get; set; }
        public int Idade { get; set; }
        public Dono Dono { get; set; }
        public List<Consulta> Consultas { get; set; }

        public Pet(string nome, string especie, int idade, Dono dono)
        {
            Nome = nome;
            Especie = especie;
            Idade = idade;
            Dono = dono;
            Consultas = new List<Consulta>();
        }

        public void AgendarConsulta(Consulta consulta)
        {
            Consultas.Add(consulta);
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"🐾 Nome: {Nome}, Espécie: {Especie}, Idade: {Idade} anos, Dono: {Dono.Nome}");
        }
    }
}
