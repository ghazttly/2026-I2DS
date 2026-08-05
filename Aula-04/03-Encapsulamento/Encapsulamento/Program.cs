internal class Program
{
    private static void Main(string[] args)
    {
        /*
        encapsulamento -> visa "proteger" as propriedades da classe
        */

        Pessoa p1 = new Pessoa("Asdrubal","(14)99966-8822","asdrubal@gmail.com");

    }
    public class Pessoa
    {
        //Modificador de acesso privado -> os atributos só podem ser acessados pela própria classe
        private string Nome {get;set;} 
        private string Celular {get;set;}
        private string Email {get;set;}

        //Alterar o método construtor para receber os parametros para receber os parametros na criaçao do objeto
        public Pessoa(string nome, string celular, string email)
        {
            this.Nome = nome;
            this.Celular = celular;
            this.Email = email;
        }
        public void ApresentarSe()
        {
        Console.WriteLine($"Nome: {this.Nome} - Celular: {this.Celular} - E-mail: {this.Email}");
        }
        public void AlterarCelular(string celular)
        {
            this.Celular = celular;
        }
    }
}