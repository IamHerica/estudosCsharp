using System;

namespace Aula46
{

    class Galinha {

        private string nomeGalinha;
        private int numOvo;
        public Galinha(string nomeGalinha) {
            this.nomeGalinha = nomeGalinha;
            numOvo = 0;
        }

        public Ovo botar(){
            numOvo++;
            return new Ovo(numOvo, nomeGalinha);
        }
    }
    class Ovo {
        private int numOvo;
        private string minhaGalinha;
        public Ovo (int numOvo, string minhaGalinha){
            this.numOvo = numOvo;
            this.minhaGalinha = minhaGalinha;
            Console.WriteLine($"Ovo {this.numOvo} criado pela galinha {this.minhaGalinha}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Galinha g1 = new Galinha("Giu");
            Galinha g2 = new Galinha("Pinga");
            Galinha g3 = new Galinha("Felipa");

            g1.botar();
            g1.botar();
            g1.botar();
            g1.botar();
            g1.botar();
            
            g2.botar();

            g3.botar();


            Console.WriteLine("Hello World!");
        }
    }
}
