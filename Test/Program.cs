using System;
using System.Xml.Linq;

internal class Program
{
    static void Main(string[] args)
    {

        /*
         * what is a variable?
         *  A variable is a 'point' of change in the program, you can change it.
         *  
         * What are 3 properties of a variable?
         *  checking things, declreratians?, i dont know 
         * 
         * Give 3 examples of a variable type and explain what kind of data they represent
         *  integer = cijfer.
         *  boolian = true of false.
         *  string = is a declaration of something.
         * 
         * In the context of programming, what is a condition?
         *  a sort of treshold that checks if you have the right requirements for running the code/a piece of code.
         */


        // gave an int named count a value of 5.
        int count = 5;
        int secondCount = 0;
        int numToAdd = 3;
        float answer;
        string choice;
        // I forgot what a formatted message is, idk if i did it right.

        //5
        void AddOne()
        {
            int f = count + 1;
            Console.WriteLine($"{count} + 1 = {f}");
            Console.WriteLine("");
        }

        AddOne();
        AddOne();
        AddOne();

        ////6
        void AddMore()
        {
            int f = numToAdd + 3;
            Console.WriteLine($"{secondCount} + {numToAdd} = {f}");
            Console.WriteLine("");
        }

        AddMore();
        AddMore();
        AddMore();

        //AddOne();
        //AddOne();
        //AddOne();
        //AddMore();
        //AddMore();
        //AddMore();

        //7
        //Console.Write("Hello customer of Delgadio's dubious delicasies!");
        //Console.WriteLine("you can choose one of the following dishes: ");
        //Console.WriteLine("1    - Durian Dolmas");
        //Console.WriteLine("2    - Duck Flavoured Daquiris");
        //Console.WriteLine("3    - Dung Betle Delight");
        //Console.WriteLine("4    - Dirt-Dusted donuts");
        //Console.WriteLine(" - (tf are these dishes???) - ");
        //Console.WriteLine("so what do you want to do?");
        ////writhing the choice 
        //choice = Console.ReadLine();
        //Console.WriteLine();

        // calling the mothod
        //SelectionMenu();

        /*
        ChoiceMenu();
        void ChoiceMenu()
        {
            if (choice == "1")
            {
                Console.WriteLine("you have chosen the Durian Dolmas. Thank you for your order");
            }
            else if (choice == "2")
            {
                Console.WriteLine("you have chosen the Duck Flavoured Daquiris. Thank you for your order");
            }
            else if (choice == "3")
            {
                Console.WriteLine("you have chosen the Dung Betle Delight. Thank you for your order");
            }
            else if (choice == "4")
            {
                Console.WriteLine("you have chosen the Dirt-Dusted donuts. Thank you for your order");
            }
            else
            {
                Console.WriteLine("That was not one of the given imputs");
                Console.WriteLine("Ending the program because your stupid ass cant type correctly");
            }
        }
        */

        //8
        //void SelectionMenu()
        //{
        //    if (choice == "1")
        //    {
        //        Console.WriteLine("you have chosen the Durian Dolmas. Thank you for your order");
        //    }
        //    else if (choice == "2")
        //    {
        //        Console.WriteLine("you have chosen the Duck Flavoured Daquiris. Thank you for your order");
        //    }
        //    else if (choice == "3")
        //    {
        //        Console.WriteLine("you have chosen the Dung Betle Delight. Thank you for your order");
        //    }
        //    else if (choice == "4")
        //    {
        //        Console.WriteLine("you have chosen the Dirt-Dusted donuts. Thank you for your order");
        //    }
        //    else
        //    {
        //        SelectionMenu();
        //    }
        //}
        

    }



}