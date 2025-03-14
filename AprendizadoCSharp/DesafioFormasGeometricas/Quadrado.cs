//Desafio: Criar uma hierarquia de classes representando formas geométricas, como Quadrado, Círculo e Triângulo. Utilize herança para criar uma classe base chamada FormaGeometrica, que contenha métodos para calcular a área e o perímetro de uma forma.
namespace AprendizadoCSharp.DesafioFormasGeometricas;

class Quadrado : FormaGeometrica
{
    public double Lado { get; set; }

    public Quadrado(double lado)
    {
        Lado = lado;
    }

    public override double CalcularArea()
    {
        return Lado * Lado;
    }

    public override double CalcularPerimetro()
    {
        return 4 * Lado;
    }
}