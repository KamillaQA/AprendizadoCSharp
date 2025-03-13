//Desafio: Modelar um Pet Shop com classes como Pet, Dono, Consulta e médico.
namespace PetShop
{
    public class Dono
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public Dono(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
        }
    }
}
