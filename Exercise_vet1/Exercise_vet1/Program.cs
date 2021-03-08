using System;

namespace Exercise_vet1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            RentedRooms[] info = new RentedRooms[9];

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("\nRent#" + (i + 1));
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                info[room] = new RentedRooms { Name = name, Email = email, Room = room };

            }

            for(int i = 0; i < 10; i++)
            {
                if(info[i] != null)
                {
                    Console.WriteLine(info[i]);
                }
            }



        }
    }
}
