using System;

namespace Aula52 // para controlar o scopo, agrupar classes
{
    class Area {
        public static int Quadrado(int b, int a)
        {
            if(b == 0 || a == 0) {
                throw new Exception("Você não pode calcular com a base ou a altura com valor igual a 0!");
            }
            return b * a;
        }
    }  
}

namespace principal {
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

        }
    }
}