using System.Reflection;

internal class Program
{
    static void Main(string[] args)
    {
        /*
        int[] cheeceArray;

        string[] thingArray = {"apple", "pear", "window", "mouse"};

        cheeceArray = new int[3];
        cheeceArray[0] = 10;

        thingArray[0] = "apple";
        thingArray[1] = "pear";

        Console.WriteLine($"The first number in the numberArray is {cheeceArray[0]} and the first thing in the thing array is {thingArray[0]}");
        */


        /*
        string[] randomArray = { "apple", "pear", "window", "mouse", "keyboard", "discord" };

        for (int i = 0; i < randomArray.Length; i++)
        {
            Console.WriteLine($" the {i + 1} random thing is {randomArray[i]}");
        }
        */


        /*
        Console.WriteLine("May the first player enter their name:");
        playerNames[0] = Console.ReadLine();
        Console.WriteLine($"The name of the first player is: {playerNames[0]}");
        Console.WriteLine();

        Console.WriteLine("May the second player enter their name");
        playerNames[1] = Console.ReadLine();
        Console.WriteLine($"The name of the second player is: {playerNames[1]}");
        Console.WriteLine();

        Console.WriteLine("May the third player enter their name");
        playerNames[2] = Console.ReadLine();
        Console.WriteLine($"The name of the third player is: {playerNames[2]}");
        Console.WriteLine();

        Console.WriteLine("May the fourth player enter their name");
        playerNames[3] = Console.ReadLine();
        Console.WriteLine($"The name of the fourth player is: {playerNames[3]}");
        Console.WriteLine();
        */


        /*
        string[] playerNames = new string[4];

        for (int i = 0; i < playerNames.Length; i++)
        {
            Console.WriteLine($"May player {i+1} enter their name:");
            playerNames[0] = Console.ReadLine();
            Console.WriteLine($"The name of player {i+1} is: {playerNames[i]}"); 
            Console.WriteLine();
        }
        */



        Random RNG = new Random();

        string[] dieRoll = new string[4];
        string[] playerNames = new string[4];

        for (int i = 0; i < playerNames.Length; i++)
        {
            Console.WriteLine($"May Player {i + 1} enter their name:");
            playerNames[i] = Console.ReadLine();
            Console.WriteLine();

            dieRoll[i] = RNG.Next(1, 7).ToString();

            Console.WriteLine($"List of playerNames:");
            Console.WriteLine($"The name of Player 1 is: {playerNames[0]} and rolled {dieRoll[0]}");
            Console.WriteLine($"The name of Player 2 is: {playerNames[1]} and rolled {dieRoll[1]}");
            Console.WriteLine($"The name of Player 3 is: {playerNames[2]} and rolled {dieRoll[2]}");
            Console.WriteLine($"The name of Player 4 is: {playerNames[3]} and rolled {dieRoll[3]}");
            Console.WriteLine();
        }

        //// Sort the rolls in ascending order
        //Array.Sort(dieRoll);

        //// Declare the winner based on the first index of the sorted array
        //string winner = playerNames[dieRoll[0]];

        //Console.WriteLine($"The winner is: {winner} with a roll of {dieRoll[0]}");


    }
}