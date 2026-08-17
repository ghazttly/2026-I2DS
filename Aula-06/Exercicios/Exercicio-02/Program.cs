internal class Program
{
    public class Numero
    {
        public int Valor {get;set;}
    }
    private static void Main(string[] args)
    {
        List<Numero> listaNumeros = new List<Numero>();
        Numero numero1 = 10;
        Numero numero2 = 25;
        Numero numero3 = 8;
        Numero numero4 = 42;
        Numero numero5 = 15;
        Numero numero6 = 30;

        listaNumeros.Add(numero1);
        listaNumeros.Add(numero2);
        listaNumeros.Add(numero3);
        listaNumeros.Add(numero4);
        listaNumeros.Add(numero5);
        listaNumeros.Add(numero6);

        foreach (var numero in listaNumeros)
        {
            Console.WriteLine($"{numero.Valor}");
        }
    }
}