using System;

namespace Aula10 {
    class Program {

        enum DiasSemana {Domingo, Segunda, Terca, Quarta, Quinta, Sexta, Sabado};

        static void Main() {
           
           DiasSemana ds = DiasSemana.Domingo; //modo tradicional
           DiasSemana dss = (DiasSemana) 3; //com indice
           int dsss = (int)DiasSemana.Sexta; //vai pegar o indice de setxa feira

           Console.WriteLine(ds);
           Console.WriteLine(dss);
           Console.WriteLine(dsss);
        }
    }
}
