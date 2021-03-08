using System;
using System.Globalization;
using System.Text;

namespace fixacao
{
    class Aluno
    {

        public string Nome;
        public double N1;
        public double N2;
        public double N3;

        public double NotaFInal()
        {
            return N1 + N2 + N3;
        }
        public bool Aprovado()
        {
            if(NotaFInal() >= 60.00)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double Reprovado()
        {
            if (Aprovado())
            {
                return 0.0;
            } 
            else
            {
                return 60.0 - NotaFInal(); 
            }
            
        }




    }
}
