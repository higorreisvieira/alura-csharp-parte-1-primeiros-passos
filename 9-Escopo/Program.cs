namespace _9_Escopo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9 - Condicionais");

            int idadeJoao = 18;
            //int quantidadePessoas = 2;
            //bool acompanhado = quantidadePessoas >= 2;
            bool acompanhado = true;
            string mensagem;

            if (acompanhado == false) {

                mensagem = "João está acompanhado!";
                
            } else
            {
                mensagem = "João está sozinho";
            }

            ,






















            if (idadeJoao >= 18 || acompanhado == true) // || é o operador lógico equivalente à Or em c# e o && equivalente a And
            {
                Console.WriteLine("João pode entrar.");
                Console.WriteLine(mensagem);
            }
            else
            {
                Console.WriteLine("João não pode entrar.");
            }
            Console.ReadLine();
        }
    }
}