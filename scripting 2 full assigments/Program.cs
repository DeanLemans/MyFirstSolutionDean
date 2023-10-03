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
        string amoreInput;
        string amoreExpected = "that is amore";

        // variable for expected values
        string expectedPassword = "cheese";
        string expectedName = "bob";
        

        // user input variables
        string userInputName;
        string userInputPassword;
        

        //weird fucking amore fucking (not litteraly) assignment.
        Console.Write("is it true that when the moon hits your eyes that it's like a big pizza pie that's amore? ");
        amoreInput = Console.ReadLine();

        if (amoreInput == amoreExpected)
        {
            Console.WriteLine("the weird fucking assigment is finished; LETS FUCKING GOOOOO");
        }
        else
        {
            Console.WriteLine("not amore aproved");
        }




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



        string userAge;
        
        int minimumAge = 2;



        Console.Write("how old are you?");
        userAge = Console.ReadLine();

        int age  = int.Parse(userAge);


        if (minimumAge > age)
        {
            Console.WriteLine("minimum age not reached; i will now kill you");
        }
        else if (minimumAge > age) 
        {
            Console.WriteLine("minimum rached");
        }








    }
}