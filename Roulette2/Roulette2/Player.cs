using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette2
{
    class Player
    {
        public string Name { get; private set; }
        public int Wallet { get; private set; }
        public Player()
        {
            Name = "Pin Head Larry";
            Wallet = 1000;
        }

        public static int PlaceBet(Player player)
        {
            Console.WriteLine("How much would you like to Bet?");
            int wager = Convert.ToInt32(Console.ReadLine());
            if (wager > player.Wallet) 
            { 
                Console.WriteLine("You do not have enough money."); 
                Console.WriteLine("Press ENTER to continue"); 
                PlaceBet(player); 
            }
            if (wager == 0) 
            {
                Console.WriteLine("Please input an amount.");
                Console.WriteLine("Press ENTER to continue");
                PlaceBet(player);
            }
            player.Wallet -= wager;
            return wager;
        }

        public static int OneToOne(Player player, int wager)
        {
            int winnings = wager + wager;
            player.Wallet += winnings;
            return winnings;
        }

        public static int TwoToOne(Player player, int wager)
        {
            int winnings = wager * 3;
            player.Wallet += winnings;
            return winnings;
        }

        public static int EightToOne(Player player, int wager)
        {
            int winnings = wager * 9;
            player.Wallet += winnings;
            return winnings;
        }

        public static int FiveToOne(Player player, int wager)
        {
            int winnings = wager * 6;
            player.Wallet += winnings;
            return winnings;
        }

        public static int ElevenToOne(Player player, int wager)
        {
            int winnings = wager * 12;
            player.Wallet += winnings;
            return winnings;
        }

        public static int SeventeenToOne(Player player, int wager)
        {
            int winnings = wager * 18;
            player.Wallet += winnings;
            return winnings;
        }

        public static int ThirtyFiveToOne(Player player, int wager)
        {
            int winnings = wager * 36;
            player.Wallet += winnings;
            return winnings;
        }

    }
}
