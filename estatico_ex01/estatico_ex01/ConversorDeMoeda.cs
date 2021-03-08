using System;
using System.Globalization;
using System.Text;

namespace estatico_ex01
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.0;

        public static double Conversor (double quantia, double cotacao)
        {
            double total = quantia * cotacao;
            return total + total * Iof / 100.00;
        }




    }
}
