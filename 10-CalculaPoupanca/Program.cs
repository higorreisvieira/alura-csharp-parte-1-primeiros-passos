namespace _10_CalculaPoupanca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Incício do projeto 10 - Calcular a poupança!");
            // double valorInvestido = 1000;
             double valorInvestido = 1000;
             // 0.36% = 0.0036
             valorInvestido = valorInvestido + valorInvestido * 0.0036; // valor investido recebe valorInvestido + valorInvestido
             Console.WriteLine("Após 1 mês, você terá R$" + valorInvestido);

             valorInvestido = valorInvestido + valorInvestido * 0.0036;
             Console.WriteLine("Após 2 meses, você terá R$" + valorInvestido);

             Console.ReadLine();
           

             int contadorMes = 1;

            while (contadorMes <12) 
                {
                    // enquanto o contador for menor do que 12, faça isso:
                    valorInvestido = valorInvestido + valorInvestido * 0.0036;
                    Console.WriteLine("Após " + contadorMes + " meses, você terá R$" +valorInvestido);

                // contadorMes = contadorMes + 1; // aqui pega o contador que eu criei, atribui o valor 1 e executa até chegar o 12 q eu criei ali em cima.
                // contadorMes += 1;
                contadorMes++;
            }

             int contador = 1;

            while (contador <= 10) {
                Console.WriteLine(contador);

                contador++; // +1, enquanto não chegar no 10 o while continua funcionando.  
                }
   
        }
    }
}