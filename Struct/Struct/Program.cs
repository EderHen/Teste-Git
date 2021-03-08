using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p;
            p.x = 10;
            p.y = 20;
            Console.WriteLine(p);

            p = new Point();
            Console.WriteLine(p);

            Class q = new Class();
            q.x = 30;
            q.y = 40;

            Console.WriteLine(q);
        }
    }
}
