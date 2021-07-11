using System;
using System.Collections;

namespace Association
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        private ArrayList Amigos { get; set; }

        public Usuario(string nome, string email)
        {
            Nome = nome;
            Email = email;

            Amigos = new ArrayList();
        }

        public void addAmigo(Usuario usuario)
        {
            if(this == usuario || Amigos.Contains(usuario)) return;

            Amigos.Add(usuario);
            usuario.addAmigo(this);
        }

        public void showAmigos()
        {
            Console.WriteLine($"Mostrando amigos de {Nome}");
            Console.WriteLine();
            foreach (Usuario amigo in Amigos)
            {
                Console.WriteLine(amigo.Nome);
            }
            Console.WriteLine();
        }
    }

    class Association
    {
        static void Main(string[] args)
        {
            Usuario gabriel = new Usuario("Gabriel San Martin", "gssm.snf19@uea.edu.br");
            Usuario alexander = new Usuario("Gabriel Alexander", "gafdlt.snf19@uea.edu.br");
            Usuario helder = new Usuario("Helder Schramm", "hms.snf19@uea.edu.br");
            Usuario fabrizio = new Usuario("Fabrizio Honda", "fhf.lic17@uea.edu.br");
            Usuario jackson = new Usuario("Jackson Gomes", "jgg.snf@uea.edu.br");

            gabriel.addAmigo(alexander);
            gabriel.addAmigo(helder);

            fabrizio.addAmigo(jackson);
            helder.addAmigo(jackson);
            alexander.addAmigo(helder);

            gabriel.addAmigo(alexander);

            gabriel.showAmigos();
            jackson.showAmigos();

            Console.ReadLine();
        }
    }
}
