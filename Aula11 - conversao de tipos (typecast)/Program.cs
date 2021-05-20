using System;

namespace Aula11 {
    class Program {
        static void Main() {
        
            int n1 = 10;
            float n2 = n1;
            float n3 = 10.5f;
            int n4 = (int)n3; //typecast

            int n5 = 10;
            short n6 = (short)n5; //typecast

            //precisa fazer a conversao de float para int


            Console.WriteLine(n2);//fez a conversao de int para float (implicita)
            Console.WriteLine(n4);

        }
    }
}
