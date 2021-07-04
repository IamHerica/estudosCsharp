using System;
using System.Collections.Generic;
//list sera usado quando quiser substituir o array tradicional, além de ser dinamico
namespace Aula57
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
                




        }
    }
}
