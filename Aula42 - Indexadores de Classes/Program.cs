using System;

namespace Aula42
{

    class Carro {
        private int[] velMax = new int[5] {80, 120, 160, 240, 300};
        public int this[int i] {
            get { //read only
                return velMax[i];
            }
            set { //write only
                if(value < 0)
                    velMax[i] = 0;
                else if (value > 300)
                    velMax[i] = 300;
                else 
                    velMax[i] = value;
            }
        }
        public Carro(){
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro();

            c1[4] = 200;
            Console.WriteLine($"Velocidade: {c1[4]}");
        }
    }
}
