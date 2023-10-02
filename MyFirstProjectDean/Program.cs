using System.Runtime.InteropServices;

namespace MyFirstProjectDean
{
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
            // string variable examples
            string name; //declaration
            name = "Dean"; //assigment
            string lastName = "Lemans"; //DAfusion
           
            char warning = '!'; //character variable
            int age = 16;   //intinger variable
            float pi = 3.14159265359f;  //float point variable
            //double simplisticPi = 3.141;  //double varialbe
            bool lovesDogs = true;  //boolean variable

            // user input variables
            string userInputName;
            string userInputAge;
            string userInputPassword;
            bool userInputAnswerDog = true;

            // variable for expected values
            string expectedPassword = "cheese";
            string expectedName = "bob";
            string expectedAnswerDog = "yes";

            string amoreInput;
            string amoreExpected = "that is amore";

            //simple command
            Console.WriteLine("Hello my name is " + name + lastName);
            Console.WriteLine($"I am {age} years old");
            Console.Write("Great wizzard in the sky, is it true that i love dogs? ");
            Console.WriteLine("It is {0} young seeker of knowledge.", lovesDogs);
            Console.WriteLine(); //whitespace

            //user input
            //Console.Write("Enter name or shall kill you: ");
            //userInputName = Console.ReadLine();

            //Console.WriteLine($"Name of user: {name}");


            //Console.Write("Now enter your age or i shall kill you: ");
            //userInputAge = Console.ReadLine();

            //Console.WriteLine($"Age of user: {age}");
            //if (userInputAge < 15) ;
            //    Console.WriteLine("What in the fuck are you doing here?");


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

            //weird fucking assignment
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


        }
    }
}