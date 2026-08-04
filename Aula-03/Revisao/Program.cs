internal class Program
{
    private static void Main(string[] args)
    {
        /* Criar uma variável
         Sintaxe: tipo variavel  nome variavel = valor variavel
         
         Tipos de dados Primarios*/

         /* 
         int -> Representaçao de numeros inteiros
         */
         int idade = 21;

        /* double -> Representaçao de numeros decimais*/
        double salario = 10352.25;
        float altura = 1.75f;
        decimal peso = 71.35m;

        /* string -> representaçao de um texto alphanumerico*/
        string nome = "Thomaz";
        string celular = "14996667788";
        string cpf = "123.456.789.03";

        /* bool -> representa um numero Booleano (true or false)*/
        bool estudante = true;
        bool temLimite = false;

        /* DtaeTime -> representaçao de data e hora*/
        DateTime cadastro = new DateTime(2026,08,04,09,15,32);
        DateOnly nascimento = new DateOnly(2010,01,20);

        /* ******************************************* */
        /* Operadores matematicos 
            + -> somar
            - -> subtrair
            * -> mutiplicar
            / -> dividir
            % -> resto da divisao
            ** -> exponenciaçao
        */
        int n1 = 10;
        int n2 = 3;
        double resultado = 0;

        //calcular a soma: 
        resultado = n1 + n2;
        Console.WriteLine("A soma dos dois numeros é: " + resultado);

        //calcular a subtraçao: 
        resultado = n1 - n2;
        Console.WriteLine("A subtraçao dos dois numeros é: " + resultado);

        //calcular a multiplicaçao: 
        resultado = n1 * n2;
        Console.WriteLine("A smultiplicaçao dos dois numeros é: " + resultado);
    
        //calcular a divisao: 
        resultado = n1 / n2;
        Console.WriteLine("A divisao dos dois numeros é: " + resultado);

        //calcular a soma: 
        resultado = n1 % n2;
        Console.WriteLine("O resto da divisao dos dois numeros é: " + resultado);

         // Calcular a potencia: 
        resultado = n1 ^ n2;
        Console.WriteLine("O numero 1 elevado ao numero 2 é: " + resultado);


        /* operador de incremento ++ */
        Console.WriteLine("Valor de N1: " + n1);
        n1++; //Aumento o numero atual em +1
        Console.WriteLine("Valor de N1: " + n1);

        /* operador de incremento += */
        n1+=10; // n1 = n1+ 10
        n1 = n1 + 10;
        Console.WriteLine("Valor de N1: " + n1);

         /* operador de incremento -- */
        Console.WriteLine("Valor de N1: " + n1);
        n1--; //Aumento o numero atual em +1
        Console.WriteLine("Valor de N1: " + n1);

        /* operador de incremento -= */
        n1-=10; // n1 = n1+ 10
        n1 = n1 + 10;
        Console.WriteLine("Valor de N1: " + n1);

        /* ******************************************* */
        /* Operadores relacionais -> realizam comparaçoes*/
        /*  > -> maior que
            < -> menor que
            >= -> maior ou igual
            <= -> menor ou igual
            ! -> igual
        */
        idade =13;
        Console.WriteLine("A idade informada é maior que 18? " + (idade > 18));
        peso = 55;
        Console.WriteLine("O peso informado é menor que 60Kg? " + (peso <= 60));

        estudante = false;
        Console.WriteLine("O nome informado é de um estudante? " + (estudante ==true));

        /* ******************************************* */
        /* operadores logicos -> permitem combinar duas ou mais condiçoes*/
        /*
            && -> operador logico "E""
            || -> operador logico "OU"
            ! -> operador de negaçao
        */

        peso = 83;
        altura = 183;

        Console.WriteLine("Peso: " + peso + "Altura: " + altura);
        Console.Write((peso <= 100) && (altura > 180));

    }
}