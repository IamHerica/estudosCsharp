using System;

namespace Aula33
{

    class Jogador {

        private int energia;
        private string nome;
        public Jogador(string nome) {
            this.nome = nome;
            energia = 100;
        }
    //para obter valores private
        public int getEnergia() { // get = obter
            return energia;
        }
        public string getNome() {
            return nome;
        }

        public void setEnergia(int e) {
            if(e < 0){
                if (energia + e < 0){ //caso entrar com numero negativo, resultar em + com - 
                    energia = 0;
                } else {
                    energia +=e;
                }
            } else if(e > 0){
                if (energia + e > 100){
                    energia = 100;
                } else {
                    energia +=e;
                }

            }
        }
    }
    class Program
    {
        static void Main()
        {
           Jogador j1 = new Jogador("Bruno");

           j1.setEnergia(-150);

           Console.WriteLine($"Nome: {j1.getNome()}");
           Console.WriteLine($"Energia: {j1.getEnergia()}");
        }
    }
}
