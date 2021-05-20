using System;

namespace Aula04 {

    class Program {

        static int num1 = 7; //se o method que chama eh static, o numero
                            // precisa ser static tambem
                           
                    
        //nao pode ter nomes iguais das variaveis locais

        static void Main(string[] args) {
            Console.WriteLine(num1);
        }
    }
}
