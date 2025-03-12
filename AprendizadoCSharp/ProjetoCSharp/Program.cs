using System;
using DesafioCurso; // Namespace para o desafio

class Program
{
    static void Main()
    {
        // Mensagem de boas-vindas ao projeto Screen Sound
        string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
        Console.WriteLine(mensagemDeBoasVindas);

        // Executar o desafio do curso
        DesafioCurso();

        // Aguarda o usuário pressionar Enter antes de fechar o console
        Console.ReadLine();
    }

    static void DesafioCurso()
    {
        // Criando e exibindo as informações do curso
        Curso curso = new Curso
        {
            CursoEstudado = "C#",
            Nome = "Kamilla",
            Sobrenome = "Prado",
            Instrutores = "Instrutor A, Instrutor B"
        };

        curso.ExibirInformacoes();
    }
}
