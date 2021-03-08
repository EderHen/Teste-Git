using System;

namespace ForeachTest
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] vect = new string[] { "Maria", "Alex", "Bob" };


            for(int i = 0; i < vect.Length; i++)
            {
                Console.WriteLine(vect[i]);
            }




            Console.WriteLine("----------------------");





          


            foreach (string asd in vect)
            {
                Console.WriteLine(asd);
            }

        }
    }
}
