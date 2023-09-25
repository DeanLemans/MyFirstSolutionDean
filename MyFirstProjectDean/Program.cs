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
            // string variable!
            string name; //declaration
            name = "Dean"; //assigment
            string lastName = "Lemans"; //DAfusion
           
            char warning = '!'; //character variable
            int age = 16;   //intinger variable
            float pi = 3.14159265359f;  //float point variable
            //double simplisticPi = 3.141;  //double varialbe
            bool lovesDogs = true;  //boolean variable
            string userInputName;
            string userInputAge;

            //variable console write test
            //Console.Write(name);
            //Console.WriteLine(lastName);
            //Console.WriteLine(age); 
            //Console.WriteLine(pi);
            //Console.WriteLine(warning);
            //Console.WriteLine(lovesDogs);

            //simple command
            Console.WriteLine("Hello my name is " + name + lastName);
            Console.WriteLine($"I am {age} years old");
            Console.Write("Great wizzard in the sky, is it true that i love dogs? ");
            Console.WriteLine("It is {0} young seeker of knowledge.", lovesDogs);
            Console.WriteLine(); //whitespace

            //user input
            Console.Write("Enter name or shall kill you: ");
            userInputName = Console.ReadLine();

            Console.WriteLine($"Name of user: {name}");


            Console.Write("Now enter your age or i shall kill you: ");
            userInputAge = Console.ReadLine();

            Console.WriteLine($"Age of user: {age}");
                
        }
    }
}