﻿// Desafio: Criar uma classe que representa uma conta bancária, com um número indicador, titular, saldo e senha.
// Desafio: Reescrever a classe Conta, criada no ultimo desafio, utilizando properties.
// Desafio: Modelar uma classe Conta, que tenha como atributos uma classe Titular, além de informações da conta, como agência, número da conta, saldo e limite, bem como um método que devolva as informações da conta de forma detalhada.

internal class ContaBancaria
{
    public ContaBancaria(Titular titular, int agencia, int numeroDaConta, double saldo = 0, double limite = 0, string senha = "1234")
    {
        Titular = titular;
        Agencia = agencia;
        NumeroDaConta = numeroDaConta;
        Saldo = saldo;
        Limite = limite;
        Senha = senha;
    }

    public int Numero { get; set; }
    public Titular Titular { get; set; }
    public int Agencia { get; set; }
    public int NumeroDaConta { get; set; }
    public double Saldo { get; private set; } // Saldo deve ser apenas leitura
    public double Limite { get; set; }
    public string Senha { get; set; }

    //Desafio: Desenvolver um método da classe Conta que exibe suas informações.
    public void Conta()
    {
        Console.WriteLine($"Sua conta Bancaria é: {this.Numero}");
        Console.WriteLine($"O nome do titular é: {this.Titular.Nome}");
        Console.WriteLine($"Seu saldo Bancario é: {this.Saldo}");
        Console.WriteLine($"Senha: {Senha}");
    }

    public string Informacoes => $"Conta nº {this.NumeroDaConta}, Agência {this.Agencia}, Titular: {this.Titular.Nome} - Saldo: {this.Saldo}";
}