using System;

namespace Aula52
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, res;
            n1=n2=res=0;
            n1 = 10;
             n2 = 0;
        try
        {
        res = n1/n2; 
            Console.WriteLine($"{n1}/{n2} = {res}");

        }
        catch (Exception e)
        {
        System.Console.WriteLine("Error! " + e.Message);
        }
                
            
        }
    }
}
