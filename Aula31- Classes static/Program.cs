using System;

namespace Aula30{
    static public class Jogador { //static nao pode ter construtor e nao permite instanciamento
    //classes static precisam de membros static
        static public int energy;
        static public bool alive;
        static public string nome; 
        static public void iniciar(string n){ 
            energy = 100;
            alive = true;
            nome = n;
        }
         static public void info()
         {
            Console.WriteLine($"Nome do jogador: {nome}");
            Console.WriteLine($"Energia do jogador: {energy}");
            Console.WriteLine($"Situação do jogador: {alive}\n");
         }

    }

        class Inimigo {
            static public bool alerta; //static para todos inimigos entrarem no mesmo estado de alerta
            public string nome;
            
            public Inimigo(string n) {
                alerta = false;
                nome = n;
            }

            public void info(){
                Console.WriteLine(nome);
                Console.WriteLine(alerta);
                Console.WriteLine("--------------------------");
            }
        }
        class Program
    {
        static void Main()
        {
          
        Jogador.iniciar("Bruno");
        Jogador.info();

        Inimigo i1 = new Inimigo("doido");
        Inimigo i2 = new Inimigo("Maluco");
        Inimigo i3 = new Inimigo("Pirado");

        Inimigo.alerta=true; //mudar a situação do alerta para todos os inimigos

        i1.info();
        i2.info();
        i3.info();

            
        }
        
    }

    }
    

