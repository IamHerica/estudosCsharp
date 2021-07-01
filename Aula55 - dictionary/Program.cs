using System;
using System.Collections.Generic;

namespace Aula55___dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> veiculos = new Dictionary<int, string>();

            veiculos.Add(10, "carro");
            veiculos.Add(5, "bike");
            veiculos.Add(15, "navio");
            veiculos.Add(1, "fusca");
            veiculos.Add(19, "carroça");

           // veiculos.Clear();
            Console.WriteLine("Tamanho do Dictionary: " + veiculos.Count);
            veiculos.Remove(19);
            //consultar se a chave esta na coleção
           // int chave = 15;
            string valor = "carroça";

            if(veiculos.ContainsValue(valor))  //Ou ContainsKey
            {    
                System.Console.WriteLine($"A chave {valor} está na coleção.");
            } else 
            {
            System.Console.WriteLine($"A chave {valor} não está na coleção.");
            }

            //imprimir o dictionary
            foreach (KeyValuePair<int, string> item in veiculos)
            {
                System.Console.WriteLine(item.Value); //ou item.key
            }

        }
    }
}
