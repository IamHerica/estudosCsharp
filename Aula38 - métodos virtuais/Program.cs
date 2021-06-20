using System;

//metodos virtuais são métodos que possuem o mesmo nome em classes diferentes (de uma classe que herda outra)

namespace Aula38
{

    class Base {
        public Base() {
            Console.WriteLine("Construtor da classe Base.");
        }
        virtual public void info(){ //virtual pq ele sera sobrescrito
        } //nao precisa de assinatura pois ele sera um metodo sobrescrito
    }

    class Derivada1:Base {

        public Derivada1(){
            Console.WriteLine("Construtor da derivada 1.");
        }
         override public void info(){ //override significa que o metodo existe na classe base e ta sendo sobrescrito na classe derivada
            Console.WriteLine("Derivada 1 - override deu certo");
        }
    }
    class Derivada2:Derivada1 {

        public Derivada2(){
            Console.WriteLine("Construtor da derivada 2.");
        }

          override public void info(){ //override significa que o metodo existe na classe base e ta sendo sobrescrito na classe derivada
            Console.WriteLine("Derivada 2 - override deu certo");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Base Ref; //elemento de referencia que pode receber as classes derivadas dessa clase
            Derivada1 d1 = new Derivada1();
            Derivada2 d2 = new Derivada2();
            
            Ref = d1;
            
            Ref.info();
      
        }
    }
}
