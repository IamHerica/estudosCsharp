using ConsoleApp1.Enum;

namespace ConsoleApp1.Helper
{
    public class SituationImcNameHelper
    {
        public Imc Resposta { get;}
        
        public SituationImcNameHelper(double imc)
        {
            Resposta = imc switch
            {
                (<18.5) => Imc.AbaixoDoPeso,
                (<25) => Imc.PesoNormal,
                (<30) => Imc.Sobrepeso,
                (<35) => Imc.ObesidadeGrau1,
                (<40) => Imc.ObesidadeGrau2,
                _ => Imc.ObesidadeGrau3
            };
        }
    }
}