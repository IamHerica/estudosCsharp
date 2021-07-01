using System;

namespace Aula52
{


    class Area {

        public static int Quadrado(int b, int a) //como é static não precisa do new, é só chamar
        {
            if(b == 0 || a == 0) {
                throw new Exception("Você não pode calcular com a base ou a altura com valor igual a 0!");
            }

            return b * a;
        }



    }
    class Program
    {
        static void Main(string[] args)
        {


          

            try
            {
                int area = 0; 
                area =  Area.Quadrado(10, 5);
                System.Console.WriteLine("Area = " + area);
            }
            catch (Exception e )
            {
              System.Console.WriteLine("Erro!", e.Message);
            } finally {
                System.Console.WriteLine("Fim do processo.");
            }

        
        
        /*    int n1, n2, res;
            n1=n2=res=0;
            n1 = 10;
             n2 = 2;
        try
        {
        res = n1/n2; 
            Console.WriteLine($"{n1}/{n2} = {res}");
            throw new Exception("Estou gerando uma exceção!"); //isso aqui é para eu gerar um erro, caso eu queira. mesmo se estiver tudo certo
            //sera executado. caso esteja errado o resultado da div, nao sera executado.
        }
        catch (Exception e)
        {
        System.Console.WriteLine("Error! " + e.Message);
        } finally {
            System.Console.WriteLine("Fim do processo"); //avisar que acabou o try catch, independente se deu erro ou não
        } */

        }
    }
}
