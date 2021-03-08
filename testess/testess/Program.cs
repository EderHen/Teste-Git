using System;

namespace testess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SHow the highest");
            double x = 2134.2;
            double y = 2134.3;
            double z = 3246.5;
            double w = 3246.6;

            Console.WriteLine(Math.MaxMagnitude(x, y));
            Console.WriteLine(Math.MinMagnitude(z, w));

            string myString = "Hello";
            Console.WriteLine(myString[1]);

            string txt = "Hello";
            Console.WriteLine(txt.Length);

            /*Use the correct method to output the value of the txt string to upper case letters.

            string txt = "Hello World";
            Console.WriteLine(txt.ToUpper());
            */

            //Insert the missing parts to complete the following "short hand if...else statement"(ternary operator):

            int time = 20;
            string result = (time < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);

            //Insert the missing parts to complete the following SWITCH statement.

            int day = 2;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
            }

            //Complete the switch statement, and add the correct keyword at the end to specify some code to run if there is no case match in the switch statement.

            day = 3;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Today is Saturday");
                    break;
                case 2:
                    Console.WriteLine("Today is Sunday");
                    break;
                default:
                    Console.WriteLine("Looking forward to the Weekend");
                    break;
            }

            //Use the do/while loop to print i as long as i is less than 6.

            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 6);

            //Stop the loop if i is 5.

            for (int j = 0; j < 10; j++)
            {
                if (j == 5)
                {
                    break;
                }
                Console.WriteLine(j);
            }

            //In the following loop, when the value is "4", jump directly to the next value.

            for (int k = 0; k < 10; k++)
            {
                if (k == 4)
                {
                    continue;
                }
                Console.WriteLine(k);
            }

            //Loop through the elements in the cars array using the foreach loop.

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            //Use the correct method to sort the cars array.

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Array.Sort(cars);
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            // Go back to methods exercises.
        }
    }
}
