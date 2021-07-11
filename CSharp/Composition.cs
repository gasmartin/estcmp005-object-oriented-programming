using System.Collections;

namespace Composition
{
    public class Comentario
    {
        public string Conteudo { get; set; }

        public Comentario(string conteudo) { Conteudo = conteudo; }
    }

    public class Postagem
    {
        // Atributos da postagem aqui
        public ArrayList Comentarios { get; set; }

        public Postagem() { Comentarios = new ArrayList(); }

        public void Comentar(string conteudo)
        {
            Comentario comentario = new Comentario(conteudo);
            Comentarios.Add(comentario);
        }
    }

    class Composition
    {
        static void Main(string[] args)
        {
            Postagem postagem = new Postagem();

            postagem.Comentar("Adorei. Nota 0");
            postagem.Comentar("Curti muito essa postagem.");
            postagem.Comentar("Vou mostrar essa pro meu avô.");

            //Todos os comentarios sao deletados
            postagem = null;
        }
    }
}
