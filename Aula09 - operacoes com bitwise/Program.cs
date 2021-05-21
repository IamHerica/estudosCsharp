using System;

namespace Aula09 {

    class Program {
        static void Main() {

            // bitwise ou operadores de shift servem para deslocar os bits para esquerda ou direta
            //dentro de variaveis intereiras
            // bitwise p direita << vai dobrar o valor
            // bitwise p esquerda >> valor pela metade

            int num = 10;
            Console.WriteLine(num);

            num = num<<1; //num vai receber seu valor e deslocar uma casa.
            
            Console.WriteLine("Apos utilizar o bitwise, o valor eh: ");
            Console.WriteLine(num);
            
        }
    }
}
