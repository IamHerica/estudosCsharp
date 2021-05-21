using System;

namespace Aula12 {
    class Program {
        static void Main() {
            // > < >= <= == !=

            int nota = 0;
            string resultado = "Reprovado";
            int n1, n2;
            // n1=n2=0; //zerar todas as variaveis de uma forma rapida

            Console.WriteLine("Digite a nota do aluno:");
            nota = int.Parse (Console.ReadLine());

            if (nota >= 60){
                resultado = "Aprovado";
            }
        
        Console.WriteLine(resultado);
        }       
    }
}
