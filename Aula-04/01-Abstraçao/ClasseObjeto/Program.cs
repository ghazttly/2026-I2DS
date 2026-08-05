internal class Program
{
    private static void Main(string[] args)
    {
        /* 
        Classe -> é a abstraçao de um objeto do mundo real para o mundo computacional
        Objeto -> é a instancia de uma classe
        */

        //Instanciar um objeto do tipo Aluno
        Aluno aluno01 = new Aluno();
        Aluno aluno02 = new Aluno();

        //Atribuir valores
        aluno01.Nome = "José da Silva";
        aluno01.RM = 2444;
        aluno01.DataNascimento = new DateOnly(2010,01,15);

        aluno02.Nome = "Joao dos Santos";
        aluno02.RM = 1234;
        aluno02.DataNascimento = new DateOnly(2006,12,07);

        //Executar os Metodos
        aluno01.ApresentarSe();
        aluno02.ApresentarSe();

    }

    public class Aluno //Declaraçao de uma classe
    {
        //Atributos -> características
        public string Nome {get; set;}
        public int RM {get; set;}
        public DateOnly DataNascimento {get;set;}

        //Métodos -> açoes ou funcionalidades
        public void ApresentarSe ()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, meu RM é {RM}, Nasci na data {DataNascimento}");
        }
    }
}