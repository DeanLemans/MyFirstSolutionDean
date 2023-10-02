using System.Runtime.InteropServices;

namespace Scripting_2___week_1
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
         

            //simple command test n shit
            Console.WriteLine("Hello my name is " + name + lastName);
            Console.WriteLine($"I am {age} years old");
            Console.Write("Great wizzard in the sky, is it true that i love dogs? ");
            Console.WriteLine("It is {0} young seeker of knowledge.", lovesDogs);
            Console.WriteLine(); //whitespace

        }
    }
}