﻿namespace _7_Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            if (idadeJoao >= 18) {

                Console.WriteLine("João possui mais de 18 anos de idade. Pode entrar.");
            } else {

                if (quantidadePessoas >=2)
                {
                    Console.WriteLine("João possui menos de 18, mas está acompanhado. Pode entrar...");
                } else
                {
                    Console.WriteLine("Não pode entrar. João é menor de idade.");
                }
                
            }
         
            Console.ReadLine();
        }
    }
}