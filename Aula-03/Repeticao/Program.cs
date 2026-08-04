internal class Program
{
    private static void Main(string[] args)
    {
        /* Sintaxe: 
            enquanto uma condiçao for verdade

                executar um conjunto de comandos
            
        for -> quando sabemos a quantidade de repetiçoes
        while -> quando a repetiçao depende de uma condiçao
        do ... while -> quando precisa executar ao menos uma vez o bloco de código
        */ 

        /* Laço for: imprimir numeros de 1 até 10 */
        Console.WriteLine("Imprimir numeros de 1 até 10 utilizando o laço for");
        for (int numero = 1; numero <= 10; numero++)
        {
            Console.WriteLine(numero);
        }

         /* Laço for: contagem regressiva de 10 até 0 */
        Console.WriteLine("Imprimir contagem regressiva");
        for (int numero = 10; numero >= 0; numero--)
        {
            Console.WriteLine(numero);
        }

        /* ************************************************ */
        Console.WriteLine("Imprimir numeros de 1 até 10, utilizando o laço while");

        int contador = 1;
        while (contador <= 10)
        {
            Console.WriteLine(contador);
            contador++;
        }

        /* solicitar a senha até acertar */
        string senha = "";
        while(senha != "2444")
        {
            Console.Write("Digite a Senha: ");
            senha = Console.ReadLine();
        }
        Console.WriteLine("Acesso permitido!");

        /* ************************************************ */
        int num;
        do
        {
            Console.Write("Digite um numero positivo: ");
            num = int.Parse(Console.ReadLine());
        } while(num <= 0);
    }
}