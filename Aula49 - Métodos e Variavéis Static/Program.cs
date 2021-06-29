using System;

//quer utilizar os metodos de uma classe, mas nao precisa declarar um objeto dessa classe

namespace Aula49
{

    class Mat{
        public static double pi = 3.14;


        public static dobro (int n) {
            return n*2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            double vpi = Mat.pi; //posso acessar pq a variavel é static
            int num = 10;
        
            Console.WriteLine($"O dobro de {num} é:" + Mat.dobro(num));
        }
    }
}
