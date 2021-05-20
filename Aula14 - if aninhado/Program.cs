using System;

namespace Aula14
{
    class Program
    {
        static void Main()
        {
            float n1, n2, media;
            string resultado = "nada";

            n1 = n2 = media = 0;

            Console.WriteLine("Digite a nota 1:");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 2:");
            n2 = float.Parse(Console.ReadLine());

            media = (n1 + n2 * 2) / 3;

            if (media >= 6){
                if (media >= 9) {
                    resultado = "Aprovadissimo";
                } else {
                    resultado = "Aprovado";
                }
            }else {
                if (media >= 4) {
                    resultado = "Recuperação";
                } else {
                    resultado = "Reprovado";
                }
            }
            Console.WriteLine($"Seu resultado foi {resultado},e sua nota foi {media}.");
        }
    }
}
