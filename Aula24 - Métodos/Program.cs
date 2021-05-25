using System;

namespace Aula24
{
    class Program
    {
        static void Main()
        {
            int n1, n2, somado;

            hello();


            Console.Write("Digite o primeiro valor: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            somado = soma(n1, n2);
            Console.Write($"{n1} + {n2} = {somado}");
            // Console.Write($"{n1} + {n2} = {soma(n1, n2)}");
        }

        static void hello()
        { //é estatico, o retorno é void e o nome do metodo é hello
            Console.WriteLine("Hello pessoinha!");
        }

        static int soma(int n1, int n2)
        {

            int soma = n1 + n2;
            return soma;
        }
    }
}
