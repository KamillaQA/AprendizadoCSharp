namespace AprendizadoCSharp.DesafioCurso
{
    public class Curso
    {
        public string CursoEstudado { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Instrutores { get; set; }

        public void ExibirInformacoes()
        {
            Console.WriteLine("Curso: " + CursoEstudado);
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Sobrenome: " + Sobrenome);
            Console.WriteLine("Instrutores: " + Instrutores);
        }
    }
}
