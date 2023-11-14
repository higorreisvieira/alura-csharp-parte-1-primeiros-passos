namespace _8_Condicionais2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais");

              int idadeJoao = 18;
              //int quantidadePessoas = 2;
              //bool acompanhado = quantidadePessoas >= 2;
              bool acompanhado = true;

              if (idadeJoao >= 18 && acompanhado == true) // || é o operador lógico equivalente à Or em c# e o && equivalente a And
              {
                  Console.WriteLine("João pode entrar.");
              }
              else
              {
                      Console.WriteLine("João não pode entrar.");
              }

              Console.ReadLine();
        }
    }
}