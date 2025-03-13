//Desafio: Modelar um Pet Shop com classes como Pet, Dono, Consulta e médico.
namespace PetShop
{
    public class Medico
    {
        public string Nome { get; set; }
        public string Especialidade { get; set; }

        public Medico(string nome, string especialidade)
        {
            Nome = nome;
            Especialidade = especialidade;
        }
    }
}
