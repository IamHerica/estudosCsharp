using System;

namespace Aula41
{

    class Carro {
        private int velMax;
        public int vm {
            get { //read only
                return velMax;
            }
            set { //write only
                if(value < 0)
                    velMax = 0;
                else if (value > 300)
                    velMax = 300;
                else 
                    velMax = value;
            }
        }
        public Carro(){
            vm = 120;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro();

            Console.WriteLine($"Velocidade: {c1.vm}");
        }
    }
}
