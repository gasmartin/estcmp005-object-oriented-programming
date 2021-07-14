import java.util.Date;
class Pessoa {
	public String nome;
	public String cpf;
	public Date data_nascimento;

	public Pessoa(String _nome, String _cpf, Date _data) {
		this.nome = _nome;
		this.cpf = _cpf;
		this.data_nascimento = _data;
	}
}

class Aluno extends Pessoa {
	public Aluno(String _nome, String _cpf, Date _data) {
		super(_nome, _cpf, _data);
	}
	private String matricula;

	public String getMatricula() {
        return matricula;
    }

    public void setMatricula(String matricula) {
        this.matricula= matricula;
    }
}
class Professor extends Pessoa {
	public Professor(String _nome, String _cpf, Date _data) {
		super(_nome, _cpf, _data);
	}
	public double salario;
	public String disciplina;
}
class Funcionario extends Pessoa {
	public Funcionario(String _nome, String _cpf, Date _data) {
		super(_nome, _cpf, _data);
	}
	public double salario;
	public Date data_admissao;
	public String cargo;
}

public class Heranca {
	public static void main(String[] args) {
		Aluno i = new Aluno("Jose Francisco", "123.456.789-00", new Date());
		i.setMatricula("1515310012");
		System.out.println("Veja como os atributos foram preenchidos\n\nNome: " + i.nome);
		System.out.println("Matricula: " + i.getMatricula());
		System.out.println("CPF: " + i.cpf);
		System.out.println("Data de nascimento: " + i.data_nascimento.toString());
	}
}


