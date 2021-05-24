using System;

namespace Aula20___While
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] num = new int[10];
            int i = 0;

            //uso do While quando nao saber quantas vezes irá rodar

            while(i < num.Length) {
                num[i] = i+1;
                Console.WriteLine($"Rodando o WHILE na {num[i]} vez");
                i++;
            }
            Console.Write("Fim do Loop!");
        }
    }
}
