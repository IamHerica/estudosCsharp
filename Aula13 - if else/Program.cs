using System;

namespace Aula13
{
    class Program
    {
        static void Main()
        {
            float n1, n2, media;
            string resultado = "Aprovado";

            n1 = n2 = media =0;

            Console.WriteLine("Digite a nota 1:");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 2:");
            n2 = float.Parse(Console.ReadLine());

            media = (n1 + n2*2)/3;

            if (media < 3) {
                resultado = "DP";
            } else if (media >= 3.1 & media <=3.9 ){
                resultado = "RE";
            } else if (media >= 4 & media <= 7) {
                resultado = "BOM";
            } 
            Console.WriteLine($"Seu resultado foi {resultado},e sua nota foi {media}.");
        }
    }
}
