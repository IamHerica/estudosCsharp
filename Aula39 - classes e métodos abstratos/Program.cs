using System;

//classes abstratas é como uma classe de referencia, serve como base para as bases que iram herdar a classe abstrada
//não implementamos o compotamento do metodo, apenas criamos o prototipo para
//as classes que herdarem implementar la

namespace Aula39
{
//classe base abstrata(só podera usar para herdar)
    abstract class Veiculo { //nao podemos instanciar uma classe abstrata
        protected int velMaxima;
        protected int velAtual;
        protected bool ligado;

        public Veiculo(){
            ligado = false;
            velAtual = 0;
        }

        public void setLigado(bool ligado) { //como não é abstrato, é necessario implementar a funcionalidade
            this.ligado = ligado;
        }

        public int getVelAtual(){
            return velAtual;
        }
        abstract public void aceleracao(int mult);//como é abstrato, quem herdar precisa implementar 
    

    
    }

    class Carro:Veiculo {
        public Carro() {
            velMaxima = 120;
        }
        override public void aceleracao(int mult) {
            velAtual += 10*mult;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro();

            c1.aceleracao(1);
            c1.aceleracao(1);
            c1.aceleracao(1);
            c1.aceleracao(-1);

            Console.WriteLine(c1.getVelAtual());
        }
    }
}
  