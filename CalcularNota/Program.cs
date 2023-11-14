namespace CalcularNota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variável que irá armazenar o valor de cada nota, sendo n1 o valor da Nota 1, n2 e assim sucessivamente.
            double n1, n2, n3, n4;

            Console.WriteLine("Digite a primeira nota: ");
            n1 = Convert.ToDouble(Console.ReadLine()); // Comando usado para ler o que foi digitado e armazená-lo na variável n1
            
            Console.WriteLine("Digite a segunda nota: "); // Input de informação
            n2 = Convert.ToDouble(Console.ReadLine()); // Lê o que foi digitado e armazena na double n2

            Console.WriteLine("Digite a terceira nota: ");
            n3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digie a quarta nota: ");
            n4 = Convert.ToDouble(Console.ReadLine());

            double media; 
            media = (n1 + n2 + n3 + n4) / 4; // 

            if (media < 5) // O aluno será reprovado caso a sua nota seja menor do que 5.
            {
                Console.WriteLine("Reprovado");
            } else { // Mas se caso sua nota for maior do que 5, ele será aprovado pelo sistema.
                Console.WriteLine("Aprovado!");
            };
        }
    }
}