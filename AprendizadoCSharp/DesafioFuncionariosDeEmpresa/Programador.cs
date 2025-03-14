//Desafio: Crie uma hierarquia de classes representando funcionários de uma empresa. Utilize herança para criar classes como Gerente, Programador e Analista. Cada classe deve ter propriedades específicas, além das propriedades comuns a todos os funcionários, como Nome e Salário.
namespace AprendizadoCSharp.DesafioFuncionariosDeEmpresa;

public class Programador : Funcionario
{
    public string LinguagemPrincipal { get; set; }

    // Construtor
    public Programador(string nome, decimal salario, string linguagemPrincipal)
        : base(nome, salario)
    {
        LinguagemPrincipal = linguagemPrincipal;
    }

    // Sobrescreve o método ExibirInformacoes
    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine($"Linguagem Principal: {LinguagemPrincipal}");
    }
}
