//Desafio: Desenvolver uma classe que modele um carro, e que contenha os métodos acelerar, frear e buzinar
//Desafio: Reescrever os atributos da classe Carro, de modo que eles sejam properties, e adicionar uma nova propertie DescricaoDetalhada, que mostra o fabricante, modelo e ano do carro.
//Desafio: Reescrever a propriedade Ano da classe carro, para que ela apenas aceite valores entre 1960 e 2023.
internal class Carro
{
    private int ano;

    public string Fabricante { get; set; }
    public string Modelo { get; set; }
    // public int Ano {  get; set; }
    public int Ano
    {
        get => ano;
        set
        {
            if (value < 1960 || value > 2023)
            {
                Console.WriteLine("Valor inválido, insira um ano entre 1960 e 2023");
            }
            else
            {
                ano = value;
            }
        }
    }
    public int QuantidadePortas { get; set; }
    public int Velocidade { get; set; }
    public string DescricaoDetalhada => $"Informações do carro: {this.Fabricante} {this.Modelo}, {this.QuantidadePortas} portas, {this.Ano}";

    /* public void DescricaoDetalhada()
    {
        Console.WriteLine($"Informações do carro: {this.Fabricante} {this.Modelo}, {this.QuantidadePortas} portas, {this.Ano}");
    }*/

    public void Acelerar()
    {
        Console.WriteLine("Acelerando...");
        if (Velocidade < 100)
        {
            Velocidade = Velocidade + 5;
        }
    }
    public void Frear()
    {
        Console.WriteLine("Freando...");
        if (Velocidade > 0)
        {
            Velocidade = Velocidade - 5;
        }
    }
    public void Buzinar()
    {
        Console.WriteLine("Bi Bi");
    }
}