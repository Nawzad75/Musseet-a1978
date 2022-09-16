internal class Program
{
    // Hej
    static List<string> Rooms = new List<string>()
    {
        "ENTRANCE",
        "GIFT SHOP",
        "CAFE",             // 2
        "EXHABITIONSHALL1", // 3
        "EXHABITIONSHALL2"  // 4
    };
    static List<string> AvailableRooms = new List<string>()
    {
        "2,3,4", // From entrance (0)
        "2",     // From Gift shop
        "0,1,3", // From Cafe
        "0,2",   // From Exh1
        "0"      // From Exh2
    };

    private static void Main(string[] args)
    {
        int currntRoom = 0;

        while (true)
        {
            ShowRum(currntRoom);
            ShowThings(currntRoom);
            ShowMenu(currntRoom);
            int input = Convert.ToInt32(Console.ReadLine());

            if (input > 4)
            {
                Console.WriteLine("Okay thank you for your visit & goodbye:");
                Environment.Exit(0);
            }

            currntRoom = input;
        }



    }

    static void ShowMenu(int rum)
    {
        Console.WriteLine("to which room do you want to go? ");
        String[] available = AvailableRooms[rum].Split(",");  // "0,3,2"
        foreach (String no in available)
        {
            Console.WriteLine("{0}) {1}", no, Rooms[Convert.ToInt32(no)]);
        }
        Console.WriteLine("5) Leave museum.");
    }


    static void ShowRum(int rum)
    {
        Console.WriteLine("You are at {0}", Rooms[rum]);
    }

    static void ShowThings(int rum)
    {
        if (rum == 0)
        {
            Console.WriteLine("Here you can see Salt sculpture and Cigars.");
        }

        else if (rum == 1)
        {
            Console.WriteLine("Here you can buy Gifts.");
        }

        else if (rum == 2)
        {
            Console.WriteLine("Here you can eat.");
        }

        else if (rum == 3)
        {
            Console.WriteLine("Here you can look at Saltwater evaporate.");
        }

        else if (rum == 4)
        {
            Console.WriteLine("Here you can look at Pipes and pictures of Himalaya.");
        }


    }
}