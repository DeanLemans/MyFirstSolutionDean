using System;

internal class Program
{
        static void Main()
        {
            showMenu();
        }

        static void showMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("Game Rules:");
            Console.WriteLine("get friends. enter name. and eiter shoot or live");
            Console.WriteLine("");
            Console.WriteLine("Welcome to cat roulete");
            Console.WriteLine("1. start");
            Console.WriteLine("2. Quit(fucking pussy)");

            char numberInput = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (numberInput)
            {
                case '1':
                    PlayDeanGame();
                    break;
                case '2':
                    quitApplication();
                    break;
                default:
                    Console.WriteLine("THAT WASN'T A FUCKING OPTION.");
                    showMenu();
                    break;
            }
        }

        static void showRules()
        {
            Console.WriteLine("");
            Console.WriteLine("Game Rules:");
            Console.WriteLine("get friends. enter name. and eiter shoot or live");
            Console.WriteLine("press someShit to go to main menu");
            Console.WriteLine("");
            Console.ReadKey();
            showMenu();
        }

        static void PlayDeanGame()
        {
            Console.WriteLine("Enter the number of players (1-6):");
            int numPlayers;
            if (int.TryParse(Console.ReadLine(), out numPlayers) && numPlayers >= 1 && numPlayers <= 6)
            {
                //GetPlayerNames(numPlayers);
                //doRandom(numPlayers);
            }
            else
            {
                Console.WriteLine("IT'S 1 THROUGH 6. NOT WHATEVER THE FUCK YOU GAVE!");
                PlayDeanGame();
            }

            Console.WriteLine("choose wich game too play");
            Console.WriteLine("1. see the rules again bc im a dumbshit and forgot them");
            Console.WriteLine("2. Play rouleteGame (Niek)");
            Console.WriteLine("3. Play reloadGame (Luke)");

            char numberInput = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (numberInput)
        {
            case '1':
                showRules();
                break;
            case '2':
                RouleteGame();
                break;
            case '3':
                ReloadGame();
                break;
            default:
                Console.WriteLine("THAT WASN'T A FUCKING OPTION.");
                showMenu();
                break;
            }
        }

        void GetPlayerNames(int numPlayers)
        {
            for (int i = 0; i < numPlayers; i++)
            {
                Console.WriteLine($"Player {i + 1} ENTER YOUR FUCKING NAME!:");
                playerNames[i] = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine($"Player {i + 1} name is: {playerNames[i]}");
            }
        }

        static void doRandom(int numPlayers)
        {
            
        }

        static void quitApplication()
        {
            Console.WriteLine("Quitter. loser. Quitter. fucking pussy. Quitter. KYS. Quitter. Quitter. Quitter. Daddy~. Quitter. Quitter. Quitter. Quitter. Quitter. Quitter. Quitter. ");
            Environment.Exit(0);
        }

        // all of arrays catCannon 
        static string[] random = new string[6];
        static string[] playerNames = new string[6];

    

    //niek game
    static void RouleteGame()
    {
        int player = 0;
        int CNum;
        string playerInput;
        string amountOfBarrlesString;
        int amountOfBarrles;

        Console.WriteLine("hello you have joined the cat roulette game. please choose how many barrles you would like");
        amountOfBarrlesString = Console.ReadLine();
        int.TryParse(amountOfBarrlesString, out amountOfBarrles);

        bool[] cannon = new bool[amountOfBarrles];

        for (int i = 0; i < amountOfBarrles; i++)
        {
            cannon[i] = false;
        }

        Random num = new Random();
        CNum = num.Next(0, amountOfBarrles);

        cannon[CNum] = true;

        Console.WriteLine("Player 1, please give me any input: ");
        PlayerTurn();


        void PlayerTurn()
        {
            playerInput = Console.ReadLine();
            if (playerInput != null)
            {
                ShootCannon();
            }
            else
            {
                ShootCannon();
            }
        }

        void ShootCannon()
        {
            player++;
            if (cannon[player - 1] == true && player % 2 == 1)
            {
                Console.WriteLine("player 1 wins. goodjob :)");
            }
            else if (cannon[player - 1] == true && player % 2 == 0)
            {
                Console.WriteLine("player 2 wins. goodjob :)");
            }
            else if (cannon[player - 1] == false && player % 2 == 1)
            {
                Console.WriteLine("player 1 didn't win. player 2's turn; " + player + " shot('s) fired");
                PlayerTurn();
            }
            else if (cannon[player - 1] == false && player % 2 == 0)
            {
                Console.WriteLine("player 2 didn't win. player 1's turn; " + player + " shot('s) fired");
                PlayerTurn();
            }

        }
    }





    //Luke game
    static void ReloadGame() {
        int maxReserver = 30;
        int maxCompasity = 6;
        string playerInput;
        string playerFire = "f";
        string playerReload = "r";
        bool playerCanFire = false;

        Console.WriteLine("HELLO");
        Console.WriteLine("PRESS f TO FIRE OR PRESS r TO RELOAD");
        playerInput = Console.ReadLine();

        if (playerInput == playerFire)
        {
            Fire();
        }
        else if (playerInput == playerReload)
        {
            Reload();
        }
        else
        {
            Console.WriteLine("THIS IS NOT A VALID ANSWERE!!!");
            AskForOption();
        }

        void AskForOption()
        {
            Console.WriteLine("PRESS f TO FIRE OR PRESS r TO RELOAD");
            playerInput = Console.ReadLine();

            if (playerInput == playerFire)
            {
                Fire();
            }
            else if (playerInput == playerReload)
            {
                Reload();
            }
            else
            {
                Console.WriteLine("THIS IS NOT A VALID ANSWERE!!!");
                AskForOption();
            }
        }

        void Fire()
        {
            if (maxCompasity > 0)
            {
                playerCanFire = true;
                if (playerCanFire = true)
                {
                    maxCompasity--;
                    Console.WriteLine();
                    Console.WriteLine("YOU FIRED!!!");
                    playerCanFire = false;
                    Console.WriteLine("YOU HAVE " + maxCompasity + " ROUNDS LEFT");
                    Console.WriteLine("YOU HAVE " + maxReserver + " AMMO LEFT");
                    AskForOption();
                }
            }
            else if (maxCompasity == 0)
            {
                Console.WriteLine("RELOADING!!!");
                Reload();
            }
        }

        void Reload()
        {
            maxReserver += maxCompasity; // capacity
            maxCompasity = 0;
            if (maxReserver >= 6)
            {
                maxReserver -= 6;
                maxCompasity += 6;
                Console.WriteLine("YOU HAVE " + maxReserver + " AMMO LEFT");
                AskForOption();
            }
            else if (maxReserver <= 5)
            {
                maxCompasity = +maxReserver;
                maxReserver = 0;
                Console.WriteLine("YOU HAVE " + maxReserver + " AMMO LEFT IN THE CHAINBER");
            }
        }
    }


}
