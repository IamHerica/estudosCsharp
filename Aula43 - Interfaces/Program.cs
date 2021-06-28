using System;
//interfaces tem uma semelhanca com classes abstardas. a diferenca é que as interfaces apenas implementam
//os metodos ou seus prototipos, nao usa as propriedades/campos nas interfaces. (usa apenas a assinatura)
// - nao pode ter construtor/destrutor
//- nao pode definir membros static
//- nao pode declarar suas propriedades 

namespace Aula43
{
    public interface Veiculo{
        //coloca a assinatura dos metodos que serao obrigatorios
        void ligar();
        void desligar();
        void info();
    }

    public interface Combate {
        void disparar(); 
    }

    class Carro : Veiculo, Combate{ //usando a interface veiculo e a interface combate

     public bool ligado;
     private int municao;
        public Carro(){
            setMunicao(100);
        }

        public void setMunicao(int qtd) {
            this.municao = qtd;

        }
        public void ligar() {
            this.ligado = true;
        }

        public void desligar() {
            this.ligado =  false;
        }

        public void disparar() {

        }

        public void info() {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro();
            Console.WriteLine("Hello World!");
        }
    }
}
