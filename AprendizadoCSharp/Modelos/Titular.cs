//Desafio: Criar um construtor para a classe Titular, que inicialize todas suas propriedades:
internal class Titular
{
    // Propriedades da classe
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Endereco { get; set; }

    // Construtor da classe
    public Titular(string nome, string cpf, string endereco)
    {
        Nome = nome;
        Cpf = cpf;
        Endereco = endereco;
    }
}
