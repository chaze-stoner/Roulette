using System;

namespace Roulette2
{
    class Program
    {
        static void Main(string[] args)
        {
            SplashScreen();

           string[] ars = Bins.Numbers();

            Player player = new Player();

            PlayerBet(ars, player);
 
        }

        /*************************************
         * Creates the Roulette board/wheel
         * so players know how to place there
         * bets.
         *************************************/
        public static void Display(string[] array, Player player)
        {
            Console.WriteLine($"\t {player.Name}\t\t\t                          ${player.Wallet}");
            Console.WriteLine("      _____________________________________________________________________");

            Row1(array);

            Row2(array);

            Row3(array);

            Console.WriteLine("     |__|________________________________________________________|________|");
            Console.WriteLine("\t|     1st 12     |\t 2nd 12\t     |\t     3rd 12      |");
            Console.WriteLine("\t|________________|___________________|___________________|");
            Console.Write("\t|1 to 18|  EVEN  |");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("   RED   ");
            Console.ResetColor();
            Console.Write("|  BLACK  |   ODD   | 19 to 38|");
            Console.WriteLine("\n\t|_______|________|_________|_________|_________|_________|");
        }


        /***********************************************
         * Used to create the first row in the Display() 
         * method.
         ***********************************************/
        public static void Row1(string[] array)
        {
            string i;
            
            Console.Write($"     |  |");
            
            i = array[4];
            Color(i);
            Console.Write($"|");
 
            i = array[7];
            Color(i);
            Console.Write($"|");

            i = array[10];
            Color(i);
            Console.Write($"|");

            i = array[13];
            Color(i);
            Console.Write($"|");

            i = array[16];
            Color(i);
            Console.Write($"|");

            i = array[19];
            Color(i);
            Console.Write($"|");

            i = array[22];
            Color(i);
            Console.Write($"|");

            i = array[25];
            Color(i);
            Console.Write($"|");

            i = array[28];
            Color(i);
            Console.Write($"|");

            i = array[31];
            Color(i);
            Console.Write($"|");

            i = array[34];
            Color(i);
            Console.Write($"|");

            i = array[37];
            Color(i);
            Console.Write($"|");

            Console.Write(" 2 to 1 |");

            i = array[1];
            Color(i);

            Console.WriteLine();

        }


        /***********************************************
         * Used to create the second row in the Display() 
         * method.
         ***********************************************/
        public static void Row2(string[] array)
        {
            string i;

            Console.Write($"     |  |");

            i = array[3];
            Color(i);
            Console.Write($"|");

            i = array[6];
            Color(i);
            Console.Write($"|");

            i = array[9];
            Color(i);
            Console.Write($"|");

            i = array[12];
            Color(i);
            Console.Write($"|");

            i = array[15];
            Color(i);
            Console.Write($"|");

            i = array[18];
            Color(i);
            Console.Write($"|");

            i = array[21];
            Color(i);
            Console.Write($"|");

            i = array[24];
            Color(i);
            Console.Write($"|");

            i = array[27];
            Color(i);
            Console.Write($"|");

            i = array[30];
            Color(i);
            Console.Write($"|");

            i = array[33];
            Color(i);
            Console.Write($"|");

            i = array[36];
            Color(i);
            Console.Write($"|");

            Console.Write(" 2 to 1 |");

            i = array[0];
            Color(i);

            Console.WriteLine();

        }


        /***********************************************
         * Used to create the third row in the Display() 
         * method.
         ***********************************************/
        public static void Row3(string[] array)
        {
            string i;

            Console.Write($"     |  |");

            i = array[2];
            Color(i);
            Console.Write($"|");

            i = array[5];
            Color(i);
            Console.Write($"|");

            i = array[8];
            Color(i);
            Console.Write($"|");

            i = array[11];
            Color(i);
            Console.Write($"|");

            i = array[14];
            Color(i);
            Console.Write($"|");

            i = array[17];
            Color(i);
            Console.Write($"|");

            i = array[20];
            Color(i);
            Console.Write($"|");

            i = array[23];
            Color(i);
            Console.Write($"|");

            i = array[26];
            Color(i);
            Console.Write($"|");

            i = array[29];
            Color(i);
            Console.Write($"|");

            i = array[32];
            Color(i);
            Console.Write($"|");

            i = array[35];
            Color(i);
            Console.Write($"|");

            Console.Write(" 2 to 1 |");

            Console.WriteLine();

        }


