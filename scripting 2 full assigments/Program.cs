internal class Program
{
    #region test
    /*cheese
    hamburger
    eggs
    cheese cheese cheese*/
    #endregion
    static void Main(string[] args)
    {

        //variables


        //string amoreInput;
        //string amoreExpected = "that is amore";
        //string expectedPassword = "cheese";
        //string expectedName = "bob";
        //string userInputName;
        //string userInputPassword;


        //weird fucking amore fucking (not litteraly) assignment.
        //Console.Write("is it true that when the moon hits your eyes that it's like a big pizza pie that's amore? ");
        //amoreInput = Console.ReadLine();

        //if (amoreInput == amoreExpected)
        //{
        //    Console.WriteLine("the weird fucking assigment is finished; LETS FUCKING GOOOOO");
        //}
        //else
        //{
        //    Console.WriteLine("not amore aproved");
        //}



        // small login system
        // name, lastname and password based

        //Console.Write("Give me your fucking name: ");
        //userInputName = Console.ReadLine();

        //Console.Write("Enter the fucking password: ");
        //userInputPassword = Console.ReadLine();

        //if (userInputName == expectedName && userInputPassword == expectedPassword)
        //{
        //    Console.WriteLine("hello user, how are you doing");
        //}
        //else
        //{
        //    Console.WriteLine("Kill yourself");
        //}



        //minimum age exersise
        //string userAge;
        //string expectedAge = "70";
        //int minimumAge = 2;

        //Console.Write("how old are you?");
        //userAge = Console.ReadLine();

        //int age  = int.Parse(userAge);
        //int eAge = int.Parse(expectedAge);

        //if (age < eAge)
        //{
        //    Console.WriteLine("minimum age not reached; i will now kill you");
        //}
        //else        {
        //    Console.WriteLine("minimum reached");
        //}



        //choice menu exersice

        string input;

        Console.WriteLine("you can choose one of the following snacks: ");
        Console.WriteLine("    - Chocolate");
        Console.WriteLine("    - Hotdog");
        Console.WriteLine("    - Frog");
        Console.WriteLine("    - Hippo");
        Console.WriteLine("so what do you want to do?");
        input = Console.ReadLine();
        Console.WriteLine();

        ChoiceMenu();

        void ChoiceMenu()
        {
            if (input == "Chocolate")
            {
                Console.WriteLine("you have chosen Chocolate flavoured snack");
            }
            else if (input == "Hotdog")
            {
                Console.WriteLine("you have chosen Hotdog flavoured snack");
                //SubtractNumber();
            }
            else if (input == "Frog")
            {
                Console.WriteLine("you have chosen Frog flavoured snack");
            }
            else if (input == "Hippo")
            {
                Console.WriteLine("you have chosen Hippo flavoured snack");
            }
            else
            {
                Console.WriteLine("That was not one of the given imputs");
                Console.WriteLine("Ending the program because your bitch ass cant type correctly");
            }
        }

        int num = 10;
        int anotherNum = 0;

        void AddsFive() 
        {
            num =+ 5;
            Console.WriteLine("+ five");
        }

        void AddsOneMoreEveryTime() 
        {
        
        }


    }
}