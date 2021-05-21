using System;

namespace Aula06 {

    class Program {

        static void Main() {

            int n1, n2, n3;
            n1 = 10;
            n2 = 20;
            n3 = 30;
            double valorCompra = 5.50;
            double valorVenda;
            double lucro= 0.1;
            string produto = "pastel";

            valorVenda = valorCompra + (valorCompra*lucro);

            Console.WriteLine("Produto.....:{0,15}", produto); //0 eh o indice e 15 eh o espacamento
            Console.WriteLine("Val.Compra..:{0,15:c}", valorCompra); // :c indica que o formato de saida sera monetario (R$,00)
            Console.WriteLine("Lucro.......:{0,15:p}", lucro); // :p para mostrar a saida em porcentagem
            Console.WriteLine("Val.Venda...:{0,15:c}", valorVenda); 

            Console.WriteLine(n1 + ", " + n2 + ", " + n3); // forma tradicional
            Console.WriteLine("\nn1 = {0}\nn2 = {1}\nn3 = {2}\n\n", n1, n2, n3); // com indice
            Console.WriteLine("n1 = {0}\tn2 = {1}\tn3 = {2}\n\n", n1, n2, n3); // com indice
            Console.WriteLine("n1 = \t{0}\nn2 = \t{1}\nn3 = \t{2}", n1, n2, n3); // com indice
        }
    }
}
