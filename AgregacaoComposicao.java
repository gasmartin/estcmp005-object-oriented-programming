import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

class Professor {

    private final String name;
    private final List<Department> attachedDepartments = new ArrayList<>();

    public Professor(String name) {
        this.name = name;
    }
    //Associando departamento ao professor
    public void join(Department d) {
        attachedDepartments.add(d);
    }
    //Removendo o departamento do professor
    public void quit(Department d) {
        attachedDepartments.remove(d);
    }

    public String getName() {
        return name;
    }

    @Override
    public String toString() {
        return "Professor " + name + " trabalhando para " + attachedDepartments.size() + " departamento(s)\n";
    }
}

class Department {

    private final String name;
    private List<Professor> professors = new ArrayList<>();
    private final University university;

    public Department(University univ, String name) {
        this.university = univ;
        this.name = name;
    }
    //Adicionando o professor ao departamento
    public void assign(Professor p) {
        System.out.println("Departmento contratando " + p.getName());
        professors.add(p);
        p.join(this);
    }

    public void destroy() {
        //A agregação aqui, nós apenas dizemos ao professor que eles estão demitidos, mas eles ainda podem continuar vivendo
        System.out.println("Destruindo departamento");
        professors.forEach(professor -> professor.quit(this));
        professors = null;
    }

    @Override
    public String toString() {
        return professors == null
                ? "Departamento " + name + " não existe mais"
                : "Departamento " + name + "{\n" +
                "professores=" + professors.stream().map(Professor::toString).collect(Collectors.joining("\n")) +
                "\n}";
    }
}

class University {

    private List<Department> departments = new ArrayList<>();

    public Department createDepartment() {
        final Department dep = new Department(this, "Computação");
        departments.add(dep);
        return dep;
    }

    public void destroy() {
        System.out.println("Destruindo Universidade");
        //Aqui é composição, quando eu destruo uma universidade também destruo os departamentos. 
        //eles não podem viver fora da minha instância universitária
        if (departments != null)
            departments.forEach(Department::destroy);
        departments = null;
    }

    @Override
    public String toString() {
        return "Universidade{\n" +
                "Departamentos=\n" + departments.stream().map(Department::toString).collect(Collectors.joining("\n")) +
                "\n}";
    }
}


public class AgregacaoComposicao
{
    public static void main(String[] args)
    {
        University university = new University();
        //O departamento só existe na universidade
        Department dep = university.createDepartment();
        //O professor existe fora da universidade
        Professor prof = new Professor("Jucimar");
        System.out.println(university.toString());
        System.out.println(prof.toString());
        //Adicionando o professor ao departamento
        dep.assign(prof);
        System.out.println(university.toString());

        university.destroy();

        //System.out.println(university.toString());
        System.out.println(prof.toString());

    }

}