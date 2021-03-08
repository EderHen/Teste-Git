using System;
using System.Collections.Generic;
using System.Text;

namespace teste_point
{
    struct Point
    {
        public double X;
        public double Y;

        public override string ToString()
        {
            return "(" + X + ", " + Y + ")";
        }

    }
}
