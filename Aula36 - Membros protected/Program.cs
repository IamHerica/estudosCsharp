using System;

namespace Aula36
{

    class Veiculo 
    { //base
        public int velAtual;
        private int velMax; //apenas a base consegue acessar
        protected bool ligado; //base e derivada conseguem acessar

     public Veiculo(int velMax)
     {
         velAtual = 0;
         this.velMax = velMax;
        ligado = false;
     }
     public bool getLigado(){
         return ligado;
     }
     public int getVelMax(){
         return velMax;
     }

    }

    class Carro:Veiculo {//Derivada de veiculo
        public string nome;
                                            // inicializar o construtor da classe base
        public Carro(string nome, int vm):base(vm) { //atribuir ao construtor Veiculo
            this.nome = nome;
            ligado =  true; //aqui a diferença  entre protected e private
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro("Carro top", 120);

            Console.WriteLine($"Nome......: {c1.nome}");
            Console.WriteLine($"Vel Max...: {c1.getVelMax()}");
            Console.WriteLine($"Ligado....: {c1.getLigado()}");
        }
    }
}
