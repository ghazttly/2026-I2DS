internal class Program
{
    public class Cidade
    {
        public string? Nome {get;set;}
    }
    private static void Main(string[] args)
    {
        List<Cidade> listaCidades = new List<Cidade>();
        Cidade cidade1 = new Cidade{Nome = "Xique-Xique"};
        Cidade cidade2 = new Cidade{Nome = "Venha-Ver"};
        Cidade cidade3 = new Cidade{Nome = "Rolândia"};
        Cidade cidade4 = new Cidade{Nome = "Nova Iorque"};
        Cidade cidade5 = new Cidade{Nome = "Volta Redonda"};

        listaCidades.Add(cidade1);
        listaCidades.Add(cidade2);
        listaCidades.Add(cidade3);
        listaCidades.Add(cidade4);
        listaCidades.Add(cidade5);

        foreach (var cidade in listaCidades)
        {
            Console.WriteLine($"{cidade.Nome}");
        }
    }
}