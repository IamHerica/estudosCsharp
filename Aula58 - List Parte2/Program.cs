using System;
using System.Collections.Generic;
//list sera usado quando quiser substituir o array tradicional, além de ser dinamico
namespace Aula58
{
    class Program
    {
        static void Main(string[] args)
        {
                List<string> carros = new List<string>();
                List<string> carros2 = new List<string>();

                carros.Add("Golf");
                carros.Add("HRV");
                carros.Add("Focus");
                carros.Add("Argo");

                System.Console.WriteLine("Original:");
                foreach(string c in carros) {
                    System.Console.WriteLine("Carro: " + c);
                }
                /*
                Carro: Golf
                Carro: HRV
                Carro: Fusca
                Carro: Civic
                */

                System.Console.WriteLine("Copiando para Carros2:");
                carros2.AddRange(carros);
                
                foreach(string c in carros2) {
                    System.Console.WriteLine("Carro: " + c);
                }
                
                System.Console.WriteLine("Limpando carros2:");
                carros2.Clear();

                 foreach(string c in carros2) {
                    System.Console.WriteLine("Carro: " + c);
                }

                if(carros.Contains("Gol")) {
                    System.Console.WriteLine("Está na lista");
                } else
                {
                    System.Console.WriteLine("Não encontrado");
                }


                System.Console.WriteLine("CopyTo:");
                //copiar elementos de uma lista para outra
                string[] carros3 = new string[5];

                carros.CopyTo(carros3, 1);
                 foreach(string c in carros3) {
                    System.Console.WriteLine("Carro: " + c);
                }

                string teste = "HRV";
                int pos = 0;
                pos = carros.IndexOf(teste); //pesquisar
                System.Console.WriteLine($"Carro {teste} está em: {pos}");
                
                /*
                Original:
                Carro: Golf 
                Carro: HRV  
                Carro: Focus
                Carro: Argo
                Copiando para Carros2:
                Carro: Golf
                Carro: HRV
                Carro: Focus
                Carro: Argo
                Limpando carros2:
                Nao encontrado
                CopyTo:
                Carro:
                Carro: Golf
                Carro: HRV
                Carro: Focus
                Carro: Argo
                Carro HRV está em: 1
                */

                //inserir no elemental tal
                carros.Insert(1, "Fusca");

                 foreach(string c in carros) {
                    System.Console.WriteLine("Carro: " + c);
                }

                /*
                Carro: Golf
                Carro: Fusca
                Carro: HRV
                Carro: Focus
                Carro: Argo
                */

                carros.Add("HRV");
            System.Console.WriteLine("------------------------------");
             foreach(string c in carros) {
                    System.Console.WriteLine("Carro: " + c);
                }


                //carros.LastIndexOf("HRV"); //retorna a ultima posicao do elemento encontrado
                System.Console.WriteLine("Ultimo HRV está na posição: " + carros.LastIndexOf("HRV"));

                carros.Remove("Argo");

                 System.Console.WriteLine("Argo removido:");
                 foreach(string c in carros) {
                    System.Console.WriteLine("Carro: " + c);
                }

                carros.RemoveAt(4);
                System.Console.WriteLine("Remove elemento 4:");
                 foreach(string c in carros) {
                    System.Console.WriteLine("Carro: " + c);
                }

                carros.Reverse();
                System.Console.WriteLine("Inverter a lista");
                 foreach(string c in carros) {
                    System.Console.WriteLine("Carro: " + c);
                }

                carros.Sort();
                System.Console.WriteLine("Ordenação alfabetica");
                 foreach(string c in carros) {
                    System.Console.WriteLine("Carro: " + c);
                }

                System.Console.WriteLine("Tamanho da lista: " +  carros.Count);


                //retorna ou define a capacidade de elementos
                System.Console.WriteLine("tamanho: " + carros.Capacity);
                //era 8, agora vou definir uma nova capacidade
                int cap = carros.Capacity = 15;
                System.Console.WriteLine("Capacidade nova: " +  cap);
        }
    }
}
