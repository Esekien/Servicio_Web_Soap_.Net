using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculaArea
{
    public class Calcular
    {
        public decimal numero1 { get; set; }
        public decimal numero2 { get; set; }

        public double pi = 3.1416;
        public double circulo(decimal Radio)
        {
            return pi * Math.Pow((double)Radio, 2);
        }
 
        public decimal triangulo(decimal Base, decimal  Altura)
        {
            return (Base * Altura)/2;
        }
        public double cuadrado(decimal Lado)
        {
            return Math.Pow((double)Lado,2);
        }

    }

}