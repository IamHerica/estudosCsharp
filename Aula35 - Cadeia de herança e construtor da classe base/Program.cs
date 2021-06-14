using System;
/*
    Herença é quando uma classse filha(derivada) herda elementos da classe pai (classe base)
*/

namespace Aula35
{


    class Veiculo { //classe base

    public int rodas;
    public int velMax;
    private bool ligado;

    public Veiculo(int rodas){
        this.rodas = rodas;
    }

    public void ligar() {
        ligado = true;
    }

    public void desligar() {
        ligado = false;
    }

    public string getLigado(){
        /*if (ligado){
            return "sim";
        }else {
            return "não";
        }*/

        //operador ternario
        return(ligado?"Sim":"Não");
    }

    public int getRodas() {
        return rodas;
    }

    public void setRodas(int rodas){
        if (rodas < 0){
            this.rodas = 0;
        } else if (rodas > 40) {
            this.rodas = 40;
        } else {
            this.rodas = rodas;
        }
    }
    }

    //class base:derivada
    class Carro:Veiculo { //classe derivada

        public string nome;
        public string cor;
        public Carro(string nome, string cor):base(4){ //construtor aceita 1 argumento, por isso inicializamos o contrutor da base
            desligar();
            velMax = 120;
            this.nome = nome;
            this.cor = cor;
        }
    }

    class CarroCombate:Carro {
        public int municao;
        public CarroCombate():base("Carro de combate", "Verde"){
            municao = 100;
            setRodas(6);
        }
    }
    class Program
    {
        static void Main()
        {

            Carro c1 = new Carro("Rapidão", "vermelho");
            CarroCombate cc1 = new CarroCombate();

            c1.ligar();

            Console.WriteLine($"NOME: {c1.nome}");
            Console.WriteLine($"COR: {c1.cor}");
            Console.WriteLine($"RODAS: {c1.getRodas()}");
            Console.WriteLine($"VEL MAXIMA: {c1.velMax}");
            Console.WriteLine($"LIGADO: {c1.getLigado()}");

            Console.WriteLine("-------------------------");

            Console.WriteLine($"NOME: {cc1.nome}");
            Console.WriteLine($"COR: {cc1.cor}");
            Console.WriteLine($"RODAS: {cc1.getRodas()}");
            Console.WriteLine($"VEL MAXIMA: {cc1.velMax}");
            Console.WriteLine($"LIGADO: {cc1.getLigado()}");
            Console.WriteLine($"MUNIÇÃO: {cc1.municao}");
        }
    }
}
