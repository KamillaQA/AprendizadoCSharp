//Desafio: Criar uma hierarquia de classes representando animais, como Mamifero, Ave e Peixe. Utilize herança e o conceito de métodos virtuais para implementar um método EmitirSom que represente o som característico de cada tipo de animal.

namespace AprendizadoCSharp.DesafioAnimais;

public class Mamifero : Animal
{
    public Mamifero(string nome) : base(nome) { }

    // Sobrescreve o método EmitirSom para o som característico dos mamíferos
    public override void EmitirSom()
    {
        Console.WriteLine($"{Nome} emitiu um som de mamífero (como um rosnado ou rugido).");
    }
}
