
namespace AprendizadoCSharp.Modelos;

internal class Avaliacao
{
    // Construtor que aceita um argumento para a nota
    public Avaliacao(int nota)
    {
        Nota = nota;
    }
    public int Nota { get; }

    public static Avaliacao Parse(string texto)
    {
        int nota = int.Parse(texto);  // Corrigido o erro aqui
        return new Avaliacao(nota);
    }
}
