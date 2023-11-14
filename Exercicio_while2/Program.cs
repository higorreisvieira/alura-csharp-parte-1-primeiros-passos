namespace Exercicio_while2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Faça um programa, utilizando while, que mostre na tela de 0 até N, em que N é o limite inserido pelo usuário.
            int contador = 0;
            int n = 250;

            while (contador < n) { // enquanto o contador for menor do que a variável limite "n"

                        Console.WriteLine(contador);
                        contador++;

                    }
 
        }
    }
}