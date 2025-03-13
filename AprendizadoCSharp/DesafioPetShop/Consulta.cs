//Desafio: Modelar um Pet Shop com classes como Pet, Dono, Consulta e médico.
namespace PetShop
{
    public class Consulta
    {
        public Pet Pet { get; set; }
        public Medico Medico { get; set; }
        public DateTime DataConsulta { get; set; }
        public string Diagnostico { get; set; }

        public Consulta(Pet pet, Medico medico, DateTime dataConsulta, string diagnostico)
        {
            Pet = pet;
            Medico = medico;
            DataConsulta = dataConsulta;
            Diagnostico = diagnostico;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($" Consulta para {Pet.Nome} com Dr. {Medico.Nome} ({Medico.Especialidade}) em {DataConsulta:dd/MM/yyyy}");
            Console.WriteLine($" Diagnóstico: {Diagnostico}");
        }
    }
}
