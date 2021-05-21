using System;

namespace Aula08 {

    class Program {

        static void Main() {
            
            int v1, v2, soma;
            string nome;

            Console.WriteLine("Digite seu nome:");
            nome = Console.ReadLine(); //ler o que esta sendo digitado
            Console.WriteLine("Nome digitado: {0}", nome);
            
            Console.WriteLine("Digite o valor 1: ");

            //eh necessario converter a entrada de texto para o mesmo tipo, 
            //pois entra automaticamente em string. Para isso, fazemos o CASTING
            v1 = int.Parse (Console.ReadLine());


            Console.WriteLine("Digite o valor 2: ");
            v2 = Convert.ToInt32 (Console.ReadLine()); //casting

            soma = v1 + v2;

            Console.WriteLine("{0}, o valor da sua soma eh: {1}", nome, soma);
        }
    }
}
