using System;
namespace ExercicioFicLista
{
    internal class Funcionario
    {
        public int Id { get;  set; }
        public string? Name { get; set; }

        public double Salario { get; set; }

        public Funcionario(int id, string? name, double salario)
        {
            Id = id;
            Name = name;
            Salario = salario;
        }
        public void Porcentagem(double porcentagem)
        {
            Salario += Salario * porcentagem / 100;
        }

        public override string ToString()
        {
            return ($"{Id},  {Name},  {Salario}");
        }
    }
}
