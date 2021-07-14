class Endereco {
    private String logradouro;
    private int numero;
    private String complemento;
    private String bairro;
    private String cidade;
    private String estado;
    private int CEP;

    public String getLogradouro() {
        return logradouro;
    }

    public void setLogradouro(String logradouro) {
        this.logradouro = logradouro;
    }

    public int getNumero() {
        return numero;
    }

    public void setNumero(int numero) {
        this.numero = numero;
    }

    public String getComplemento() {
        return complemento;
    }

    public void setComplemento(String complemento) {
        this.complemento = complemento;
    }

    public String getBairro() {
        return bairro;
    }

    public void setBairro(String bairro) {
        this.bairro = bairro;
    }

    public String getCidade() {
        return cidade;
    }

    public void setCidade(String cidade) {
        this.cidade = cidade;
    }

    public String getEstado() {
        return estado;
    }

    public void setEstado(String estado) {
        this.estado = estado;
    }

    public int getCEP() {
        return CEP;
    }

    public void setCEP(int CEP) {
        this.CEP = CEP;
    }
}


class Pessoa {

    private String nome;
    private int idade;
    private char sexo;
    private long CPF;
    private Endereco residencial;

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public int getIdade() {
        return idade;
    }

    public void setIdade(int idade) {
        this.idade = idade;
    }

    public char getSexo() {
        return sexo;
    }

    public void setSexo(char sexo) {
        this.sexo = sexo;
    }

    public long getCPF() {
        return CPF;
    }

    public void setCPF(long CPF) {
        this.CPF = CPF;
    }

    public Endereco getResidencial() {
        return residencial;
    }

    public void setResidencial(Endereco residencial) {
        this.residencial = residencial;
    }
}

public class Associacao {
    public static void main(String[] args){
        Pessoa p = new Pessoa();
        p.setNome("Nome do fulano");
        p.setCPF(1234567890);
        p.setIdade(23);

        // Declara e Cria um endereço
        Endereco e;
        e = new Endereco();
        e.setCidade("São Paulo");
        e.setCEP(01023040);

        p.setResidencial(e);

        // Para Exibir os dados
        System.out.println("Nome: "+p.getNome());
        System.out.println("CPF: "+p.getCPF()); 
        System.out.println("Cidade: "+p.getResidencial().getCidade()); 
        System.out.println("Cep: "+p.getResidencial().getCEP());       
    }

}