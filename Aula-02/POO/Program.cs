using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {

        //Comentário de linha
        /*
        Comentário de Bloco
        Pode ter Várias linhas
        */


        //Escreve uma Linha de Texto na tela
        Console.WriteLine("Programação Orientada a Objetos\n");

        Console.WriteLine("Abstração - 1 Pilar da POO");

        /* Criar uma classe em C#
         A classe deve ser declarada fora do bloco de programa
        */


     Pet pet1 = new Pet();
     pet1.nome = "Totó";
     pet1.tipo = "Cachorro";
     pet1.idade = 3; 
     pet1.MostrarNome();

       Pet pet2 = new Pet();
     pet2.nome = "Mingau";
     pet2.tipo = "Gato";
     pet2.idade = 8; 
     pet2.MostrarNome();
    }
    public class Pet // Nome da classe sempre inicia com a letra Maiuscula
    {
        //Declaraçao dos Atributos
        public string nome;
        public string tipo;
        public int idade;
        //Deraçao dos Métodos
        public void MostrarNome()
        {
            Console.WriteLine("Meu nome é " + this.nome);
        }
    }
}