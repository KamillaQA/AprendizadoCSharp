//Desafio: Crie uma hierarquia de classes representando funcionários de uma empresa. Utilize herança para criar classes como Gerente, Programador e Analista. Cada classe deve ter propriedades específicas, além das propriedades comuns a todos os funcionários, como Nome e Salário.
namespace AprendizadoCSharp.DesafioFuncionariosDeEmpresa;
public class Gerente : Funcionario
{
    public string Departamento { get; set; }

    // Construtor
    public Gerente(string nome, decimal salario, string departamento)
        : base(nome, salario)
    {
        Departamento = departamento;
    }

    // Sobrescreve o método ExibirInformacoes
    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine($"Departamento: {Departamento}");
    }
}
