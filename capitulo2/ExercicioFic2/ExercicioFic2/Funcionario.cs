﻿using System;
using System.Globalization;

namespace ExercicioFic2
{
    internal class Funcionario
    {
        public string? Nome;
        public double SalarioBruto;
        public double Imposto;


        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += (SalarioBruto * porcentagem) / 100;
        }

        public override string ToString()
        {
            return ($"{Nome}, ${SalarioLiquido().ToString("f2", CultureInfo.InvariantCulture)}");
        }
    }
}
