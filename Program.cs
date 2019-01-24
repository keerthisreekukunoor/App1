using System;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var bPrice = 0.0;
            var ePrice = 0.0;
            var res = 'n';
            var response = false;
            var name = String.Empty;
            var rating = 0.0m;
            var type = "";
            var busi = 0;
            var eco = 0;
            var food = "";
            var id = "";
            Console.WriteLine("Welcome to ABC Airways");
            while (name == "")
            {
                Console.WriteLine("please enter your name:");
                name = Console.ReadLine();
            }
            while (id == "")
            {
                Console.WriteLine("please enter your id:");
                id = Console.ReadLine();

            }

            while (type == "")
            {
                Console.WriteLine("please enter type of the ticket:(business or economy)");
                type = Console.ReadLine();
            }


            switch (type)
            {
                case "business":
                    Console.WriteLine("price of business class ticket is 3000$");

                    break;
                case "economy":
                    Console.WriteLine("price of economy class ticket is 2000$");
                    
                    break;
                default:
                    Console.WriteLine("you entered invalid class");
                    break;


            }
            if (type == "business")
            {
                Console.WriteLine("Enter number of tickets :");
                busi = Convert.ToInt32(Console.ReadLine());
                bPrice = busi * 3000;
                Console.WriteLine($"\nTotal price of the ticket is{bPrice} ");

            }
             else if(type == "economy")
            {
                Console.WriteLine("Enter number of tickets :");
                eco = Convert.ToInt32(Console.ReadLine());
                ePrice = eco * 2000;
                Console.WriteLine($"\nTotal price of the ticket is{ePrice} ");
            }
            else
            {
                Console.WriteLine("enter correct ticket type");
            }



            Console.WriteLine("food preferences? veg/nonveg");
            food = Console.ReadLine();
            Console.WriteLine("travelling for the first time? y/n ");
            res = Convert.ToChar(Console.ReadLine());
            if (res=='y') {
                response = true;
                Console.WriteLine("enjoy our first trip");
            }
            else {
                Console.WriteLine("How will you rate your experience with us");
                rating = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("thank you");
            }
        }
    }
}
