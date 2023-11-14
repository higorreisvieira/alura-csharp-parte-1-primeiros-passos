namespace Exercicio_LacoDeRepeticaoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*

            1) Crie um projeto, no curso demos o nome de "LacoDeRepeticaoWhile".

            2) Escreva o while que imprime os números de 0 a 10. 
            Lembre-se de criar sua variável contador com o valor 0.

            */

            int contador = 0;

            while (contador < 10)
                {                
                    contador = contador + 1;
                    Console.WriteLine(contador);
                }
             Console.ReadLine();
        }
    }
}