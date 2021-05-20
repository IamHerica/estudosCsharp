using System;

namespace Aula05
{
    class Program
    {
        static void Main()
        {
            int res= 10+5;      //atribuicao e soma
            bool VouF = 10 < 5; //operadores relacionais > < >= <= !=
            int num = 10;
            num +=1;            //operador de incremento (num++;) + - * /
            bool nao = (5>3) & (10 < 5); // & = AND | = OR

            Console.WriteLine(res);
            Console.WriteLine(VouF);
            Console.WriteLine(num);
            Console.WriteLine(nao);
        }
    }
}
