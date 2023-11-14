namespace P13_ForEncadeado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 13");

            // *
            // **
            // ***
            // ****
            // *****
            // *******
            // ********

            for (int contadorLinha = 0; contadorLinha <10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna <10; contadorColuna++)
                {
                    Console.Write("*");
                   01-ByteBank if (contadorColuna >= contadorLinha)                   
                        break;            
                }
                Console.ReadLine();         
            } // END FOR LOOPING
        }
    }
}
