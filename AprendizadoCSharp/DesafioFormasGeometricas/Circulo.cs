// Desafio: Criar uma hierarquia de classes representando formas geométricas, como Quadrado, Círculo e Triângulo. Utilize herança para criar uma classe base chamada FormaGeometrica, que contenha métodos para calcular a área e o perímetro de uma forma.
namespace AprendizadoCSharp.DesafioFormasGeometricas;

class Circulo : FormaGeometrica
{
    public double Raio { get; set; }

    public Circulo(double raio)
    {
        Raio = raio;
    }

    public override double CalcularArea()
    {
        return Math.PI * Math.Pow(Raio, 2);
    }

    public override double CalcularPerimetro()
    {
        return 2 * Math.PI * Raio;
    }
}