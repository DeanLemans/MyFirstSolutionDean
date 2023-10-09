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
        int g = 0;
        int h = 0;
        int k = 0;
        int l = 0;
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


        //run
        ChoiceMenu();

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

        void TextDisplayer()
        {
            Console.WriteLine("This is an addCalculator");
            Console.WriteLine("please enter number 1:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter number 2:");
            b = int.Parse(Console.ReadLine());
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

        void DivideNumber()
        {
            int j = g / h;
            Console.WriteLine($"{g} / {h} = {j}");
            Console.WriteLine("");
        }

        void MultiplyNumber()
        {
            int m = k * l;
            Console.WriteLine($"{k} * {l} = {m}");
            Console.WriteLine("");
        }

        void ChoiceMenu()
        {
            if (input == "Adding")
            {
                Console.WriteLine("currently Adding");
                AddNumber();
            }
            else if (input == "Subtracting")
            {
                Console.WriteLine("currently Subtracting");
                SubtractNumber();
            }
            else if (input == "Dividing")
            {
                Console.WriteLine("currently Dividing");
            }
            else if (input == "Multiplying")
            {
                Console.WriteLine("currently Multiplying");
            }
            else
            {
                Console.WriteLine("That was not one of the given imput");
                Console.WriteLine("Ending the program because you bitch ass cant type correctly");
            }
        }
    }
}