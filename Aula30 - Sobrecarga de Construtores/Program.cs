using System;

namespace Aula30{
    public class Jogador {
        public int energy;
        public Boolean alive;
        public string nome; //global
        public Jogador(){ //quando nao passar nenhum paramentro
            energy = 100;
            alive = true;
            nome = "Jogador";
        }

        }
        public  Jogador(string n) //quando passar o nome jogador
        {
            energy = 100;
            alive = true;
            nome = n;
        }
        public Jogador(string n, int e) //quando passar o nome jogador
        {
            energy = e;
            alive = true;
            nome = n;
        }
        public Jogador(string n, int e, bool v) //quando passar o nome jogador
        {
            energy = e;
            alive = v;
            nome = n;
        }

        public void info(){
            Console.WriteLine($"Nome do jogador: {nome}");
            Console.WriteLine($"Energia do jogador: {energy}");
            Console.WriteLine($"Situação do jogador: {alive}\n");
        }


    }
    class Program
    {
        static void Main(string[] args)
        {

            Jogador j1 = new Jogador();
            Jogador j2 = new Jogador("theo");
            Jogador j3 = new Jogador("bruno", 100);
            Jogador j4 = new Jogador("Mateus", 30, false);
          
           j1.info();
           j2.info();
           j3.info();
           j4.info();
    
            
        }
        
    }


