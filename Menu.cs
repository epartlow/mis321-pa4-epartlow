namespace pa4_epartlow
{
    public class Menu
    {
        public static int Start()
        {
            System.Console.WriteLine("Welcome to the Battle of Calypso's Maelstrom!");
            DisplayArt();
            Thread.Sleep(3000);
            System.Console.WriteLine("Select: \n1. To play game. \n2. To exit."); 
            return int.Parse(Console.ReadLine());
        }
        public static bool DetermineFirstPlayer()
        {
                System.Console.WriteLine("You will now roll dice to determine who attacks first. Whoever rolls the highest will go first. If you tie, you will roll again. ");
                int oneRoll = RollDie();
                System.Console.WriteLine($"Player 1's roll is a {oneRoll}");
                int twoRoll = RollDie();
                System.Console.WriteLine($"Player 2's roll is a {twoRoll}");
                bool oneFirst = true;

                if(oneRoll > twoRoll)
                {
                    oneFirst = true;
                }
                else if(twoRoll > oneRoll)
                {
                    oneFirst = false;
                }
                else
                {
                    System.Console.WriteLine("You tied! You will both roll again!");
                    return DetermineFirstPlayer();
                }
            return oneFirst;
        }
        public static int RollDie()
        {
            Random random = new Random(); 
            int roll = random.Next(1, 7);

            string[] faces = new string[]
            {
                "---------\n|       |\n|   *   |\n|       |\n---------", 
                "---------\n| *     |\n|       |\n|     * |\n---------", 
                "---------\n| *     |\n|   *   |\n|     * |\n---------", 
                "---------\n| *   * |\n|       |\n| *   * |\n---------", 
                "---------\n| *   * |\n|   *   |\n| *   * |\n---------", 
                "---------\n| *   * |\n| *   * |\n| *   * |\n---------"
            };
            System.Console.WriteLine(faces[roll - 1]);
            return roll;
        }
        public static string PlayerOne()
        {
            System.Console.WriteLine("Enter player 1's name");
            return Console.ReadLine();
        }
        public static string PlayerTwo()
        {
            System.Console.WriteLine("Enter player 2's name");
            return Console.ReadLine();
        }
        public static int SelectCharacter1(string playerOneName)
        {
            System.Console.WriteLine($"\n{playerOneName}, select: \n1. To play as Jack Sparrow \n2. To play as Davey Jones \n3. To play as Will Turner \n4. To play as Elizabeth Swann");
            return int.Parse(Console.ReadLine());
        }
        public static int SelectCharacter2(string playerTwoName)
        {
            System.Console.WriteLine($"\n{playerTwoName}, select: \n1. To play as Jack Sparrow \n2. To play as Davey Jones \n3. To play as Will Turner \n4. To play as Elizabeth Swann");
            return int.Parse(Console.ReadLine());
        }
        public static void InvalidSelection()
        {
            System.Console.WriteLine("That is an invalid selection. Please try again. ");
        }
        public static void ExitSystem()
        {
            System.Console.WriteLine("You are now exiting the game. ");
        }
        public static void DisplayArt()
        {
            System.Console.WriteLine("   _                   _");
            System.Console.WriteLine(" _( )                 ( )_");
            System.Console.WriteLine("(_, |     __ __       | ,_)");
            System.Console.WriteLine(@"  \'\    /  ^  \    /'/");
            System.Console.WriteLine(@"   '\'\,/\      \,/'/'");
            System.Console.WriteLine(@"     '\| []   [] |/'");
            System.Console.WriteLine(@"       (_  /^\  _)");
            System.Console.WriteLine(@"         \  ~  /");
            System.Console.WriteLine(@"         /HHHHH\");
            System.Console.WriteLine(@"       /'/{^^^}\'\");
            System.Console.WriteLine(@"   _,/'/'  ^^^  '\'\,_");
            System.Console.WriteLine(@"  (_, |           | ,_)");
            System.Console.WriteLine(@"    (_)           (_)");
        }

    }
}