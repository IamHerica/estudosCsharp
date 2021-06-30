using System;
//Delegate é um objeto que pode fazer referencia a metodos dentro da classe


namespace Aula50
{

delegate int Op(int n1, int n2);
    class Mat {
        public static int soma(int n1, int n2) {
            return n1 + n2;
        }

        public static int mult(int n1, int n2) {
            return n1 *n2;
        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            int resultado;

            Op d1 = new Op(Mat.soma);

            resultado = d1(10, 50);
            Console.WriteLine("Soma:" + resultado);

            d1 = new Op(Mat.mult); //como mat é static, precisou referenciar

            resultado= d1(10, 50);
            Console.WriteLine("Multiplicação:" + resultado);


        }
    }
}
