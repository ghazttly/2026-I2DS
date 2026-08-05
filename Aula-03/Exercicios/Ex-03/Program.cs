internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Nome do aluno: ");
        string nome = Console.ReadLine();

        Console.Write("Digite a primeira nota: ");
        double nota1 = double.Parse(Console.ReadLine());


        Console.Write("Digite a segunda nota: ");
        double nota2 = double.Parse(Console.ReadLine());


        Console.Write("Digite a terceira nota: ");
        double nota3 = double.Parse(Console.ReadLine());


        double media = CalcularMedia(nota1,nota2,nota3);

        string situacao = VerificarSituacao(media);

        Console.WriteLine();

        Console.WriteLine($"Aluno: {nome}");
        Console.WriteLine($"Média: {media:F1}");
        Console.WriteLine($"Situação: {situacao}");
    }


    static double CalcularMedia(double n1,double n2, double n3)
    {
        return (n1 + n2 + n3) / 3;
    }


    static string VerificarSituacao(double media)
    {
        if(media >= 7)
        {
            return "Aprovado";
        }
        else if(media >= 5)
        {
            return "Recuperação";
        }
        else
        {
            return "Reprovado";
        }
    }
}