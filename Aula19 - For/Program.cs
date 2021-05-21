using System;

namespace Aula19
{
    class Program
    {
        static void Main()
        {
           int i;

           for(i = 0; i <= 3; i++) { //i = 0; i < num.Length; i++ (pega o tamanho da variavel a preencher)
               Console.WriteLine($"Loop rodando na {i}º vez.");
           }
        }
    }
}
