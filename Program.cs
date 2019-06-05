using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JacksOrBetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Hand hand = new Hand();
            Game game = new Game(hand,deck);
            int play = 1;

            introduction();
            while (play!=2)
            {
                deck.populateDeck();//populates the deck
                hand.populateHand(deck);//populates the hand
                game.gameLoop();// main game loop
                Console.WriteLine("Do you wish to play again?");
                Console.WriteLine("1.Yes");
                Console.WriteLine("2.No");
                play = playOrContinue();
            }
            

        }
        static int playOrContinue()//check if player wants to play again
        {
            ConsoleKeyInfo input;
            do
            {
                input = Console.ReadKey(true);
            } while (
            input.Key != ConsoleKey.NumPad1 &&
            input.Key != ConsoleKey.NumPad2 &&
            input.Key != ConsoleKey.D1 &&
            input.Key != ConsoleKey.D2);
            if(input.Key == ConsoleKey.NumPad1 ||
            input.Key == ConsoleKey.D1) { return 1; }
            else { return 2; }
        }
        static void introduction() {
            Console.WriteLine("Welcome to Jacks or Better");
            Console.WriteLine("Select the cards you want to discard by pressing the number keys on your keyboard");
            Console.WriteLine("When you finish selecting press ENTER\n Press any Key to play");
            Console.ReadKey(true);
        }
        

        }
    }
