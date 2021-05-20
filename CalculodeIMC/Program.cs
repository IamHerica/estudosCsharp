using System;
using ConsoleApp1.Enum;
using ConsoleApp1.Helper;
using ConsoleApp1.Models;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Pessoa("Herica", 19, 1.64, 56);
            var p2 = new Pessoa("Guilherme", 22, 1.76, 84);
            p1.CalcImc();
            p2.CalcImc();

            var situation = new SituationImcNameHelper(p1.Imc);
            var situationp2 = new SituationImcNameHelper(p2.Imc);
            
            Console.WriteLine($"O imc de {p1.Name} é de: {p1.Imc}, que se encontra na situação: {situation.Resposta}");
            Console.WriteLine($"O imc de {p2.Name} é de: {p2.Imc}, que se encontra na situação: {situationp2.Resposta}");
        }
    }
}