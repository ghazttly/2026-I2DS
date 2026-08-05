internal class Program
{
    private static void Main(string[] args)
    {
        /* se (condiçao) for verdadeiro
                execute essa funçao
            senao
                execute esa funçao

            if(condiçao)
            {
                codigo se verdade
            }else{
                codigo se falso
            }
        */

        // verificar se uma idade é maior que 18 anos
        int idade = 15;
        if(idade >= 18)
        {
            Console.WriteLine("Maior de idade");
        }
        else
        {
            Console.WriteLine("Menor de idade");
        }
        
        /* ******************************************** */
        Console.Write("Digite a Nota: ");
        int nota = int.Parse(Console.ReadLine());

        if(nota >= 7)
        {
            Console.WriteLine("Aprovado");
        }
        else
        {
            Console.WriteLine("Reprovado");
        }

        /* ******************************************** */
        bool bloqueado = false;
        if(!bloqueado)
        {
            Console.WriteLine("Acesso Permitido!");
        }

        /* ******************************************** */
        Console.WriteLine("1 - Cadastrar");
        Console.WriteLine("2 - Consultar");
        Console.WriteLine("3 - Excluir");
        Console.WriteLine("4 - Sair");

        Console.Write("Escolha uma opçao: ");
        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1: 
                Console.WriteLine("Cadastro selecionado");
                break;
            case 2: 
                Console.WriteLine("Consulta selecionada");
                break;
            case 3: 
                Console.WriteLine("Exclusao selecionada");
                break;
            case 4: 
                Console.WriteLine("Encerrando on sistema");
                break;
            default:
                Console.WriteLine("Opçao inválida");
                break;
        }
    }
}