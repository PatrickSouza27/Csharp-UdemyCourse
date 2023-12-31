﻿using System;
using System.Globalization;

namespace ExercicioFic
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return (Largura + Altura) * 2;
        }

        public double Diagonal()
        {
            return Math.Sqrt((Largura * Largura) + (Altura * Altura));
        }

        public override string ToString()
        {
            return ($"Area = {Area()}\nPerimetro = {Perimetro()}\nDiagonal = {Diagonal()}");
        }
    }
}
