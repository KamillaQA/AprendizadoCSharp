namespace Oficina
{
    public class Carro
    {
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public int Ano { get; set; }

        public Carro(string modelo, string placa, int ano)
        {
            Modelo = modelo;
            Placa = placa;
            Ano = ano;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"🚗 Modelo: {Modelo}, Placa: {Placa}, Ano: {Ano}");
        }
    }
}
