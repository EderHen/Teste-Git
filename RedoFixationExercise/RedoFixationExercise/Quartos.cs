using System;
using System.Collections.Generic;
using System.Text;

namespace RedoFixationExercise
{
    class Quartos
    {

        public string Nome, Email;
        public int Quarto;

        public Quartos(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }



    }
}
