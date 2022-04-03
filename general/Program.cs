using general.Exceptions.Models;
using System;

namespace general
{
    internal class Program
    {
        private static bool check;

        static void Main(string[] args)
        {
            User username = new User();


            bool check = true;
            do
            {
                Console.WriteLine("***** Menu  *****");
                Console.WriteLine("1. Share status");
                Console.WriteLine("2. Get all statuses");
                Console.WriteLine("3. Get status by id");
                Console.WriteLine("4. Filter status by date ");
                Console.WriteLine("0. Quit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Status Title:");
                        string content = Console.ReadLine();
                        Console.WriteLine("Content:");
                        string title = Console.ReadLine();
                        Console.WriteLine($"DateTime:{DateTime.Now.ToShortDateString()}");

                        break;

                        case "2":
                        foreach (var item in username.GetAllStatuses())
                        {
                            item.GetStatusInfo();
                        }
                        break;

                    case "3":
                        int userId=int.Parse(Console.ReadLine());
                        try
                        {
                            username.GetStatusById(userId).GetStatusInfo();
                        }
                        catch (NullReferenceException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    //case "4":

                    //    break;
                    
                    case "0":
                        check = false;
                        Console.WriteLine("bele bir emeliyyat yoxdur...");
                        break;
                }

            }
            while (check);



        }
    }
}


    
