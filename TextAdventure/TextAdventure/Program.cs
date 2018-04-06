using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class Program
    {
        public static string GenderDescriptor = "person";
        public static string GenderPronoun = "their";
        public static string GenderPronoun2 = "they";
        public static string GenderPronoun3 = "were";

        static void Main(string[] args)
        { 
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
            Console.Beep(233, 100);
            Console.Beep(311, 120);
            Console.Beep(261, 100);
            Console.Beep(38, 100);
            Console.Beep(369, 100);
            Console.Beep(415, 120);
            Console.Beep(369, 100);
            Console.Beep(38, 100);
            Console.Beep(493, 100);
            Console.Beep(587, 120);
            Console.Beep(659, 80);
            Console.Beep(739, 100);
            Console.Beep(987, 400);


            Console.WriteLine("Interactive story generator");
            Console.Read();
           // Console.WriteLine("Etiam mauris tortor, lacinia at sapien et, bibendum fermentum felis. Vivamus pharetra eros at leo molestie iaculis. In aliquam semper nulla nec posuere. Nam bibendum pharetra sagittis. Vivamus congue purus id gravida fermentum. Sed faucibus, lectus vel pulvinar rhoncus, erat odio pellentesque sem, ut imperdiet mi mi sed odio. Donec cursus, ex eget porttitor imperdiet, eros ex ultricies lectus, vel congue purus leo eget mi. Duis justo neque, faucibus a commodo quis, condimentum interdum sem. Vestibulum malesuada justo quis tempor imperdiet. Donec sem nisl, gravida eget tincidunt in, sodales at orci. Vestibulum ornare tempus lacus, eu varius arcu rutrum a. Suspendisse vulputate eget lacus et varius. Proin consequat, neque vel volutpat tincidunt, arcu mauris tempor arcu, eu sodales ante nisl vitae libero. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce leo lacus, congue eget justo blandit, pretium ultricies ex.");
           // Console.Read();
            Console.WriteLine("What would you like your character's name to be?");
            Console.ReadLine();
            String CharacterName = Console.ReadLine();

            Console.WriteLine("Congratulations! Your name is now " + CharacterName +". How old are you?");
            String CharacterAge = Console.ReadLine();

            int n;
            bool isNumeric = int.TryParse(CharacterAge, out n);


            if (isNumeric)
            {



                if (n < 5)
                {
                    Console.WriteLine("What an advanced baby you are!");
                    
                }
                else
                {
                    Console.WriteLine("got dang u old fam");
                    
                }
            }
            else
            {
                Console.WriteLine(" ");
                
            }

            //Console.Clear();
           
            Console.WriteLine("Alright... what's a noticeable feature of yours? ");
            
            Console.Read();
            String CharacterFeature = Console.ReadLine();
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
            }
            if (GenderMarker == "F")
            {
                GenderDescriptor = "woman";
                GenderPronoun = "her";
                GenderPronoun2 = "she";
                GenderPronoun3 = "was";
            }
            Console.Clear();
            Console.WriteLine("What month is your birthday?");            
            String BirthMonth = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("What day is your birthday? (ex: 'the 13th')");            
            String Date = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("What is something you love? (ex: 'really terrible movies')");            
            String Interest = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("What do you like to do in your spare time? (ex: 'program Computers')");           
            String Hobby = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("How good are you at it? (ex: 'pretty good', 'not so good' or 'terrible')");
            String HowGood = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Name something you love. (ex: 'paranormal lore')");
            String Fondness = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("What's your dream career? (ex: 'magician')");
            String Career = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("IIIII");
            String Word9 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("JJJJJ");
            String Word10 = Console.ReadLine();
            Console.Clear();

            Random rnd = new Random();
            int GameChoice = rnd.Next(5, 7);
            //int GameChoice = 6;

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
                Console.WriteLine(@"_____  _     ____      __   ___    __    __    ____      ___    __    __    ____ 
 | |  | |_| | |_      ( (` | |_)  / /\  / /`  | |_      | |_)  / /\  / /`  | |_  
 |_|  |_| | |_|__     _)_) |_|   /_/--\ \_\_, |_|__     |_| \ /_/--\ \_\_, |_|__ ");

                Console.WriteLine("Your name is " + CharacterName +". You're "+ CharacterAge +" years old, and you've been flying through space on this god-forsaken rock for as long as you can remember. ");
                Console.WriteLine("You don't remember how or why you ended up here in the first place, but you can't shake the nagging feeling in the back of your mind that it's some form of punishment. ");
                Console.WriteLine("thats all for the demo lol bye");

                Console.Read();
                GameChoice = 0;
            }
            while (GameChoice == 6)
            {
                
               
                
                Console.WriteLine("A young " + GenderDescriptor + " stands in " + GenderPronoun + " bedroom. It just so happens that today, " + Date + " of " + BirthMonth +", 2018, is this young " + GenderDescriptor + "'s birthday. Though it was " + CharacterAge + " years ago " + GenderPronoun2 + " was given life, it is only today " + GenderPronoun2 + " will be given a name!");
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
