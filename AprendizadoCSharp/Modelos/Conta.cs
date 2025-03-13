//Desafio: Criar um construtor para a classe Conta, que inicialize todas suas propriedades:
class Conta
{
    public Titular Titular { get; set; }
    public int Agencia { get; set; }
    public int NumeroDaConta { get; set; }
    public double Saldo { get; }
    public double Limite { get; set; }

    // Construtor
    public Conta(Titular titular, int agencia, int numeroDaConta, double limite = 0)
    {
        Titular = titular;
        Agencia = agencia;
        NumeroDaConta = numeroDaConta;
        Limite = limite;
        Saldo = 0; // Inicializa o saldo como 0
    }
    public string Informacoes => $"Conta nº {this.NumeroDaConta}, Agência {this.Agencia}, Titular: {this.Titular.Nome} - Saldo: {this.Saldo}";
}