//Desafio: Crie uma hierarquia de classes representando funcionários de uma empresa. Utilize herança para criar classes como Gerente, Programador e Analista. Cada classe deve ter propriedades específicas, além das propriedades comuns a todos os funcionários, como Nome e Salário.
namespace AprendizadoCSharp.DesafioFuncionariosDeEmpresa;
public class Funcionario
{
    public string Nome { get; set; }
    public decimal Salario { get; set; }

    // Construtor
    public Funcionario(string nome, decimal salario)
    {
        Nome = nome;
        Salario = salario;
    }

    // Método comum
    public virtual void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Salário: {Salario:C}");
    }
}
