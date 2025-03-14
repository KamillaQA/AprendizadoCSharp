namespace AprendizadoCSharp.DesafioContasBancarias;

public class ContaBancaria
{
    public string Titular { get; set; }
    public decimal Saldo { get; set; }

    // Construtor
    public ContaBancaria(string titular, decimal saldoInicial)
    {
        Titular = titular;
        Saldo = saldoInicial;
    }

    // Método virtual para calcular o saldo
    public virtual decimal CalcularSaldo()
    {
        return Saldo;
    }
}
