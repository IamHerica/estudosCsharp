using System;
//funcao que chama ela mesma

namespace Aula48
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

        public int fatorial(int n) {
            int resultado;
            
            if(n <=1 ) {
                resultado=1;
            } else {
               resultado = n* fatorial(n-1);
            }
            return resultado;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
        
            Calc calculadora = new Calc();

            int resultadoFat = calculadora.fatorial(10);

            System.Console.WriteLine(resultadoFat);
        }
    }
}