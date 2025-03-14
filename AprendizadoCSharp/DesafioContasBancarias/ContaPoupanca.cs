namespace AprendizadoCSharp.DesafioContasBancarias;
public class ContaPoupanca : ContaBancaria
{
    public decimal Juros { get; set; }

    // Construtor
    public ContaPoupanca(string titular, decimal saldoInicial, decimal juros)
        : base(titular, saldoInicial)
    {
        Juros = juros;
    }

    // Sobrescreve o método CalcularSaldo para incluir os juros
    public override decimal CalcularSaldo()
    {
        return Saldo + (Saldo * Juros / 100); // O saldo da conta poupança é acrescido dos juros
    }
}
