namespace AprendizadoCSharp.DesafioContasBancarias;

public class ContaCorrente : ContaBancaria
{
    public decimal Limite { get; set; }

    // Construtor
    public ContaCorrente(string titular, decimal saldoInicial, decimal limite)
        : base(titular, saldoInicial)
    {
        Limite = limite;
    }

    // Sobrescreve o método CalcularSaldo para incluir o limite
    public override decimal CalcularSaldo()
    {
        return Saldo + Limite; // O saldo da conta corrente considera o limite
    }
}
