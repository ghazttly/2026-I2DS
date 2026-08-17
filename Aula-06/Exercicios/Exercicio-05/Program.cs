internal class Program
{
    
    private static void Main(string[] args)
    {
        Stack<string> pilhaAcoes = new Stack<string>();

        pilhaAcoes.Push("Apagar");
        pilhaAcoes.Push("Negrito");
        pilhaAcoes.Push("Colar");
        pilhaAcoes.Push("Digitar");

        foreach (var item in pilhaAcoes)
        {
            Console.WriteLine(item);
        }

        
    }
}
