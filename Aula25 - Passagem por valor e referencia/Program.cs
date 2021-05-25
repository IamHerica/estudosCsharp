using System;

namespace Aula25
{
    class Program
    {
        static void Main()
        {
            int v = 10;
            //dobrar0(v); passagem por valor
            dobrar(ref v); //passagem por referencia
            Console.WriteLine(v);
        }
        static void dobrar(ref int valor) {
            valor*=2;
        }
    }
}
