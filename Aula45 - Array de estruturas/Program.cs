using System;

namespace Aula45
{

    struct Carro {
    
        public string modelo;
        public string cor;

       public void info() {
         
            Console.WriteLine($"Modelo: {this.modelo}\nCor: {this.cor}\n\n");
           System.Console.WriteLine("---------------------");
       }
    }

    class Program
    {
        static void Main(string[] args)
        {
           // int[] numeros = new int[10];

            Carro[] carros = new Carro[3];
          
            carros[0].modelo = "Fusca";
            carros[0].cor = "Prata";
            
            carros[1].modelo = "Honda";
            carros[1].cor = "Preto";

            carros[2].modelo = "Corsa";
            carros[2].cor = "Vermelho";

            for(int i = 0; i <carros.Length; i++) {
                carros[i].info();
            }
            
        }
    }
}
