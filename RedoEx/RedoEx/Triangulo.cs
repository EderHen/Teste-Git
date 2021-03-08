using System;
using System.Collections.Generic;
using System.Text;

namespace RedoEx
{
    class Triangulo
    {

        public double A; // atributos
        public double B;
        public double C;


        //Metodo
        public double Area()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));

        }




    }
}
