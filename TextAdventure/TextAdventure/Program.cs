using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;

namespace TextAdventure
{
    class Program
    {
        public static string GenderDescriptor = "person";
        public static string GenderPronoun = "their";
        public static string GenderPronoun2 = "they";
        public static string GenderPronoun3 = "were";
        public static string GenderPronoun4 = "them";
        public static bool GeneratedName = false;
        public static string CharacterFeature = "";
        public static bool GodMode = false;
        public static int MusicPlay = 0;
        public static bool Tutorial = false;
        public static string FavFood = "";
        public static string Career = "";
        public static string Fondness = "";
        public static string HowGood = "";
        public static string Hobby = "";
        public static string Interest = "";
        public static string Date = "";
        public static string BirthMonth = "";
       // public static string word = "";






        static public void DoTask()
        {         

            if (MusicPlay == 1)
            {
                SoundPlayer introMusic = new SoundPlayer(@"C:\Users\Cyberadmin\Desktop\Personal-Projects\TextAdventure\TextAdventure\Piano2.wav");
                introMusic.Play();

            }

        }
        static public void DoTask2()
        {
            if (MusicPlay == 2)
            {
                SoundPlayer SpaceRaceMusic = new SoundPlayer(@"C:\Users\Cyberadmin\Desktop\Personal-Projects\TextAdventure\TextAdventure\SpaceRaceMusic.wav");
                SpaceRaceMusic.Play();

            }
            if (MusicPlay == 3)
            {
                SoundPlayer NewMusic = new SoundPlayer(@"C:\Users\Cyberadmin\Desktop\Personal-Projects\TextAdventure\TextAdventure\Piano2.wav");
                NewMusic.Play();

            }
            if (MusicPlay == 4)
            {
                SoundPlayer NewMusic2 = new SoundPlayer(@"C:\Users\Cyberadmin\Desktop\Personal-Projects\TextAdventure\TextAdventure\Piano2.wav");
                NewMusic2.Play();

            }
        }
         static void Main(string[] args)        
        {



            Thread thread = new Thread(DoTask);
            thread.Start();


            MusicPlay = 1;
            int T = 0;

            while (T < 7)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                
                Console.Clear();
                Console.WriteLine(@"
  ▓▓▓▓▓▓  ▄▓▓▓▓▄   ▓▓▀▓▓▓   ▓▓▒ ▓▓▓▄ ▄▓▓▓▒▒▓▓▓▓▓▄  ░▓▓▓▓▓   ▓▓▀▓▓▓    ▓▓▓▓▓░
░▓▓    ░ ░▓▓▀ ▀▓  ▒▓▓ ░ ▓▓░▒▓▓░▒▓▓░▀▓▀ ▓▓░░▓▓▀ ▓▓▌░▓▓░  ▓▓░▒▓▓ ░ ▓▓░▒▓▓   ░ 
  ▒▓▓▄   ░▒▓    ▄ ▒▓▓  ▄▓ ░░▓▓░▒▓▓    ▒▓▓  ▓▓   ▓▌░▓▓   ▓▓░▒▓▓  ▄▓ ░░▓▓▓▓   
  ░   ▓▓░░▒▒▄ ▄▓▓░░▓▓▀▀▓▄   ▓▓ ░▓▓    ░▓▓  ▒▓▄   ▌░▓▓   ▓▓ ░▓▓▀▀▓▄   ▒▓░    
░▓▓▓▓▓▓░░░ ▒▓▓▓▀   ▓▓▒ ░▓▓░ ▓▓ ░▓▓░    ▓▓░ ░▓▓▓▓▒   ▓▓▓▓▒░  ▓▓▒ ░▓▓░ ░▓     
░ ░▒░ ░     ░ ░     ░▒  ░▒  ▒    ░         ░░▒  ░   ░ ░ ░    ░▒  ░▒  ░      
   ░          ░      ░   ░  ░                ░  ░     ░ ░     ░   ░         
                            ░                           ░                   
                                                                            
                                                                            

");
                System.Threading.Thread.Sleep(100);
                Console.Clear();
                Console.WriteLine(@"
  ██████  ▄████▄   ██▀███   ██▓ ███▄ ▄███▓▓█████▄  ▒█████   ██▀███    █████▒
▒██    ▒ ▒██▀ ▀█  ▓██ ▒ ██▒▓██▒▓██▒▀█▀ ██▒▒██▀ ██▌▒██▒  ██▒▓██ ▒ ██▒▓██   ▒ 
░ ▓██▄   ▒▓█    ▄ ▓██ ░▄█ ▒▒██▒▓██    ▓██░░██   █▌▒██░  ██▒▓██ ░▄█ ▒▒████ ░ 
  ▒   ██▒▒▓▓▄ ▄██▒▒██▀▀█▄  ░██░▒██    ▒██ ░▓█▄   ▌▒██   ██░▒██▀▀█▄  ░▓█▒  ░ 
▒██████▒▒▒ ▓███▀ ░░██▓ ▒██▒░██░▒██▒   ░██▒░▒████▓ ░ ████▓▒░░██▓ ▒██▒░▒█░    
▒ ▒▓▒ ▒ ░░ ░▒ ▒  ░░ ▒▓ ░▒▓░░▓  ░ ▒░   ░  ░ ▒▒▓  ▒ ░ ▒░▒░▒░ ░ ▒▓ ░▒▓░ ▒ ░    
░ ░▒  ░ ░  ░  ▒     ░▒ ░ ▒░ ▒ ░░  ░      ░ ░ ▒  ▒   ░ ▒ ▒░   ░▒ ░ ▒░ ░      
░  ░  ░  ░          ░░   ░  ▒ ░░      ░    ░ ░  ░ ░ ░ ░ ▒    ░░   ░  ░ ░    
      ░  ░ ░         ░      ░         ░      ░        ░ ░     ░             
         ░                                 ░                                

");
                
                System.Threading.Thread.Sleep(100);
                T = (T + 1);
            }

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Interactive story generator");
            Console.Read();
            Console.WriteLine("What would you like your character's name to be?");
            Console.ReadLine();
            String CharacterName = Console.ReadLine();

            if (CharacterName == "")
            {
                GeneratedName = true;
                Console.WriteLine("..Do you not have a name?");
                Console.Read();
                Console.WriteLine("Well, I guess I'll have to name you then. How about.... ");
                Console.Read();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("...Scrungy?");
                Console.Read();
                Console.WriteLine("...Bungo?");
                Console.Read();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ah, god I'm terrible at this. Gimme a second, I'll just pull something from a");
                Console.WriteLine("hat or some junk--");
                Console.Read();
                Console.WriteLine("Alright, by the power invested in me, I hereby dub thee...");
                Console.Read();

                Random NameGenerator = new Random();
                int NameGen = NameGenerator.Next(1, 10);
                if (NameGen == 1)
                { CharacterName =  "Shapiffany"; }
                if (NameGen == 2)
                { CharacterName = "EggBoy"; }
                if (NameGen == 3)
                { CharacterName = "Twelve Eels In A Very Long Trenchcoat"; }
                if (NameGen == 4)
                { CharacterName = "Bilbo"; }
                if (NameGen == 5)
                { CharacterName = "Blueberry"; }
                if (NameGen == 6)
                { CharacterName = "MeatSweat"; }
                if (NameGen == 7)
                { CharacterName = "Hambone"; }
                if (NameGen == 8)
                { CharacterName = "Peebub-Bubber"; }
                if (NameGen == 9)
                { CharacterName = "Angry"; }
                if (NameGen == 10)
                { CharacterName = "Jeff"; }


                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(CharacterName + "!!!");
                Console.ReadLine();
                Console.WriteLine("Enjoy your adventure, "+ CharacterName + "!");

              

            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("Congratulations! Your name is now " + CharacterName + ". How old are you?");
           
            String CharacterAge = Console.ReadLine();
            
            int n;
            bool isNumeric = int.TryParse(CharacterAge, out n);

            if (CharacterAge == "")
            {
                Console.WriteLine("Defaulting character age to 21");
                CharacterAge = "21";
                n = 21;
            }
                if (isNumeric)
            {



                if (n < 5 && n > 0)
                {
                    Console.WriteLine("What an advanced baby you are!");

                }
                else if (n > 59 && n < 100)
                {
                    
                    Console.WriteLine("Try not to turn to dust before the end of our story, buddy.");

                }
                else if (n > 100)
                {

                    Console.WriteLine("Either you're some sort of demigod, or you're holding yourself to this plane of existence through sheer force of will and lots of vitamins. Either way I fear your power. ");

                }
                else if (n < 0)
                {
                    Console.WriteLine("Nice try, Fetus Johnson. Your tiny, underdeveloped babby hands won't get you very far.");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.Clear();

            }
                
            //Console.Clear();

            Console.WriteLine("Alright... what's a noticeable feature of yours? ");

            CharacterFeature = Console.ReadLine();



            if (CharacterName == "Twelve Eels In A Very Long Trenchcoat")
                {
                    CharacterFeature = "being made entirely out of eels";
                    Console.WriteLine("[you respond with a bunch of vague squirming motions]");
                    Console.ReadLine();
                }
                if (CharacterName == "MeatSweat")
                {
                    CharacterFeature = "having a very.... unfortunate name";
                    Console.WriteLine("[you grunt in response]");
                    Console.ReadLine();
                }
                if (CharacterName == "Peebub-Bubber")
                {
                    CharacterFeature = "the possession of an unlimited amount of power";
                    Console.WriteLine("[the console begins to eerily glow and skips this question, it seems your answer was irrelevant.]");
                    Console.ReadLine();
                    GodMode = true;
                }
                if (CharacterName == "EggBoy")
                {
                    CharacterFeature = "having an unnatural fondness for eggs";
                    Console.WriteLine("[you go to type a response, but dozens of eggs begin to fall out of your pockets]");
                    Console.ReadLine();
                }
                

           


            Console.WriteLine("I'm not quite sure how we're going to manage to incorporate " + CharacterFeature + " into this game... but bear with us; we'll try.");
            Console.ReadLine();
            Console.WriteLine("Just a few more questions, it wont be long!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("What is your gender? (Please write M or F.)");
            String GenderMarker = Console.ReadLine();
            if (GenderMarker == "M")
            {
                GenderDescriptor = "man";
                GenderPronoun = "his";
                GenderPronoun2 = "he";
                GenderPronoun3 = "was";
                GenderPronoun4 = "him";
            }
            if (GenderMarker == "F")
            {
                GenderDescriptor = "woman";
                GenderPronoun = "her";
                GenderPronoun2 = "she";
                GenderPronoun3 = "was";
                GenderPronoun4 = "her";
            }
            Console.Clear();
            Console.WriteLine("Is this your first adventure? (Y/N)");
            String Word10 = Console.ReadLine().ToLower();
            if (Word10 == "y")
            {
                Tutorial = true;
            }
            else
            {
            
            }


            Console.Clear();

            Random rnd = new Random();
            int GameChoice = rnd.Next(5, 7);
            //int GameChoice = 6;
            if (Tutorial == true)
            {
                GameChoice = 65;
            }
            while (GameChoice == 65)
            {
                    int x = 0;
                    while (x < 6)
                {

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("x");
                    System.Threading.Thread.Sleep(50);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("x");
                    System.Threading.Thread.Sleep(50);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("x");
                    System.Threading.Thread.Sleep(50);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("x");
                    System.Threading.Thread.Sleep(50);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("x");
                    System.Threading.Thread.Sleep(50);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("x");
                    System.Threading.Thread.Sleep(50);
                    Console.Clear();

                    x++;
                }


                Console.WriteLine("Welcome to the tutorial level. Here you will learn the basic controls of the game. (please press enter)");
                Console.Read();
                Console.WriteLine("there are different paths you can take by making different choices.");
                Console.WriteLine("for example, which color text would you like?");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Green? ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("or ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Blue?");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.ReadLine();
                Word10 = Console.ReadLine().ToLower();
                if (Word10 == "green")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                if (Word10 == "blue")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                if (!(Word10 == "green") && !(Word10 == "blue"))
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("you think you're real funny, dont you?");
                    
                }
                Console.Clear();
                Console.WriteLine("Things may be a little bit slow going for now; but this game is being consistently updated, so tune in for new stuff!");
                Console.WriteLine("The tutorial is done. would you like to play a scenario using your current character info? (Y/N)");
                Word10 = Console.ReadLine().ToLower();
                if (Word10 == "y")
                {
                    GameChoice = rnd.Next(5, 7);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Goodbye! :)");
                    Console.Read();
                    GameChoice = 0;
                }
                
            }
            while (GameChoice == 1)
            {
                Console.WriteLine("This is game 1");
                Console.Read();
                GameChoice = 0;
            }
            while (GameChoice == 2)
            {
                Console.WriteLine("This is game 2");
                Console.Read();
                GameChoice = 0;
            }
            while (GameChoice == 3)
            {
                Console.WriteLine("This is game 3");
                Console.Read();
                GameChoice = 0;
            }
            while (GameChoice == 4)
            {
                Console.WriteLine("This is game 4");
                Console.Read();
                GameChoice = 0;
            }
            while (GameChoice == 5)
            {
                MusicPlay = 2;
                Thread thread2 = new Thread(DoTask2);
                thread2.Start();



                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.Gray;

                
                Console.Clear();
                Console.WriteLine
 (@"       __       
      ( (`         
      _)_) ");
                System.Threading.Thread.Sleep(50);
                Console.Clear();
                Console.WriteLine
 (@"       __   ___        
      ( (` | |_)        
      _)_) |_|   ");
                System.Threading.Thread.Sleep(50);
                Console.Clear();
                Console.WriteLine
 (@"       __   ___    __       
      ( (` | |_)  / /\         
      _)_) |_|   /_/--\  ");
                System.Threading.Thread.Sleep(50);
                Console.Clear();
                Console.WriteLine
 (@"       __   ___    __    __        
      ( (` | |_)  / /\  / /`        
      _)_) |_|   /_/--\ \_\_,  ");
                System.Threading.Thread.Sleep(50);
                Console.Clear();
                Console.WriteLine
 (@"       __   ___    __    __    ____        
      ( (` | |_)  / /\  / /`  | |_        
      _)_) |_|   /_/--\ \_\_, |_|__     ");
                System.Threading.Thread.Sleep(50);
                Console.Clear();
                Console.WriteLine
 (@"       __   ___    __    __    ____      ___     
      ( (` | |_)  / /\  / /`  | |_      | |_)   
      _)_) |_|   /_/--\ \_\_, |_|__     |_| \ ");
                System.Threading.Thread.Sleep(50);
                Console.Clear();
                Console.WriteLine
 (@"       __   ___    __    __    ____      ___    __    
      ( (` | |_)  / /\  / /`  | |_      | |_)  / /\  
      _)_) |_|   /_/--\ \_\_, |_|__     |_| \ /_/--\ ");
                System.Threading.Thread.Sleep(50);
                Console.Clear();
                Console.WriteLine
 (@"       __   ___    __    __    ____      ___    __    __   
      ( (` | |_)  / /\  / /`  | |_      | |_)  / /\  / /`  
      _)_) |_|   /_/--\ \_\_, |_|__     |_| \ /_/--\ \_\_, ");
                System.Threading.Thread.Sleep(50);
                Console.Clear();
                Console.WriteLine
 (@"       __   ___    __    __    ____      ___    __    __    ____
      ( (` | |_)  / /\  / /`  | |_      | |_)  / /\  / /`  | |_ 
      _)_) |_|   /_/--\ \_\_, |_|__     |_| \ /_/--\ \_\_, |_|__");


                Console.WriteLine("Your name is " + CharacterName + ". You're " + CharacterAge + " years old, and you've been flying through space on this god-forsaken rock for as long as you can remember. ");
                Console.ReadLine();
                Console.WriteLine("You don't remember how or why you ended up here in the first place, but you can't shake the nagging feeling in the back of your mind that it's some form of punishment. ");
                Console.ReadLine();
                Console.WriteLine("......");
                Console.ReadLine();
                Console.WriteLine("is this purgatory? Some kind of half-baked attempt at an afterlife? You may never know. You decide to ponder your existential crisis at a later time, when you don't have the rumbling of your stomach to distract you.");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Damn, you're hungry.");
                Console.ReadLine();
                Console.WriteLine("...");
                Console.ReadLine();
                Console.WriteLine("C");
                Console.ReadLine();
                Console.WriteLine("D");
                Console.ReadLine();
                Console.WriteLine("E");
                
                Console.Clear();
                System.Threading.Thread.Sleep(50);
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkRed;
                System.Threading.Thread.Sleep(75);
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                System.Threading.Thread.Sleep(75);
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkRed;
                System.Threading.Thread.Sleep(75);
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                System.Threading.Thread.Sleep(75);
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkRed;
                System.Threading.Thread.Sleep(75);
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                System.Threading.Thread.Sleep(75);
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkRed;
                System.Threading.Thread.Sleep(75);
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                System.Threading.Thread.Sleep(75);
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Clear();
                Console.WriteLine("you've been spooked");

                Console.Read();
                GameChoice = 0;
            }
            while (GameChoice == 6)
            {
                MusicPlay = 2;
                Thread thread2 = new Thread(DoTask2);
                thread2.Start();

                Console.Clear();
                Console.WriteLine("What month is your birthday?");
                BirthMonth = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("What day is your birthday? (ex: 'the 13th')");
                Date = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("What is something you love? (ex: 'really terrible movies')");
                Interest = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("What do you like to do in your spare time? (ex: 'program Computers')");
                Hobby = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("How good are you at it? (ex: 'pretty good', 'not so good' or 'terrible')");
                HowGood = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Name something you love. (ex: 'paranormal lore')");
                Fondness = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("What's your dream career? (ex: 'magician')");
                Career = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("What's your favorite food? (ex: 'dumplings')");
                FavFood = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("A young " + GenderDescriptor + " stands in " + GenderPronoun + " bedroom. It just so happens that today, " + Date + " of " + BirthMonth + ", 2018, is this young " + GenderDescriptor + "'s birthday. Though it was " + CharacterAge + " years ago " + GenderPronoun2 + " " + GenderPronoun3 + " given life, it is only today " + GenderPronoun2 + " will be given a name!");
                Console.Read();
                Console.WriteLine("What will the name of this young " + GenderDescriptor + " be?");
                Console.Read();
                Console.WriteLine(">" + CharacterName);
                Console.Read();
                Console.WriteLine("Your name is " + CharacterName + ". As was previously mentioned it is your BIRTHDAY. A number of CAKES are scattered about your room. You have a variety of INTERESTS. You have a passion for " + Interest + ". You like to " + Hobby + " but you're " + HowGood + " at it. You have a fondness for " + Fondness + ", and you're an aspiring " + Career + ". You also lke to play games sometimes.");
                Console.Read();
                Console.WriteLine("yes i know its homestuck but it was something easy to copypasta shut up");
                Console.Read();
                GameChoice = 0;
            }
            while (GameChoice == 0)
            {

                Environment.Exit(0);
            }
        }
        
        }
    }

