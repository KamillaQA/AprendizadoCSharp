//Desafio: Criar uma hierarquia de classes representando animais, como Mamifero, Ave e Peixe. Utilize herança e o conceito de métodos virtuais para implementar um método EmitirSom que represente o som característico de cada tipo de animal.
namespace AprendizadoCSharp.DesafioAnimais;

public class Ave : Animal
{
    public Ave(string nome) : base(nome) { }

    // Sobrescreve o método EmitirSom para o som característico das aves
    public override void EmitirSom()
    {
        Console.WriteLine($"{Nome} emitiu um som de ave (como um piar ou cantar).");
    }
}

