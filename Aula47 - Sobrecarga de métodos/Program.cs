using System;

namespace Aula47
{

    class Calc{

        public int soma(params int[]n) {

            int soma = 0;
            for(int i = 0; i < n.Length; i++) {
                soma+=n[i];
            }
            return soma;
        }

         public double soma(params double[] n) { //sobrecarga
            double soma = 0;
            for(int i = 0; i < n.Length; i++) {
                soma+=n[i];
            }
            return soma;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
           /* int resultado;
            Calc calculadora = new Calc();
            resultado = calculadora.soma(10, 5);
            */

            double resultado;
            Calc calculadora = new Calc();
            resultado = calculadora.soma(10.5, 5.9, 9.7);
          

           


            Console.WriteLine("Resultado = "+ resultado);
        }
    }
}
