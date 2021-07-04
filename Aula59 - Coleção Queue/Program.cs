using System;
using System.Collections.Generic;
//fila, FIFO

namespace Aula59
{
    class Program
    {
        static void Main(string[] args)
        {

            //poderia passar um array ja, exemplo:
            //string[] vs = {"Carro", "Moto"};
            //assim, estou inicializando minha queue com esses elementos
            Queue<string> veiculos = new Queue<string>();

            //adicionar elementos 
            veiculos.Enqueue("Carro");
            veiculos.Enqueue("Moto");
            veiculos.Enqueue("Navio");
            veiculos.Enqueue("Avião");

            System.Console.WriteLine("Tamanho da fila: " + veiculos.Count);
       
        System.Console.WriteLine("\nTem ou não tem carro?");
       if (veiculos.Contains("Carro"))
       {
           System.Console.WriteLine("Tem carro\n");
       } else {
           System.Console.WriteLine("Não tem carro\n");
       }
        //retorna o primeiro elemente e o remove da fila
        System.Console.WriteLine("Primeiro veiculo: " + veiculos.Dequeue());            
       
       System.Console.WriteLine("Tamanho da lista atualizado: " + veiculos.Count);
       
       //retorna o primeiro elemento mas NÃO REMOVE
       //agora o primeiro elemento é a moto
        System.Console.WriteLine("peek: " + veiculos.Peek());

        foreach(string v in veiculos) {
            System.Console.WriteLine("Veiculo: " + v);
        }

       
       
        }
    }
}
