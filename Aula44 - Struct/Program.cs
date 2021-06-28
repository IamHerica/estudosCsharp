using System;
//struct é um tipo que permite o armazenamento de diferente tipos de dados, e os 
//membros sao acessados diretamente(valor)
// - nao pode herdar
// - nao serve como base de heranca
// - pode usar construtor (desde que use o new)
namespace Aula44
{

    struct Carro {
        public string marca;
        public string modelo;
        public string cor;

        public Carro(string marca, string modelo, string cor) {
            this.marca = marca;
            this.cor = cor;
            this.modelo = modelo;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Carro c1; //instanciando a struct carro
            c1.marca = "VW";
            c1.modelo = "Fusca";
            c1.cor = "Azul";

            Carro c2 = new Carro("Honda", "Civic", "Preto"); //para chamar o construtor


            Console.WriteLine($"Marca:  {c1.marca}\nModelo: {c1.modelo}\nCor: {c1.cor}\n\n");
            Console.WriteLine($"Marca:  {c2.marca}\nModelo: {c2.modelo}\nCor: {c2.cor}");
        }
    }
}
