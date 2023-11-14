namespace P12_CalculaInvestimentoLongoPrazo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 12");

            double valorInvestido = 1000;
            double fatorRendimento = 1.0036;

            for (int contadorAno = 1; contadorAno <= 5; contadorAno++)
            {
                for(int contadorMes = 1; contadorMes <12; contadorMes++)
                {
                    valorInvestido = valorInvestido * fatorRendimento;
                }

                fatorRendimento += 0.0010;
            }

                Console.WriteLine("Ao término do investimento, você terá R$" + valorInvestido);

                Console.ReadLine();

                

                for (int contador = 1; contador <= 10; contador++)
                {
                    Console.WriteLine(contador);
                }
        }
    }
}