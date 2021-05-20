using System;

namespace Aula15
{
    class Program
    {
        static void Main()
        {
            int tempo;

            Console.WriteLine("Viagem de Belo Horizonte/MG a Vitória/ES");
            Console.WriteLine("Escolha o transporte:\n[A]Avião\n[B]Onibus\n[C]Carro");
            var escolha = Console.ReadLine();
            
            //ToUpper é para converter a entrada para maiusculo e rodar o switch corretamente
            switch (escolha.ToUpper()) 
            { 
                case "A":
                    tempo = 50;
                    break;
                case "B":
                    tempo = 660; //minutos 
                    break;
                case "C":
                    tempo = 480; //minutos
                    break;
                default:
                    tempo = -1; //dizendo que o tempo é indefinido
                    break;
            }
            if (tempo < 0)
                Console.WriteLine("Transporte indisponível");
            else
                //Console.WriteLine($"O tempo para o transporte escolhido é: {tempo} minutos");
                Console.WriteLine("O tempo de viajem é de {0}:{1} horas.", (tempo / 60), (tempo % 60));
        }
    }
}
