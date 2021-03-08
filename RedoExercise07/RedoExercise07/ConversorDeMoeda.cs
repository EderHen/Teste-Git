using System;
using System.Globalization;
using System.Text;

namespace RedoExercise07
{
    class ConversorDeMoeda
    {

        public static double CotacaoDolar;
        public static double CompraDolares;
        public static double IOF = 0.06;

        public static double ValorAPagar()
        {
            return (CotacaoDolar * CompraDolares * IOF) + CotacaoDolar * CompraDolares;
        }





    }
}
