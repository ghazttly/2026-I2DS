internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Digite a 1ª Nota: ");
        double nota1 = int.Parse(Console.ReadLine());

        Console.Write("Digite a 2ª Nota: ");
        double nota2 = int.Parse(Console.ReadLine());

        Console.Write("Digite a 3ª Nota: ");
        double nota3 = int.Parse(Console.ReadLine());

        double nota = nota1 + nota2 + nota3 / 3;
        if(nota >= 7)
        {
            Console.WriteLine("Situaçao: Aprovado");
        }
        if(nota >= 5)
        {
            Console.WriteLine("Situaçao: Recuperaçao");
        }
        else
        {
            Console.WriteLine("Situaçao: Reprovado");
        }

    }
}