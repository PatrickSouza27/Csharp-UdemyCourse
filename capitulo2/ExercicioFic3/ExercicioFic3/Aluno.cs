using System;
using System.Globalization;

namespace ExercicioFic3
{
    internal class Aluno
    {
        public string? Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }
        public override string ToString()
        {
            return ($"NOTA FINAL = {NotaFinal().ToString("f2", CultureInfo.InvariantCulture)}");
        }



    }
}
