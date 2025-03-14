//Desafio: Crie uma hierarquia de classes representando funcionários de uma empresa. Utilize herança para criar classes como Gerente, Programador e Analista. Cada classe deve ter propriedades específicas, além das propriedades comuns a todos os funcionários, como Nome e Salário.
namespace AprendizadoCSharp.DesafioFuncionariosDeEmpresa;

public class Analista : Funcionario
{
    public string AreaDeEspecializacao { get; set; }

    // Construtor
    public Analista(string nome, decimal salario, string areaDeEspecializacao)
        : base(nome, salario)
    {
        AreaDeEspecializacao = areaDeEspecializacao;
    }

    // Sobrescreve o método ExibirInformacoes
    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine($"Área de Especialização: {AreaDeEspecializacao}");
    }
}
