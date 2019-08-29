using System;

namespace HelloWorld
{
    class Program
    {
        static void Main ( string[] args )
        {
            //Movie Data
            string title;
            int runLength;
            int releaseYear;
            string description;
            bool haveSeen;

            while (true)
            {
                char input = DisplayMenu ();
                if (input == 'A')
                    AddMovie ();
                else if (input == 'Q')
                   break;
            };
        }

        static void AddMovie()
        {
            //Get Title
            Console.Write ("Title: ");
            string title = Console.ReadLine ();
            //Get Description
            Console.Write ("Description: ");
            string description = Console.ReadLine ();
            //Get Release year
            int releaseYear = ReadInt32 ("Release Year: ");

            //Get run length
            int runLength = ReadInt32 ("Run Length (in minutes): ");
            //Get have seen
            Console.Write ("Have Seen? ");
            bool haveSeen = ReadBoolean ("Have Seen? ");
        }

        static int ReadInt32 ( string message )
        {
            while (true)
            {
                Console.Write (message);
                string input = Console.ReadLine ();

                //int result = Int32.Parse (input);
               // int result;
                //if (Int32.TryParse (input, out result))
                if (Int32.TryParse(input, out int result))
                    return result;

                Console.WriteLine ("Not a number.");
            }
        }

        static bool ReadBoolean ( string message )
        {
            while (true)
            {
                Console.Write (message);
                string input = Console.ReadLine ();

                //int result = Int32.Parse (input);
                bool result;
                if (Boolean.TryParse (input, out result))
                    return result;

                Console.WriteLine ("Not a boolean.");
            }
        }
        static char DisplayMenu ()
        {
            do
            {

            Console.WriteLine("A)dd Movie");
            Console.WriteLine("Q)uit");

            string input = Console.ReadLine ();
            if (input == "A" || input == "a")
            {
                    return 'A';
            } else if (input == "Q" || input == "q")

            {
                    return 'Q';
            } else
                Console.WriteLine("Invalid input.");
            }while(true);
        }

        private static void DemoLanguage ()
        {
            string name = "";

            string name2 = Console.ReadLine ();
            Console.WriteLine (name2);
            Console.WriteLine ("Hello World!");

            double payRate = 15.25;
            int hours = 8;

            double totalPay = payRate * hours;

            string fullName = "Fred" + " " + "Jones";
        }
    }
}
