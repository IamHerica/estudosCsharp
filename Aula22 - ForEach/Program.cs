using System;

namespace Aula22
{
    class Program
    {
        static void Main( )
        {
            int[] num = new int[3] {00, 11, 22};

            /*for (int i = 0; i < num.Length; i++) {//o tamanho de num é 2, pois tem indice 0,1,2
                Console.WriteLine(num[i]);
            } 
            */

            foreach (int n in num) {
                Console.WriteLine(n);
            } // n é uma variavel de iteração
        }
    }
}
