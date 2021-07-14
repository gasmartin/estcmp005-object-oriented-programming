class ConstrutorProg{
	private String nomeCurso;


	public ConstrutorProg(String nome)
	{
		nomeCurso = nome;
	}

	public String getNome()
	{
		return "Nome do Curso retornado "+nomeCurso;
	}

}

public class Construtor {

	public static void main(String[] args) {

		ConstrutorProg cp = new ConstrutorProg("PLP - Java");
		System.out.println(cp.getNome());

	}
}


