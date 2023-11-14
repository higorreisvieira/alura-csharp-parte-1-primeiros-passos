namespace _4_ConversoesEOutrosTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            // double suporta valores com casas decimais
            double salario;
            salario = 1200.50;

            // int é um tipo de variável que suporta valores até 32bits
            int salarioEmInteiro;
            salarioEmInteiro = (int) salario; // convertendo o tipo do valor da variável, "cast". 

            Console.WriteLine(salarioEmInteiro);

            // O long é uma variável de 64 bits
            long idade;
            idade = 13000000000000;
            Console.WriteLine(idade);

            // short suporta até 16 bits
            short quantidadeProdutos;
            quantidadeProdutos = 100;
            Console.WriteLine(quantidadeProdutos);

            // usa-se o sufixo f pra dizer pro c# que a gente não tá falando de um erro de digitação.
            float altura = 1.80f;

            Console.WriteLine(altura);
            Console.ReadLine();

            // casting implicito
            int myInt = 9;
            double myDouble = myInt; // casting automático: int para double

            Console.WriteLine(myInt); // output 9
            Console.WriteLine(myDouble); // output 9

            // casting explicito
            double myDouble = 9.78;
            int myInt = (int)myDouble; // Casting manual: double para int

            Console.WriteLine(myInt); // output 9.78
            Console.WriteLine(myDouble); // output 9

            // boolean 1 byte
            // byte    1 byte
            // short   2 bytes
            // char    2 bytes
            // int 4 bytes
            // float   4 bytes
            // long    8 bytes
            // double  8 bytes
        }
    }
}