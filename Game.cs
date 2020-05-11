using System;
using System.Collections.Generic;
using System.Text;

using static System.Console;

namespace EthanFinalProject
{
    class Game
    {
        private long startTime;
        private string[] seaSideTexts;
        private string[] forestTexts;
        private string[] swampTexts;

        private Player player;

        public Game()
        {
            GameTitle();
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("Enter your name: Dr. ");
            ResetColor();
            string playerName = ReadLine();
            player = new Player(playerName);
            WriteLine("You are Dr. " + playerName + ", a mad scientist who has secretly invented the very first time travel portal in your basement.");
            WriteLine("To read more about this game's story, go to 'About' on the Main Menu.");
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("Press any key to continue to the Main Menu.");
            ResetColor();
            ReadKey();
            Clear();
            Run();   
        }


        private void Run()
        {
            
            GameTitle();
            ForegroundColor = ConsoleColor.Magenta;
            string prompt = (@" /$$$$$$$  /$$$$$$$$ /$$   /$$        /$$$$$$  /$$   /$$ /$$$$$$$$  /$$$$$$  /$$$$$$$$
| $$__  $$| $$_____/| $$  / $$       /$$__  $$| $$  | $$| $$_____/ /$$__  $$|__  $$__/
| $$  \ $$| $$      |  $$/ $$/      | $$  \ $$| $$  | $$| $$      | $$  \__/   | $$   
| $$$$$$$/| $$$$$    \  $$$$/       | $$  | $$| $$  | $$| $$$$$   |  $$$$$$    | $$   
| $$__  $$| $$__/     >$$  $$       | $$  | $$| $$  | $$| $$__/    \____  $$   | $$   
| $$  \ $$| $$       /$$/\  $$      | $$/$$ $$| $$  | $$| $$       /$$  \ $$   | $$   
| $$  | $$| $$$$$$$$| $$  \ $$      |  $$$$$$/|  $$$$$$/| $$$$$$$$|  $$$$$$/   | $$   
|__/  |__/|________/|__/  |__/       \____ $$$ \______/ |________/ \______/    |__/ ");
            ResetColor();
            string[] options = { "Play", "About", "Exit" };
            Menu mainMenu = new Menu(prompt,options);
            int selectedIndex = mainMenu.Run();
            switch (selectedIndex)
            {
                case 0:
                    PlayChoice();
                    break;
                case 1:
                    DisplayAboutInfo();
                    break;
                case 2:
                    ExitGame();
                    break;
            }
            ReadKey();
            ForegroundColor = ConsoleColor.Yellow;
            ResetColor();

            WriteLine("");

            WriteLine("Ultimately, your goal is to find T. rex eggs so that you can take them to the present and raise them to follow your orders.");
            WriteLine("With your cloning machine, you believe you can clone an endless amount of specimens to create the ultimate army, leading to world domination.");
            WriteLine("");
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("Press anything to enter the portal.");
            ResetColor();



            ReadKey(true);
            Clear();


        }

        private void GameTitle()
        {
            //http://patorjk.com/software/taag/#p=display&f=Big%20Money-ne&t=Pangaea%20Quest
            ForegroundColor = ConsoleColor.Magenta;
            
            WriteLine(@" /$$$$$$$  /$$$$$$$$ /$$   /$$        /$$$$$$  /$$   /$$ /$$$$$$$$  /$$$$$$  /$$$$$$$$
| $$__  $$| $$_____/| $$  / $$       /$$__  $$| $$  | $$| $$_____/ /$$__  $$|__  $$__/
| $$  \ $$| $$      |  $$/ $$/      | $$  \ $$| $$  | $$| $$      | $$  \__/   | $$   
| $$$$$$$/| $$$$$    \  $$$$/       | $$  | $$| $$  | $$| $$$$$   |  $$$$$$    | $$   
| $$__  $$| $$__/     >$$  $$       | $$  | $$| $$  | $$| $$__/    \____  $$   | $$   
| $$  \ $$| $$       /$$/\  $$      | $$/$$ $$| $$  | $$| $$       /$$  \ $$   | $$   
| $$  | $$| $$$$$$$$| $$  \ $$      |  $$$$$$/|  $$$$$$/| $$$$$$$$|  $$$$$$/   | $$   
|__/  |__/|________/|__/  |__/       \____ $$$ \______/ |________/ \______/    |__/");
            ResetColor();
        }

        private void DisplayAboutInfo()
        {
            Clear();
            ForegroundColor = ConsoleColor.Magenta;
            WriteLine(@"           _                 _   
     /\   | |               | |  
    /  \  | |__   ___  _   _| |_ 
   / /\ \ | '_ \ / _ \| | | | __|
  / ____ \| |_) | (_) | |_| | |_ 
 /_/    \_\_.__/ \___/ \__,_|\__|
                                ");
            ResetColor();
            WriteLine("You play as a mad scientist who wants to back in time to the Cretaceous period.");
            WriteLine("This way, you can confirm what caused the Cretaceous-Paleogene extinction event.");
            WriteLine("Unfortunately, you know your time travel portal will likely not last after one or two uses due to it being low-budget and created by scraps you found.");
            WriteLine("\nWhat is your ultimate goal of going back in time, though?");
            WriteLine("\nYou seek to find T. rex eggs and take them to the present. This way you can raise them from birth to obey your orders.");
            WriteLine("After taming them, you can use your cloning device to infinitely clone an endless T. rex army and use them to take over the world.");
            ReadKey(true);
            Run();
        }

        private void PlayChoice()
        {
            
            ForegroundColor = ConsoleColor.Yellow;
            string prompt = (@"                 _.--._
                 _|__|_
     _____________|__|_____________
  .-'______________________________'-.
  | |_____TIME_TRAVEL_DEVICE______|  |
  |  |============================|  |
  |  | .-----------..-----------. |  |
  |  | |  _  _  _  ||  _  _  _  | |  |
  |  | | | || || | || | || || | | |  |
  |  | | |_||_||_| || |_||_||_| | |  |
  |  | | | || || | || | || || | | |  |
  |  | | |_||_||_| || |_||_||_| | |  |
  |  | |  _______  ||  _______  | |  |
  |  | | |       | || |       | | |  |
  |  | | |       | || |       | | |  |
  |  | | |       | || |       | | |  |
  |  | | |_______| || |_______| | |  |
  |  | |  _______ @||@ _______  | |  |
  |  | | |       | || |       | | |  |
  |  | | |       | || |       | | |  |
  |  | | |       | || |       | | |  |
  |  | | |_______| || |_______| | |  |
  |  | |  _______  ||  _______  | |  |
  |  | | |       | || |       | | |  |
  |  | | |       | || |       | | |  |
  |  | | |       | || |       | | |  |
  |  | | |_______| || |_______| | |  |
  |  | '-----------''-----------' |  |
 _|__|/__________________________\|__|_ 
'----'----------------------------'----'

Would you like to enter the portal to travel back in time?");
            ResetColor();
            string[] options = { "Enter Portal", "Don't Enter (Go back to Title Screen)" };
            Menu playMenu = new Menu(prompt, options);
            int selectedIndex = playMenu.Run();
            switch (selectedIndex)
            {
                case 0:
                    EnterChoice();

                    break;
                case 1:
                    WriteLine("You have chosen not to go into the portal... are you a coward or something?");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("Press any key to go back to the Title Screen.");
                    ResetColor();
                    ReadKey();
                    Clear();
                    Run();
                    break;
            }


        }

        private void EnterChoice()
        {
            WriteLine("You chose to enter the portal!");
            WriteLine("You press a button and your portal starts violently shaking for a little over a minute.");
            WriteLine("In just a minutes worth of time, you've traveled back in time 66 million years ago!");
            WriteLine("\nIt seems your calculations on exactly when the asteroid hit were exceedingly accurate:");
            WriteLine("You stare up at the sky and immediately notice an asteroid approaching you!");
            WriteLine("You need to find those T. rex eggs fast!");
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("Press any key to continue...");
            ReadKey();
            ResetColor();
            Clear();
            WriteLine(@"                      .:'
                  _.::'
        .-;;-.   (_.'
       / ;;;' \
      |.  `:   | 
       \:   `;/
        '-..-'");
            ForegroundColor = ConsoleColor.Red;
            WriteLine("You have 3 minutes until the asteroid crashes into the Earth!");
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("Press any key to choose a path...");
            ResetColor();
            ReadKey();
            PathChoice();
        }

        private void PathChoice()
        {
            Clear();
            startTime = DateTime.Now.Ticks / TimeSpan.TicksPerSecond;
            ForegroundColor = ConsoleColor.Red;
            ResetColor();
            string prompt = "What path would you like to take?";
            string[] options = { "Location A (Seaside)", "Location B (Forest)", "Location C (Swamp)", };
            Menu pathMenu = new Menu(prompt, options);
            int selectedIndex = pathMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    WriteLine("You chose the seaside path!");
                    break;
                case 1:
                    WriteLine("You chose the forest path!");
                    break;
                case 2:
                    WriteLine("You chose the swamp path!");
                    break;
            }
        }

        private void AlienPath()
        {
            //Path where player follows alien and finds the mothership.
        }
        
        private void BeachPath()
        {
            //Encounter Plieosaur --> Game Over (will warn player prior to taking this path).
        }

        private void Volcano()
        {
            //Volcano erupts --> Game Over (will warn player, also hints what path to take)
        }

        private void Creatures()
        {
            Creature Deinosuchus = new Creature("Deinosuchus", "Crocodile", 39, ConsoleColor.Green);
            Creature Alien = new Creature("Mysterious Alien", "Alien(?)", 2, ConsoleColor.Magenta);
            Creature Plesiosaur = new Creature("Plesiosaur", "Marine Reptile", 30, ConsoleColor.Blue);
            Creature Triceratops = new Creature("Triceratops", "Herbivorous Dinosaur", 26, ConsoleColor.DarkGreen);
            Creature Branchiosaurus = new Creature("Branchiosaurus", "Herbivorous Dinosaur", 98, ConsoleColor.DarkBlue);
        }

        private void RiverBank()
        {
            //Dead end path, exists to waste players time while the asteroid approaches earth.
            //will tell player that the path is full of dinosaurs but none seem particularly harmful.
        }

        private void ForestedPath()
        {
            //Path with mama T.rex, if the player has stick they can throw it to obtain eggs
            //Leads to Ending 2 if player has stick, game over if not.
        }

        private void LakePath()
        {
            //Game over route, will warn player beforehand.
        }

        private bool CheckTimer()
        {
            long currentTime = DateTime.Now.Ticks / TimeSpan.TicksPerSecond;
            long secondsIn3Minutes = 3 * 60;
            return currentTime - startTime >= secondsIn3Minutes;
        }

        private void AsteroidDestroyed()
        {
            //Called when the player destroys the asteroid from the AlienPath.
        }

        public void DisplayItems()
        {
            //Will display the items that the player currently has, items will be added when 
            //they are added to the player's list.
        }

        public void TravelUses()
        {
            //Displays the number of times the player has used their time travel portal
            //to go back if they've chosen the wrong path. Not sure how/if I'll be able
            //to implement this yet especially with the timer. 
        }



        private void ExitGame()
        {
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("\nPress any key to exit.");
            Environment.Exit(0);
        }



    }
}
