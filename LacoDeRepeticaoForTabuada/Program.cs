namespace LacoDeRepeticaoForTabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int multiplicador = 1; multiplicador <=10 * multiplicador++)
            {
                for (int contador = 1; contador <= 10; contador++)
                {
                    Console.Write(multiplicador + " * " + contador + " = " + multiplicador * contador);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}