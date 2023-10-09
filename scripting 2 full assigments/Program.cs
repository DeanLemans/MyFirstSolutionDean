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


        void ChoiceMenu()
        {
            if (input == "Choolate")
            {
                Console.WriteLine("Chocolate flavoured snack");
            }
            else if (input == "Hotdog")
            {
                Console.WriteLine("Hotdog flavoured snack");
                //SubtractNumber();
            }
            else if (input == "Frog")
            {
                Console.WriteLine("Frog flavoured snack");
            }
            else if (input == "Hippo")
            {
                Console.WriteLine("Hippo flavoured snack");
            }
            else
            {
                Console.WriteLine("That was not one of the given imputs");
                Console.WriteLine("Ending the program because your bitch ass cant type correctly");
            }
        }





    }
}