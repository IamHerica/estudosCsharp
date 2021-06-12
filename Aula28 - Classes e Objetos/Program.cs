using System;

namespace Aula28
{

    public class Jogador { //quando nao usa modificador de classe, ela é definida como public
        public int energy = 100;
        public Boolean alive = true;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Jogador j1 = new Jogador();
            Jogador j2 = new Jogador();
            Jogador j3 = new Jogador();

            j1.energy = 50;
            Console.WriteLine($"Energy J1: {j1.energy}");
            Console.WriteLine($"Energy J2: {j2.energy}");

        }
        
    }
}