        /****************************************
         * Used to write to the screen, the color
         * of each number. This way the user has
         * a physical rep of what the board/wheel 
         * looks like.
         ****************************************/
        public static void Color(string s)
        {
            if (s == "0")
            {
                Console.WriteLine();
                Console.Write("     | ");
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write($"{s}");
                Console.ResetColor();
                Console.Write($"|________________________________________________________|________|");
                
            }
            if (s == "00")
            {
                Console.WriteLine();
                Console.Write("     |");
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write($"{s}");
                Console.ResetColor();
                Console.Write($"|________________________________________________________|________|");

            }
            if (s == "1" || s == "3" || s == "5" || s == "7" || s == "9" || s == "12" || s == "14" || s == "16" || s == "18" || s == "19" || s == "21" || s == "23" || s == "25" || s == "27" || s == "30" || s == "32" || s == "34" || s == "36") 
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Write($" {s} ");
                Console.ResetColor();
            }
            if (s == "2" || s == "4" || s == "6" || s == "8" || s == "10" || s == "11" || s == "13" || s == "15" || s == "17" || s == "20" || s == "22" || s == "24" || s == "26" || s == "28" || s == "29" || s == "31" || s == "33" || s == "35")
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write($" {s} ");
                Console.ResetColor();
            }
                 
        }

        /***********************************
         * Used to display an ascii art to 
         * the screen.  as well as extends the
         * console window width to account for 
         * the size of the art displayed.
         ***********************************/
        public static void SplashScreen()
        {
            Console.Title = "ROULETTE";

            Console.WindowWidth = 150;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine($"RRRRRRRRRRRRRRRRR                                      lllllll                              tttt               tttt");
            Console.WriteLine($"R::::::::::::::::R                                     l:::::l                           ttt:::t            ttt:::t");
            Console.WriteLine($"R::::::RRRRRR:::::R                                    l:::::l                           t:::::t            t:::::t");
            Console.WriteLine($"RR:::::R     R:::::R                                   l:::::l                           t:::::t            t:::::t");
            Console.WriteLine($"  R::::R     R:::::R    ooooooooooo  uuuuuu    uuuuuu   l::::l     eeeeeeeeeeee    ttttttt:::::tttttttttttttt:::::ttttttt       eeeeeeeeeeee");
            Console.WriteLine($"  R::::R     R:::::R oo:::::::::::oo u::::u    u::::u   l::::l   ee::::::::::::ee  t:::::::::::::::::tt:::::::::::::::::t     ee::::::::::::ee");
            Console.WriteLine($"  R::::RRRRRR:::::R o:::::::::::::::ou::::u    u::::u   l::::l  e::::::eeeee:::::eet:::::::::::::::::tt:::::::::::::::::t    e::::::eeeee:::::ee");
            Console.WriteLine($"  R:::::::::::::RR  o:::::ooooo:::::ou::::u    u::::u   l::::l e::::::e     e:::::etttttt:::::::tttttttttttt:::::::tttttt   e::::::e     e:::::e");
            Console.WriteLine($"  R::::RRRRRR:::::R o::::o     o::::ou::::u    u::::u   l::::l e:::::::eeeee::::::e      t:::::t           t:::::t          e:::::::eeeee::::::e");
            Console.WriteLine($"  R::::R     R:::::Ro::::o     o::::ou::::u    u::::u   l::::l e:::::::::::::::::e       t:::::t           t:::::t          e:::::::::::::::::e");
            Console.WriteLine($"  R::::R     R:::::Ro::::o     o::::ou::::u    u::::u   l::::l e::::::eeeeeeeeeee        t:::::t           t:::::t          e::::::eeeeeeeeeee");
            Console.WriteLine($"  R::::R     R:::::Ro::::o     o::::ou:::::uuuu:::::u   l::::l e:::::::e                 t:::::t    tttttt t:::::t    tttttte:::::::e");
            Console.WriteLine($"RR:::::R     R:::::Ro:::::ooooo:::::ou:::::::::::::::uul::::::le::::::::e                t::::::tttt:::::t t::::::tttt:::::te::::::::e");
            Console.WriteLine($"R::::::R     R:::::Ro:::::::::::::::o u:::::::::::::::ul::::::l e::::::::eeeeeeee        tt::::::::::::::t tt::::::::::::::t e::::::::eeeeeeee");
            Console.WriteLine($"R::::::R     R:::::R oo:::::::::::oo   uu::::::::uu:::ul::::::l  ee:::::::::::::e          tt:::::::::::tt    tt:::::::::::tt ee:::::::::::::e");
            Console.WriteLine($"RRRRRRRR     RRRRRRR   ooooooooooo       uuuuuuuu  uuuullllllll    eeeeeeeeeeeeee           ttttttttttt         ttttttttttt     eeeeeeeeeeeeee");

            Console.ResetColor();

            Console.WriteLine("\nPress ENTER to continue");
            Console.ReadLine();

            Console.Clear();
        }


        /***********************************
         * Used to get the users bet option.
         ***********************************/
        public static void PlayerBet(string[] array, Player player)
        {
            Console.Clear();

            if (player.Wallet == 0) 
            {
                Console.WriteLine($"Thank you {player.Name} for playing my Roulette game, I hope you enjoyed. :D");
                Environment.Exit(1);
            }

            string[,] ar = Bins.BallNumber();

            Display(array, player);

            Console.WriteLine();

            Console.WriteLine("Please choose the bet you want to make");
            Console.WriteLine(" 1) Numbers");
            Console.WriteLine(" 2) Evens or Odds");
            Console.WriteLine(" 3) Reds or Blacks");
            Console.WriteLine(" 4) Low or High");
            Console.WriteLine(" 5) Dozens");
            Console.WriteLine(" 6) Columns");
            Console.WriteLine(" 7) Streets");
            Console.WriteLine(" 8) 6 Numbers");
            Console.WriteLine(" 9) Split");
            Console.WriteLine("10) Corner");
            Console.WriteLine("");

            string input = Console.ReadLine();

            switch (input)
            {
                case "": { PlayerBet(array, player); break; }
                case "1": { Number(ar, array, input, player); break; }
                case "2": { EvenOdd(ar, array, input, player); break; }
                case "3": { RedBlack(ar, array, input, player);  break; }
                case "4": { LowHigh(ar, array, input, player); break; }
                case "5": { Dozen(ar, array, input, player); break; }
                case "6": { Columns(ar, array, input, player); break; }
                case "7": { Streets(ar, array, input, player); break; }
                case "8": { SixNumbers(ar, array, input, player); break; }
                case "9": { Split(ar, array, input, player); break; }
                case "10": { Corner(ar, array, input, player); break; }
                default:
                    PlayerBet(array, player);
                    break;
            }

        }


        /***************************************
         * Used to store the players number for 
         * comparison later in the program.
         ***************************************/
        public static string PlayerNumber(string[] array, string input, Player player)
        {
            Console.Clear();

            Display(array, player);

            string s;
            switch (input)
            {
                case "1": { s = NumberBets(); return s; }
                case "2": { s = EvenOddBets(); return s; }
                case "3": { s = RedBlackBets(); return s; }
                case "4": { s = LowHighBets(); return s; }
                case "5": { s = DozenBets(); return s; }
                case "6": { s = ColumnBets(); return s; }
                case "7": { s = StreetBets(); return s; }
                case "8": { s = SixNumberBets(); return s; }
                case "9": { s = SplitBets(); return s;}
                case "10": { s = CornerBets(); return s; }
                
                default:
                    PlayerNumber(array, input, player);
                    break;
            }
            return null;
        }


        /**********************************************
         * Used to display to the user if they guessed
         * the number the ball would land on. 
         **********************************************/
        public static void Number(string[,] ar, string[] array, string input, Player player)
        {
            int wager = Player.PlaceBet(player);
            string s = PlayerNumber(array, input, player);
           
            Console.Clear();

            Display(array, player);

            Console.WriteLine();

            for (int i = 0; i < ar.GetLength(0); i++)
            {
                if (ar[i, 0] == s)
                {
                    int winnings = Player.ThirtyFiveToOne(player, wager);
                    Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                    $" you won ${winnings}");
                }
                else Console.WriteLine($"The ball lands on {ar[0,1]}, {ar[0,0]}" +
                    $" you lost ${wager}");
            }

            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();

            PlayerBet(array, player);
        }

        public static void EvenOdd(string[,] ar, string[] array, string input, Player player)
        {
            int wager = Player.PlaceBet(player);

            string[,] sorted = Bins.SortedArray();

            string s = PlayerNumber(array, input, player);

            Console.Clear();

            Display(array, player);

            Console.WriteLine();

            for (int i = 2, j = 3; i < array.GetLength(0); i +=2, j += 2)
            {
                for (int k = 0; k < ar.GetLength(0); k++)
                {
                    
                    if (s == "even" && ar[k,0] == sorted[i,0])
                    {
                        int winnings = Player.OneToOne(player, wager);
                        Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you won ${winnings}");
                        break;
                    }
                    if (s == "even" && ar[k, 0] == sorted[j, 0])
                    {
                        Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you lost ${wager}");
                        break;
                    }
                    if (s == "odd" && ar[k, 0] == sorted[j, 0])
                    {
                        int winnings = Player.OneToOne(player, wager);
                        Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you won ${winnings}");
                        break;
                    }
                    if (s == "odd" && ar[k, 0] == sorted[i, 0])
                    {
                        Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you lost ${wager}");
                        break;
                    }
                }
            }

            if (ar[0, 0] == "0" || ar[0, 0] == "00")
            {
                Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                $" you lost {wager} amount of money");
            }

            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();

            PlayerBet(array, player);
        }

        public static void RedBlack(string[,] ar, string[] array, string input, Player player)
        {
            int wager = Player.PlaceBet(player);

            string s = PlayerNumber(array, input, player);

            Console.Clear();

            Display(array, player);

            Console.WriteLine();

            if (s == "black" && ar[0, 1] == "Black")
            {
                int winnings = Player.OneToOne(player, wager);
                Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                $" you won ${winnings}");
            }
            if (s == "black" && ar[0, 1] == "Red")
            {
                Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                $" you lost ${wager}");
            }
            if (s == "red" && ar[0, 1] == "Red")
            {
                int winnings = Player.OneToOne(player, wager);
                Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                $" you won ${winnings}");
            }
            if (s == "red" && ar[0, 1] == "Black")
            {
                Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                $" you lost ${wager}");
            }
            if (ar[0, 0] == "0" || ar[0, 0] == "00")
            {
                Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                $" you lost ${wager}");
            }

            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();

            PlayerBet(array, player);
        }

        public static void LowHigh(string[,] ar, string[] array, string input, Player player)
        {
            int wager = Player.PlaceBet(player);

            string[,] sorted = Bins.SortedArray();

            string s = PlayerNumber(array, input, player);

            Console.Clear();

            Display(array, player);

            Console.WriteLine();

            for (int i = 2, j = 19; i < array.GetLength(0)/2; i++, j++)
            {
                for (int k = 0; k < ar.GetLength(0); k++)
                {

                    if (s == "low" && ar[k, 0] == sorted[i, 0])
                    {
                        int winnings = Player.OneToOne(player, wager);
                        Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you won ${winnings}");
                        break;
                    }
                    if (s == "low" && ar[k, 0] == sorted[j, 0])
                    {
                        Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you lost ${wager}");
                        break;
                    }
                    if (s == "high" && ar[k, 0] == sorted[j, 0])
                    {
                        int winnings = Player.OneToOne(player, wager);
                        Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you won ${winnings}");
                        break;
                    }
                    if (s == "high" && ar[k, 0] == sorted[i, 0])
                    {
                        Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you lost ${wager}");
                        break;
                    }  
                }
            }

            if (ar[0, 0] == "0" || ar[0, 0] == "00")
            {
                Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                $" you lost ${wager}");
            }

            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();

            PlayerBet(array, player);
        }

        public static void Dozen(string[,] ar, string[] array, string input, Player player)
        {
            int wager = Player.PlaceBet(player);

            string[,] sorted = Bins.SortedArray();

            string s = PlayerNumber(array, input, player);

            Console.Clear();

            Display(array, player);

            Console.WriteLine();
            
            for (int i = 2, j = 14, k = 26; i < array.GetLength(0)/3; i++, j++, k++)
            {
                for (int l = 0; l < ar.GetLength(0); l++)
                {

                    if (s == "1-12" && ar[l, 0] == sorted[i, 0])
                    {
                        int winnings = Player.TwoToOne(player, wager);
                        Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you won ${winnings}");
                        break;
                    }
                    if (s == "1-12" && ar[l, 0] == sorted[j, 0])
                    {
                        Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you lost ${wager}");
                        break;
                    }
                    if (s == "1-12" && ar[l, 0] == sorted[k, 0])
                    {
                        Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you lost ${wager}");
                        break;
                    }
                    if (s == "13-24" && ar[l, 0] == sorted[j, 0])
                    {
                        int winnings = Player.TwoToOne(player, wager);
                        Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you won ${winnings}");
                        break;
                    }
                    if (s == "13-24" && ar[l, 0] == sorted[i, 0])
                    {
                        Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you lost ${wager}");
                        break;
                    }
                    if (s == "13-24" && ar[l, 0] == sorted[k, 0])
                    {
                        Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you lost ${wager}");
                        break;
                    }
                    if (s == "25-36" && ar[l, 0] == sorted[k, 0])
                    {
                        int winnings = Player.TwoToOne(player, wager);
                        Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you won ${winnings}");
                        break;
                    }
                    if (s == "25-36" && ar[l, 0] == sorted[i, 0])
                    {
                        Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you lost ${wager}");
                        break;
                    }
                    if (s == "25-36" && ar[l, 0] == sorted[j, 0])
                    {
                        Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you lost ${wager}");
                        break;
                    }
                }
            }

            if (ar[0, 0] == "0" || ar[0, 0] == "00")
            {
                Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                $" you lost ${wager}");
            }

            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();

            PlayerBet(array, player);
        }

        public static void Columns(string[,] ar, string[] array, string input, Player player)
        {
            int wager = Player.PlaceBet(player);

            string[,] sorted = Bins.SortedArray();

            string s = PlayerNumber(array, input, player);

            Console.Clear();

            Display(array, player);

            Console.WriteLine();

            for (int i = 2, j = 3, k = 4; i < array.GetLength(0); i+=3, j+=3, k+=3)
            {
                for (int l = 0; l < ar.GetLength(0); l++)
                {

                    if (s == "bot" && ar[l, 0] == sorted[i, 0])
                    {
                        int winnings = Player.TwoToOne(player, wager);
                        Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you won ${winnings}");
                        break;
                    }
                    if (s == "bot" && ar[l, 0] == sorted[j, 0])
                    {
                        Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you lost ${wager}");
                        break;
                    }
                    if (s == "bot" && ar[l, 0] == sorted[k, 0])
                    {
                        Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you lost ${wager}");
                        break;
                    }
                    if (s == "mid" && ar[l, 0] == sorted[j, 0])
                    {
                        int winnings = Player.TwoToOne(player, wager);
                        Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you won ${winnings}");
                        break;
                    }
                    if (s == "mid" && ar[l, 0] == sorted[i, 0])
                    {
                        Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you lost ${wager}");
                        break;
                    }
                    if (s == "mid" && ar[l, 0] == sorted[k, 0])
                    {
                        Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you lost ${wager}");
                        break;
                    }
                    if (s == "top" && ar[l, 0] == sorted[k, 0])
                    {
                        int winnings = Player.TwoToOne(player, wager);
                        Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you won ${winnings}");
                        break;
                    }
                    if (s == "top" && ar[l, 0] == sorted[i, 0])
                    {
                        Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you lost ${wager}");
                        break;
                    }
                    if (s == "top" && ar[l, 0] == sorted[j, 0])
                    {
                        Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you lost ${wager}");
                        break;
                    }
                }
            }

            if (ar[0, 0] == "0" || ar[0, 0] == "00")
            {
                Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                $" you lost ${wager}");
            }

            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();

            PlayerBet(array, player);
        }

        public static void Streets(string[,] ar, string[] array, string input, Player player)
        {
            int wager = Player.PlaceBet(player);

            string[,] sorted = Bins.SortedArray();

            string s = PlayerNumber(array, input, player);

            Console.Clear();

            Display(array, player);

            Console.WriteLine();

            for (int i = 2; i < array.GetLength(0); i += 3)
            {
                string temp = sorted[i, 0] + sorted[i + 1, 0] + sorted[i + 2, 0];
                if (s == temp) 
                {
                    if (ar[0, 0] == sorted[i, 0] || ar[0, 0] == sorted[i + 1, 0] || ar[0, 0] == sorted[i + 2, 0])
                    {
                        int winnings = Player.ElevenToOne(player, wager);
                        Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you won ${winnings}");
                        break;
                    }
                    if (ar[0, 0] == "0" || ar[0, 0] == "00")
                    {
                        Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you lost ${wager}");
                        break;
                    }
                    else Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you lost ${wager}");
                }
            }

            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();

            PlayerBet(array, player);
        }

        public static void SixNumbers(string[,] ar, string[] array, string input, Player player)
        {
            int wager = Player.PlaceBet(player);

            string[,] sorted = Bins.SortedArray();

            string s = PlayerNumber(array, input, player);

            Console.Clear();

            Display(array, player);

            Console.WriteLine();

            for (int i = 2; i < array.GetLength(0); i += 6)
            {
                string temp = sorted[i, 0] + sorted[i + 1, 0] + sorted[i + 2, 0] + sorted[i + 3, 0] + sorted[i + 4, 0] + sorted[i + 5, 0];
                if (s == temp)
                {
                    if (ar[0, 0] == sorted[i, 0] || ar[0, 0] == sorted[i + 1, 0] || ar[0, 0] == sorted[i + 2, 0] || ar[0, 0] == sorted[i+3, 0] || ar[0, 0] == sorted[i + 4, 0] || ar[0, 0] == sorted[i + 5, 0])
                    {
                        int winnings = Player.TwoToOne(player, wager);
                        Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you won ${winnings}");
                        break;
                    }
                    if (ar[0, 0] == "0" || ar[0, 0] == "00")
                    {
                        Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you lost ${wager}");
                        break;
                    }
                    else Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you lost ${wager}");
                }
            }

            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();

            PlayerBet(array, player);
        }

        public static void Split(string[,] ar, string[] array, string input, Player player)
        {
            int wager = Player.PlaceBet(player);

            string[,] sorted = Bins.SortedArray();

            string s = PlayerNumber(array, input, player);

            Console.Clear();

            Display(array, player);

            Console.WriteLine();

            if (s.Contains(ar[0, 0]))
            {
                int winnings = Player.TwoToOne(player, wager);
                Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                $" you won ${winnings}");

            }
            if (ar[0, 0] == "0" || ar[0, 0] == "00")
            {
                Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                $" you lost ${wager}");
            }
            else Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                $" you lost ${wager}");


            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();

            PlayerBet(array, player);
        }

        public static void Corner(string[,] ar, string[] array, string input, Player player)
        {
            int wager = Player.PlaceBet(player);

            string[,] sorted = Bins.SortedArray();

            string s = PlayerNumber(array, input, player);

            Console.Clear();

            Display(array, player);

            Console.WriteLine();

            for (int i = 5, j = 6, k = 7; i < array.GetLength(0)/3; i+=3,j += 3,k += 3)
            {
                if (s == sorted[i, 0])
                {
                    if (ar[0, 0] == sorted[i, 0] || ar[0, 0] == sorted[i - 3, 0] || ar[0, 0] == sorted[i - 2, 0] || ar[0, 0] == sorted[i + 1, 0] || ar[0, 0] == sorted[i + 3, 0] || ar[0, 0] == sorted[i + 4, 0])
                    {
                        int winnings = Player.EightToOne(player, wager);
                        Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you won ${winnings}");
                        break;
                    }
                    else Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you lost ${wager}");
                }
                if (s == sorted[j, 0])
                {
                    if (ar[0, 0] == sorted[j, 0] || ar[0, 0] == sorted[j - 1, 0] || ar[0, 0] == sorted[j - 2, 0] || ar[0, 0] == sorted[j - 3, 0] || ar[0, 0] == sorted[j - 4, 0] || ar[0, 0] == sorted[j + 1, 0] || ar[0, 0] == sorted[j + 2, 0] || ar[0, 0] == sorted[j + 3, 0] || ar[0, 0] == sorted[j + 4, 0])
                    {
                        int winnings = Player.EightToOne(player, wager);
                        Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you won ${winnings}");
                        break;
                    }
                    else Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you lost ${wager}");
                }
                if (s == sorted[k, 0])
                {
                    if (ar[0, 0] == sorted[k, 0] || ar[0, 0] == sorted[k - 1, 0] || ar[0, 0] == sorted[k - 3, 0] || ar[0, 0] == sorted[k - 4, 0] || ar[0, 0] == sorted[k + 2, 0] || ar[0, 0] == sorted[k + 3, 0])
                    {
                        int winnings = Player.EightToOne(player, wager);
                        Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you won ${winnings}");
                        break;
                    }
                    else Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you lost ${wager}");
                }
                if (s == "1")
                {
                    if (ar[0, 0] == "1" || ar[0, 0] == "2"|| ar[0, 0] == "4" || ar[0, 0] == "5")
                    {
                        int winnings = Player.EightToOne(player, wager);
                        Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you won ${winnings}");
                        break;
                    }
                    else Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you lost ${wager}");
                }
                if (s == "2")
                {
                    if (ar[0, 0] == "1" || ar[0, 0] == "2" || ar[0, 0] == "3" || ar[0, 0] == "4" || ar[0, 0] == "5" || ar[0, 0] == "6")
                    {
                        int winnings = Player.EightToOne(player, wager);
                        Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you won ${winnings}");
                        break;
                    }
                    else Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you lost ${wager}");
                }
                if (s == "3")
                {
                    if (ar[0, 0] == "2" || ar[0, 0] == "3" || ar[0, 0] == "5" || ar[0, 0] == "6")
                    {
                        int winnings = Player.EightToOne(player, wager);
                        Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you won ${winnings}");
                        break;
                    }
                    else Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you lost ${wager}");
                }
                if (s == "34")
                {
                    if (ar[0, 0] == "31" || ar[0, 0] == "32" || ar[0, 0] == "34" || ar[0, 0] == "35")
                    {
                        int winnings = Player.EightToOne(player, wager);
                        Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you won ${winnings}");
                        break;
                    }
                    else Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you lost ${wager}");
                }
                if (s == "35")
                {
                    if (ar[0, 0] == "31" || ar[0, 0] == "32" || ar[0, 0] == "33" || ar[0, 0] == "34" || ar[0, 0] == "35" || ar[0, 0] == "36")
                    {
                        int winnings = Player.EightToOne(player, wager);
                        Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you won ${winnings}");
                        break;
                    }
                    else Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you lost ${wager}");
                }
                if (s == "36")
                {
                    if (ar[0, 0] == "32" || ar[0, 0] == "33" || ar[0, 0] == "35" || ar[0, 0] == "36")
                    {
                        int winnings = Player.EightToOne(player, wager);
                        Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you won ${winnings}");
                        break;
                    }
                    else Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                        $" you lost ${wager}");
                }
                if (ar[0, 0] == "0" || ar[0, 0] == "00")
                {
                    Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                    $" you lost ${wager}");
                    break;
                }
                else Console.WriteLine($"The ball lands on {ar[0, 1]}, {ar[0, 0]}" +
                    $" you lost ${wager}");

            }

            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();

            PlayerBet(array, player);
        }

        public static string NumberBets()
        {
            string[] num = Bins.Numbers();
            Console.WriteLine();
            Console.WriteLine("Input a number from 1 - 36 or 0 or 00 for your bet.");
            string s = Console.ReadLine();

            if (s == "" || s == null)
            {
                Console.WriteLine("Please input a number for your bet.");
                Console.WriteLine("Press ENTER to continue");
                Console.ReadLine();

                NumberBets();
            }

            string bing = "";
            for (int i = 0; i < num.Length; i++)
            {
                bing += num[i];
            }

            if (bing.Contains(s)) { return s; }
            else NumberBets();

            return null;
        }

        public static string EvenOddBets()
        {
            Console.WriteLine();
            Console.WriteLine("Select your bet.");
            Console.WriteLine();
            Console.WriteLine("1 = Odd");
            Console.WriteLine("2 = Even");
            string s = Console.ReadLine().ToLower();

            if (s == "" || s == null)
            {
                Console.WriteLine("Please input a number for your bet.");
                Console.WriteLine("Press ENTER to continue");
                Console.ReadLine();

                EvenOddBets();
            }
            if (s == "1") { s = "even"; return s; }
            if (s == "2") { s = "odd"; return s; }
            else EvenOddBets();
            return s;
        }

        public static string RedBlackBets()
        {
            Console.WriteLine();
            Console.WriteLine("Select your bet.");
            Console.WriteLine();
            Console.WriteLine("1 = Red");
            Console.WriteLine("2 = Black");
            string s = Console.ReadLine().ToLower();

            if (s == "" || s == null)
            {
                Console.WriteLine("Please input a number for your bet.");
                Console.WriteLine("Press ENTER to continue");
                Console.ReadLine();

                RedBlackBets();
            }
            if (s == "1") { s = "red"; return s; }
            if (s == "2") { s = "black"; return s; }
            else RedBlackBets();
            return null;
        }

        public static string LowHighBets()
        {
            Console.WriteLine();
            Console.WriteLine("Select your bet.");
            Console.WriteLine();
            Console.WriteLine("1 = Low");
            Console.WriteLine("2 = High");
            string s = Console.ReadLine().ToLower();

            if (s == "" || s == null)
            {
                Console.WriteLine("Please input a number for your bet.");
                Console.WriteLine("Press ENTER to continue");
                Console.ReadLine();

                LowHighBets();
            }
            if (s == "1") { s = "low"; return s; }
            if (s == "2") { s = "high"; return s; }
            else LowHighBets();
            return null;
        }

        public static string DozenBets()
        {
            Console.WriteLine();
            Console.WriteLine("Select your bet.");
            Console.WriteLine();
            Console.WriteLine("1 =  1 - 12");
            Console.WriteLine("2 = 13 - 24");
            Console.WriteLine("3 = 25 - 36");
            string s = Console.ReadLine().ToLower();

            if (s == "" || s == null)
            {
                Console.WriteLine("Please input a number for your bet.");
                Console.WriteLine("Press ENTER to continue");
                Console.ReadLine();

                LowHighBets();
            }
            if (s == "1") { s = "1-12"; return s; }
            if (s == "2") { s = "13-24"; return s; }
            if (s == "3") { s = "25-36"; return s; }
            else LowHighBets();
            return null;
        }

        public static string ColumnBets()
        {
            Console.WriteLine();
            Console.WriteLine("Select your bet.");
            Console.WriteLine();
            Console.WriteLine("1 = Top Column");
            Console.WriteLine("2 = Middle Column");
            Console.WriteLine("3 = Bottom Column");
            string s = Console.ReadLine().ToLower();

            if (s == "" || s == null)
            {
                Console.WriteLine("Please input a number for your bet.");
                Console.WriteLine("Press ENTER to continue");
                Console.ReadLine();

                ColumnBets();
            }
            if (s == "1") { s = "top"; return s; }
            if (s == "2") { s = "mid"; return s; }
            if (s == "3") { s = "bot"; return s; }
            else ColumnBets();
            return null;
        }

        public static string StreetBets()
        {
            Console.WriteLine();
            Console.WriteLine("Select your bet.");
            Console.WriteLine();
            Console.WriteLine(" 1 = Row  1 (1, 2, 3)");
            Console.WriteLine(" 2 = Row  2 (4, 5, 6)");
            Console.WriteLine(" 3 = Row  3 (7, 8, 9)");
            Console.WriteLine(" 4 = Row  4 (10, 11, 12)");
            Console.WriteLine(" 5 = Row  5 (13, 14, 15)");
            Console.WriteLine(" 6 = Row  6 (16, 17, 18)");
            Console.WriteLine(" 7 = Row  7 (19, 20, 21)");
            Console.WriteLine(" 8 = Row  8 (22, 23, 24)");
            Console.WriteLine(" 9 = Row  9 (25, 26, 27)");
            Console.WriteLine("10 = Row 10 (28, 29, 30)");
            Console.WriteLine("11 = Row 11 (31, 32, 33)");
            Console.WriteLine("12 = Row 12 (34, 35, 36)");
            string s = Console.ReadLine().ToLower();

            if (s == "" || s == null)
            {
                Console.WriteLine("Please input a number for your bet.");
                Console.WriteLine("Press ENTER to continue");
                Console.ReadLine();

                StreetBets();
            }
            if (s == "1") { s = "123"; return s; }
            if (s == "2") { s = "456"; return s; }
            if (s == "3") { s = "789"; return s; }
            if (s == "4") { s = "101112"; return s; }
            if (s == "5") { s = "131415"; return s; }
            if (s == "6") { s = "161718"; return s; }
            if (s == "7") { s = "192021"; return s; }
            if (s == "8") { s = "222324"; return s; }
            if (s == "9") { s = "252627"; return s; }
            if (s == "10") { s = "282930"; return s; }
            if (s == "11") { s = "313233"; return s; }
            if (s == "12") { s = "343536"; return s; }
            else StreetBets();
            return null;
        }

        public static string SixNumberBets()
        {
            Console.WriteLine();
            Console.WriteLine("Select your bet.");
            Console.WriteLine();
            Console.WriteLine(" 1 = (1, 2, 3, 4, 5, 6)");
            Console.WriteLine(" 2 = Row  2 (7, 8, 9, 10, 11, 12)");
            Console.WriteLine(" 3 = Row  3 (13, 14, 15, 16, 17, 18)");
            Console.WriteLine(" 4 = Row  4 (19, 20, 21, 22, 23, 24)");
            Console.WriteLine(" 5 = Row  5 (25, 26, 27, 28, 29, 30)");
            Console.WriteLine(" 6 = Row  6 (31, 32, 33, 34, 35, 36)");

            string s = Console.ReadLine().ToLower();

            if (s == "" || s == null)
            {
                Console.WriteLine("Please input a number for your bet.");
                Console.WriteLine("Press ENTER to continue");
                Console.ReadLine();

                SixNumberBets();
            }
            if (s == "1") { s = "123456"; return s; }
            if (s == "2") { s = "789101112"; return s; }
            if (s == "3") { s = "131415161718"; return s; }
            if (s == "4") { s = "192021222324"; return s; }
            if (s == "5") { s = "252627282930"; return s; }
            if (s == "6") { s = "313233343536"; return s; }
            else SixNumberBets();
            return null;
        }

        public static string SplitBets()
        {
            Console.WriteLine();
            Console.WriteLine("Input two numbers from 1 - 36  for your bet.");
            Console.WriteLine("IE. 1,2 or 10, 13");
            string s = Console.ReadLine();

            if (s == "" || s == null)
            {
                Console.WriteLine("Please input a number for your bet.");
                Console.WriteLine("Press ENTER to continue");
                Console.ReadLine();

                SplitBets();
            }

            return s;
        }

        public static string CornerBets()
        {
            string[] num = Bins.Numbers();
            Console.WriteLine();
            Console.WriteLine("Input a number from 1 - 36 for your bet.");
            string s = Console.ReadLine();

            if (s == "" || s == null)
            {
                Console.WriteLine("Please input a number for your bet.");
                Console.WriteLine("Press ENTER to continue");
                Console.ReadLine();

                CornerBets();
            }

            string bing = "";
            for (int i = 0; i < num.Length; i++)
            {
                bing += num[i];
            }

            if (bing.Contains(s)) { return s; }
            else CornerBets();

            return null;
        }

    }
}
