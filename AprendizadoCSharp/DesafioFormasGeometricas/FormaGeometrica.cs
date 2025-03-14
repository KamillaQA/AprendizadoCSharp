//Desafio: Criar uma hierarquia de classes representando formas geométricas, como Quadrado, Círculo e Triângulo. Utilize herança para criar uma classe base chamada FormaGeometrica, que contenha métodos para calcular a área e o perímetro de uma forma.
namespace AprendizadoCSharp.DesafioFormasGeometricas;

abstract class FormaGeometrica
{
    public abstract double CalcularArea();
    public abstract double CalcularPerimetro();
}