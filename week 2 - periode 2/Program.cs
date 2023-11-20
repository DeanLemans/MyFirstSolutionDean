using System;
using System.Xml.Linq;

internal class Program
{
    static void Main(string[] args)
    {


        Console.WriteLine("please enter input: ");

        string no = Console.ReadLine();
        int yes;


        if (int.TryParse(no, out yes))
        {
            Console.WriteLine($"i like this: ");
            Console.WriteLine($"{yes}");
        }
        else
        {
            Console.WriteLine($"fuck you {yes}, all my homies like integers");
        }


    }
}