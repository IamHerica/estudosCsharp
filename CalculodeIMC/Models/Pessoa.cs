namespace ConsoleApp1.Models
{
    public class Pessoa
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        public double Imc { get; set; }

        public Pessoa(string name, int age, double height, double weight)
        {
            Name = name;
            Age = age;
            Height = height;
            Weight = weight;
        }

        public void CalcImc()
        {
            Imc = Weight / (Height * Height);
        }
    }
}