internal class Program
{
    private static void Main(string[] args)
    {
        int celsius;
        Console.Write("Digite a temperatura em celsius: ");
        celsius = int.Parse(Console.ReadLine());

        double fahreinheit = (celsius * 9 / 5) + 32;

        Console.WriteLine("A temperatura em fahreinheit é: " + fahreinheit);
    }
}