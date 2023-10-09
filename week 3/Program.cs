internal class Program
{
    static void Main(string[] args)
    {
        // container for code

        // variables
        int a = 0;
        int b = 0;
        int d = 0;
        int e = 0;
        string input;

        //cool menu
        Console.WriteLine("you can choose one of the following: ");
        Console.WriteLine("    - Adding");
        Console.WriteLine("    - Subtracting");
        Console.WriteLine("    - Dividing");
        Console.WriteLine("    - Multiplying");
        Console.WriteLine("so what do you want to do?");
        input = Console.ReadLine();
        Console.WriteLine();


        if (input == "Adding") 
        {
            Console.WriteLine("currently Adding");
        }
        else if (input == "Subtracting") 
        {
            Console.WriteLine("currently Subtracting");
        }
        else if (input == "Dividing")
        {
            Console.WriteLine("currently Dividing");
        }
        else if (input == "Multiplying")
        {
            Console.WriteLine("currently Multiplying");
        }

        //run
        AddTextDisplayer();
        AddNumber();
        SubtractTextDisplayer();
        SubtractNumber();

        //methods
        void Crazy() 
        {
            Console.WriteLine("crazy?");
            Console.WriteLine("I Was Crazy Once.");
            Console.WriteLine("They Locked Me In A Room.");
            Console.WriteLine("A Rubber Room.");
            Console.WriteLine("A Rubber Room With Rats.");
            Console.WriteLine("And Rats Make Me Crazy.");
            Console.WriteLine("");
        }

        void AddTextDisplayer()
        {
            Console.WriteLine("This is an addCalculator");
            Console.WriteLine("please enter number 1:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter number 2:");
            b = int.Parse(Console.ReadLine());
        }

        void SubtractTextDisplayer() 
        {
            Console.WriteLine("This is an subtractCalculator");
            Console.WriteLine("please enter number 3:");
            d = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter number 3:");
            e = int.Parse(Console.ReadLine());
        }

        void AddNumber() 
        {
            int c = a + b;
            Console.WriteLine($"{a} + {b} = {c}");
            Console.WriteLine("");
        }

        void SubtractNumber()
        {
            int f = d - e;
            Console.WriteLine($"{d} - {e} = {f}");
            Console.WriteLine("");
        }
    }
}