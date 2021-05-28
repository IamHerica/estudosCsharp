using System;

namespace Aula27
{
    class Program
    {
        static void Main(string[] args)
        {
            soma(9, 8, 9, 6, 4);
        }
        //params não precisa especificar quantos paramentros eu quero, ou seja, posso entrar com 0 
        //ou mais parametros
        static void soma(params int[]n)
        { //isso é um método
            int resul = 0;

            if (n.Length < 1)
            {
                Console.WriteLine("Não há valores a serem somados.");
            }
            else if (n.Length < 2)
            {
                Console.WriteLine("Não é possível executar uma soma somente com um valor.");
            } else {
                for(int i = 0; i < n.Length; i++){
                    resul+= n[i];
                }
                Console.WriteLine($"SOMA = {resul}");
            }
        }
    }
}
