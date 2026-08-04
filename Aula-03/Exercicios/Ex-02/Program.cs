using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {
        int num1;
        int num2;

        Console.Write("Digite um numero: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Digite outro numero: ");
        num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("1 - Somar");
        Console.WriteLine("2 - Subtrair");
        Console.WriteLine("3 - Multiplicar");
        Console.WriteLine("4 - Dividir");

        string operacao;

        Console.Write("Selecione uma operacao: ");
        operacao = Console.ReadLine();

        switch (operacao)
        {
            case "1": 
                Console.WriteLine(num1 + num2);
                break;
            case "2": 
                Console.WriteLine(num1 - num2);
                
                break;
            case "3": 
                Console.WriteLine(num1 * num2);
                break;
            case "4": 
                Console.WriteLine(num1 / num2);
                break;
            default:
                Console.WriteLine("Opçao inválida");
                break;
        }

        
    }
}