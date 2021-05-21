using System;

namespace Aula07
{
    class Program
    {
        static void Main()
        {
            //as regras de declaracao sao as mesma, mas na constante
            //o valor nao pode ser modificado durante o programa.

            const string kkkkkk = "heheheh";
            const double pi = 3.1415;

            Console.WriteLine("Qual sua risada preferida? {0}", kkkkkk);
            Console.WriteLine("O valor de pi eh: {0}", pi);
        }
    }
}
