using System;

namespace Aula18
{
    class Program
    {
        static void Main()
        {
            int[,] n = new int[2,2]; //3 linhas e 5 colunas

            n[0,0] = 1;
            n[0,1] = 2;
            n[1,0] = 4;
            n[1,1] = 5;
    
            Console.WriteLine(n[0,1]);

        }
    }
}
