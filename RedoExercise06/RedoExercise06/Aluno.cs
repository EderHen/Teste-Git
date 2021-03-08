using System;
using System.Collections.Generic;
using System.Text;

namespace RedoExercise06
{
    class Aluno
    {

        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFInal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Reprovado()
        {
            if(NotaFInal() < 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaRestante()
        {
            if (Reprovado())
            {
                return 60 - NotaFInal();
            }
            else
            {
                return 0.0;
            }
        }


    }
}
