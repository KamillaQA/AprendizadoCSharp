//Desafio: Criar uma hierarquia de classes representando formas geométricas, como Quadrado, Círculo e Triângulo. Utilize herança para criar uma classe base chamada FormaGeometrica, que contenha métodos para calcular a área e o perímetro de uma forma.
namespace AprendizadoCSharp.DesafioFormasGeometricas;

class TrianguloEquilatero : FormaGeometrica
{
    public double Lado { get; set; }

    public TrianguloEquilatero(double lado)
    {
        Lado = lado;
    }

    public override double CalcularArea()
    {
        return (Math.Sqrt(3) / 4) * Math.Pow(Lado, 2);
    }

    public override double CalcularPerimetro()
    {
        return 3 * Lado;
    }
}