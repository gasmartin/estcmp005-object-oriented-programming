using System;

namespace Bank
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        public double GetBonificacao()
        {
            return Salario * 0.10;
        }
    }

    class Diretor : Funcionario
    {
        public new double GetBonificacao()
        {
            return Salario;
        }
    }

    class Inheritance
    {
        static void Main(string[] args)
        {
            Funcionario carlos = new Funcionario();
            carlos.Nome = "Carlos";
            carlos.CPF = "546.879.157-20";
            carlos.Salario = 2000f;

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Diretor roberta = new Diretor();
            roberta.Nome = "Roberta";
            roberta.CPF = "345.323.765-90";
            roberta.Salario = 7800f;

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.ReadLine();
        }
    }
}
