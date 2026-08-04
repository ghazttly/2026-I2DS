internal class Program
{
    private static void Main(string[] args)
    {
        /* vetores e matrizes
            vetor -> é uma estrutura de dados utilizada para armazenar varios valores de um msmo tipo dentro de uma unica variavel
            
            Sintaxe: tipo[] nome vetor = new tipo[tamanho];
        */

        /* Iniciar um vetor -> lista de frutas */
        string[] ListaFrutas = {"Maça", "Manga", "Melancia", "Morango", "Melao"};

        Console.WriteLine("Acessar o terceiro elemento da lista: ");
        Console.WriteLine(ListaFrutas[2]);

        Console.WriteLine("Alterar o segundo elemento da lista: ");
        ListaFrutas[1] = "Banana";

        for (int indice = 0; indice < ListaFrutas.Count(); indice++)
        {
            Console.WriteLine(ListaFrutas[indice]);
        }

        /* ****************************************** */
        foreach (string fruta in ListaFrutas)
        {
            Console.WriteLine(fruta);
        }

    }
}