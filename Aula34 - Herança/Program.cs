using System;
/*
    Herença é quando uma classse filha(derivada) herda elementos da classe pai (classe base)
*/

namespace Aula34
{


    class Veiculo { //classe base

    public int rodas;
    public int velMax;
    private bool ligado;

    public void ligar() {
        ligado = true;
    }

    public void desligar() {
        ligado = false;
    }

    public string getLigado(){
        if (ligado){
            return "sim";
        }else {
            return "não";
        }
    }
    }

    //class base:derivada
    class Carro:Veiculo {

        public string nome;
        public string cor;
        public Carro(string nome, string cor){
            desligar();
            rodas = 4;
            velMax = 120;

            this.nome = nome;
            this.cor = cor;
        }
    }
    class Program
    {
        static void Main()
        {

            Carro c1 = new Carro("Rapidão", "vermelho");

            Console.WriteLine($"NOME: {c1.nome}");
            Console.WriteLine($"COR: {c1.cor}");
            Console.WriteLine($"RODAS: {c1.rodas}");
            Console.WriteLine($"VEL MAXIMA: {c1.velMax}");
            Console.WriteLine($"LIGADO: {c1.getLigado()}");
        }
    }
}
