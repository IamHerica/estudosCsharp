using System;
using System.Collections.Generic;
//LinkedList é uma lista duplamente encadeada, onde cada elemento é um nó da lista que tem um elemento
//posterior e anterior.
namespace Aula56
{
    class Program
    {
        static void Main(string[] args)
        {
           LinkedList<string> transporte = new LinkedList<string>();

           transporte.AddFirst("Carro");
           transporte.AddFirst("Navio");
           transporte.AddFirst("Moto");
           transporte.AddFirst("Cavalo");
           /*
           Cavalo
            Moto
            Navio
            Carro   
           
           */

           transporte.AddLast("Bicicleta");

           /*
            Cavalo
            Moto
            Navio
            Carro
            Bicicleta
           */
        

        //obrigação para esse tipo se inserção:
        LinkedListNode<string>no;

        no = transporte.FindLast("Navio"); //para adicionar no ultimo navio encontrado
        transporte.AddAfter(no, "Carroça");

        /*
            Cavalo
            Moto
            Navio
            Carroça
            Carro
            Bicicleta
        */

        no = transporte.FindLast("Navio"); //para adicionar no ultimo navio encontrado
        transporte.AddAfter(no, "Patins").Next; // aponta para o proximo, e tem o value que retorna o valor do nó que esta apontando

        /*
            Cavalo
            Moto
            Navio
            Patins
            Carroça
            Carro
            Bicicleta
        */

        //transporte.Clear(); para limpar a lista

        if ( transporte.Find("Carro") == null)
        {
            System.Console.WriteLine("Não encontrado");
        } else {
            System.Console.WriteLine("Encontrado.");
        }

        transporte.Remove("Navio");

        /*
            Encontrado.
            Cavalo
            Moto
            Patins
            Carroça
            Carro
            Bicicleta
        */
       
        transporte.RemoveFirst();
        transporte.RemoveLast();

        /*
            Encontrado.
            Moto
            Patins
            Carroça
            Carro
        */






        foreach (string t in transporte) {
            System.Console.WriteLine(t);
        }
        
        }
    }
}
