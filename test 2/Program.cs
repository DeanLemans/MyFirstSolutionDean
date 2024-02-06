using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        List<string> magic = new List<string> {"you should kill yourself", 
        "grab the knife", "punch the teacher", 
        "silently rebel against all that exist", "become the contrarian" };

        List<string> moreMagic = new List<string>();

        moreMagic.Add("punch someone with a headset");
        */

        /*
        List<string> userMagic = new List<string>();

        userMagic.Add("bitch");

        foreach (var n in userMagic)
        {
            Console.WriteLine(n);
        }
        
        Console.WriteLine("how much name add too list you want yes?");
        int numberMagic = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberMagic; i++) 
        {
            userMagic.Add(Console.ReadLine()); //magic[i]
        }
        */

        /*
        List<string> bobsHoes = new List<string> {"maria", "miranda", "clinton", "fokkanakka" };

        foreach (var name in bobsHoes) 
        { 
            Console.WriteLine(name); 
        }

        bobsHoes.Remove("fokkanakka");
        */

        //List<int> num = new List<int> {1, 2, 3, 4, 5, 6, 7, 1,2,3,4,5,6 };


        /*
        List<string> groceries = new List<string>();
        groceries.Add("apple");
        groceries.Add("milk");

        List<string> groceriesExtra = new List<string>();
        groceriesExtra.Add("drugs");
        groceriesExtra.Add("water");

        groceries.AddRange(groceriesExtra);

        string[] banana = new string[] { "green banana", "alchol banana", "brown banana", " "};
        groceries.AddRange (banana);

        groceries.RemoveRange(2, 4);

        foreach (string p in groceries)
        {
            Console.WriteLine(p);
        }

        Console.WriteLine($"you have: {groceries.Count} groceries");

        Console.WriteLine();
        groceries.Sort();
        */

        string choice;

        List<string> answer = new List<string> 
        {   "It is certain", 
            "It is decidedly so", 
            "Without a doubt",
            "Yes definitely",
            "You may rely on it",
            "As I see it, yes",
            "Most likely",
            "Outlook good",
            "Yes",
            "Signs point to yes",
            "Reply hazy, try again",
            "Ask again later",
            "Better not tell you now",
            "Cannot predict now",
            "Concentrate and ask again",
            "Don’t count on it",
            "My reply is no",
            "My sources say no",
            "Outlook not so good",
            "Very doubtful"
        };

        Console.WriteLine("Hello chosen one, welcome too the magic 8-ball!");
        Console.WriteLine("ask and it will answer!");
        Console.WriteLine("");

        while (true)
        {
            Console.Write("Ask your question: ");
            string userQuestion = Console.ReadLine();

            Random rand = new Random();
            int ranAnswer = rand.Next(answer.Count);

            Console.WriteLine($"Answer: {answer[ranAnswer]}");
            Console.WriteLine("");
        }

       

    }
}