using System;

namespace Aula29
{

    public class Jogador {
        public int energy;
        public Boolean alive;
        public string nome; //global

        public Jogador(string n) //método construtor
        {
            energy = 100;
            alive = true;
            nome = n;
        }

         ~Jogador() //destrutor nao precisa de modificador de acesso
        {
            Console.Write($"Jogador {nome}foi destruido.");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string nome1;
        

            Console.Write("Digite o nome do jogador1: ");
            nome1 = Console.ReadLine();

            Jogador j1 = new Jogador(nome1);
            Jogador j2 = new Jogador("theo");
          
            Console.WriteLine($"Energy J1: {j1.energy}");
            Console.WriteLine($"Energy J2: {j2.energy}");
            Console.WriteLine($"Name J1: {j1.nome}");
            Console.WriteLine($"Name J2: {j2.nome}\n\n");
            
        }
        
    }
}

