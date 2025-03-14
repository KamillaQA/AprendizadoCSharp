//Desafio: Criar uma hierarquia de classes representando animais, como Mamifero, Ave e Peixe. Utilize herança e o conceito de métodos virtuais para implementar um método EmitirSom que represente o som característico de cada tipo de animal.
namespace AprendizadoCSharp.DesafioAnimais;

public class Animal
{
    public string Nome { get; set; }

    // Construtor
    public Animal(string nome)
    {
        Nome = nome;
    }

    // Método virtual para emitir o som
    public virtual void EmitirSom()
    {
        Console.WriteLine("O animal emitiu um som.");
    }
}

