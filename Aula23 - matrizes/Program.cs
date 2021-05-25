using System;

namespace Aula23
{
    class Program
    {
        static void Main()
        {
           int[] vetor1 = new int[5];
           int[] vetor2 = new int[5];
           int[] vetor3 = new int[5];
           int[,] matriz = new int[2,5] {{11,22,00, 44, 55}, {66, 77, 88, 99, 00}};

           Random random = new Random(); //gerar numeros aleatorios

           for (int i = 0; i < vetor1.Length; i++) {
               vetor1[i] = random.Next(50); // valor maximo é 50, mas poderia ser (50, 100) ou sem nada Next() que retorna valor maximo
           }

            Console.WriteLine("Elementos do Vetor 1"); //imprime os valores do vetor1
            foreach(int n in vetor1) {
                Console.WriteLine(n);

            }

            //retorna a posição do elemento procurado
            //public static int BinarySearch(array, valor);
            //> -1 significa que o elemento não foi encontrado
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("BinarySearch");
            int procurado = 33;
            int posicao = Array.BinarySearch(vetor1, procurado); //onde quero procurar, e o que vai procurar
            Console.WriteLine($"Valor {procurado} está na posição {posicao}");
            Console.WriteLine("-------------------------------------------");
            
            //faz a copia dos elementos de um array para outro
            //public staric void Copy(Ar_origem, Ar_destino, qtd_elementos);
            Console.WriteLine("Copy");
            Array.Copy(vetor1, vetor2, vetor1.Length);// copiar vetor1 para vetor 2, no tamanho do vetor1
            foreach(int n in vetor2) {
                Console.WriteLine(n);
            }
            Console.WriteLine("-------------------------------------------");


            //copia a apartir do vetor de origem,
            //public void CopyTo(Ar_destino, a_partir_desta_posicao);
            Console.WriteLine("CopyTo");
            vetor1.CopyTo(vetor3,0); // elementos o vetor1 serao copiados para o vetor3, a partir da posicao 0 
            foreach(int n in vetor3) {
                Console.WriteLine(n);
            }
            Console.WriteLine("-------------------------------------------");

            //quantidade de elementos dentro do vetor
            //public long GetLongLenght(dimensão);
            Console.WriteLine("GetLongLenght");
            long qtdElementosVetor = vetor1.GetLongLength(0);
            Console.WriteLine($"Quantidade de elementos {qtdElementosVetor}");
            Console.WriteLine("-------------------------------------------");

            //menor indice do array/matriz
            // 1 dimensao = 0 (vetor), se for matriz voce deve indicar qual dimensao vc quer pegar o indice
            //public int GetLoweBound(dimensão);
            Console.WriteLine("GetLowerBound");
            int MenorIndiceVetor= vetor1.GetLowerBound(0);
            int MenorIndiceMatriz_D1 = matriz.GetLowerBound(1);
            Console.WriteLine($"Menor indice do vetor1 {MenorIndiceVetor}");
            Console.WriteLine("-------------------------------------------");


            //retorna o maior indice do vetor
            //public int GetUpperBound(dimensão);
            Console.WriteLine("GetUpperBound");
            int MaiorIndiceVetor=vetor1.GetUpperBound(0);
            int MaiorIndiceMatriz_D1= matriz.GetUpperBound(1);
            Console.WriteLine($"Maior indice do vetor1 {MaiorIndiceVetor}");
            Console.WriteLine("-------------------------------------------");

            //retorna um valor apartir do indice
            //public object GetValue(long indice)
            //object pq pode retornar uma matriz de char, string, object...
            Console.WriteLine("GetValue");
            int valor0 = Convert.ToInt32(vetor1.GetValue(3));//vai pegar o valor do indice 3 do vetor1
            int valor1= Convert.ToInt32(matriz.GetValue(1,3));//2 indices pq é uma matriz
            Console.WriteLine($"Valor da posição 3 do vetor1: {valor0}");
            Console.WriteLine("-------------------------------------------");
            

            //retorna o indice do primeiro valor que ele encontrar(caso tenha numeros repetidos)
            //public static int IndexOf(array, valor);
            Console.WriteLine("IndexOf");
            int indice1 = Array.IndexOf(vetor1, 3);
            Console.WriteLine($"Indice do primeiro valor 3: {indice1}");
            Console.WriteLine("-------------------------------------------");


            //retorna o indice do ultimo valor que ele encontrar(caso tenha numeros repetidos)
            //public static int LastIndexOf(array, valor);
            Console.WriteLine("LastIndexOf");
            int indice2= Array.LastIndexOf(vetor1, 3);
            Console.WriteLine($"Indice do ultimo valor 33: {indice2}");
            Console.WriteLine("-------------------------------------------");
            

            //inverter a ordem dos elementos 123 -> 321
            //public static void Reverse(array);
            Array.Reverse(vetor1);
            foreach(int n in vetor1){
                Console.WriteLine(n);
            } 
            
            //definir valor em uma posicao do vetor (setar)
            //public void SetValue(object valor, long posicao);
            vetor2.SetValue (99,0); //colocando o 99 na posicao 0 do vetor2
            for(int i = 0; i < vetor2.Length; i++){
                vetor2.SetValue(0,i); //colocando 0 no vetor 2
            }
            Console.WriteLine("Vetor 2");
            foreach (int n in vetor2) {
                Console.WriteLine(n);
            }
            
            //ordenar em ordem crescente o elemento. se quiser decrescente, pode usar um sort seguido de um reverse 
            //public static void Sort(array);
            Array.Sort(vetor1);
            Array.Sort(vetor2);
            Array.Sort(vetor3);
            Console.WriteLine("Vetor1");
            foreach (int n in vetor1)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("\nVetor2");
            foreach (int n in vetor2)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("\nVetor3");
            foreach (int n in vetor3)
            {
                Console.WriteLine(n);
            }
        }
    }
}
