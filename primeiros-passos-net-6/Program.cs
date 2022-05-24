// See https://aka.ms/new-console-template for more information
// Versão > 6.1 : Console.WriteLine("Hello, World!");
// https://docs.microsoft.com/pt-pt/dotnet/core/tutorials/top-level-templates

using System;
using PrimeirosPassosNet.estruturaDados;

namespace PrimeirosPassosNet // Note: actual namespace depends on the project name.
{
    static class Program
    {
        static void Main()
        {
            // Primeira Aula
            int quantidadeVezes = 100;

            for(int contador = 1; contador <= quantidadeVezes; contador++){
                Console.WriteLine(" Contador: " + contador + " Quantidade de vezes: " +  quantidadeVezes);
                Console.WriteLine($" Contador: {contador} Quantidade de vezes: {quantidadeVezes}");
            }

            Console.WriteLine("/");

            // Segunda aula
            var pilha = new Pilha();

            pilha.Empilha(2);
            pilha.Empilha(3);
            pilha.Empilha(1);

            Console.WriteLine(pilha.Desempilha());
            Console.WriteLine(pilha.Desempilha());
            Console.WriteLine(pilha.Desempilha());

            // Testar o exception
            // Console.WriteLine(pilha.Desempilha());

        }
    }
}
