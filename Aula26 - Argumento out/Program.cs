using System;

namespace Aula26
{
    class Program
    {
        static void Main()
        {
            int dividend, divis, quoci, rest;

            dividend = 10;
            divis = 3;
            quoci = divide(dividend,divis, out rest);
            Console.Write($"{dividend} / {divis} = {quoci}\nRestou: {rest}");

        }
        static int divide(int dividendo, int divisor, out int resto) { //out vai retornar o resto

            int quociente;
            quociente = dividendo / divisor;
            resto = dividendo % divisor;
            return quociente;
        }
    }
}
