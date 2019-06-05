using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JacksOrBetter
{
    class Game
    {
        Hand hand;
        Deck deck;
        private int credits = 0;

        public Game(Hand hand, Deck deck)
        {
            this.hand = hand;
            this.deck = deck;
        }



        public void gameLoop()// the main loop of the game
        {
            informationDisplay();// displays the whole information
            int selection;
            List<int> cardsToChange = new List<int>();
            do
            {
                selection = userInput();// gets user input
                if (selection != 6)// 6 equals to ENTER 
                {
                    if (selection == -1)// -1 equals to ESC key
                    {
                        Console.WriteLine("You decided to exit");
                        break;
                    }
                    else
                    {

                        if (cardsToChange.Contains(selection - 1))// checks if the list already contains the selected card
                        {
                            hand.flip(selection - 1);
                            cardsToChange.Remove(selection - 1);// if it does it is unselected
                        }
                        else
                        {
                            hand.flip(selection - 1);//selects the card
                            cardsToChange.Add(selection - 1);//adds the card to a list
                        }
                    }
                }
                informationDisplay();//display information
            } while ((selection = userInput()) != 6);// loops while enter isn't pressed
            for (int i = 0; i < cardsToChange.Count; i++)//Loops selected cards
            {
                hand.changeCard(deck, cardsToChange.ElementAt(i));//Discards the cards and gets new ones
            }
            credits += hand.calculateCombination().prize;//adds prize to overall credits

            informationDisplay();// displays information
            endInformation();

        }
        public static int userInput()
        {
            int returnKey;
            ConsoleKeyInfo input;
            do
            {
                input = Console.ReadKey(true);//gets user input
            } while (
            input.Key != ConsoleKey.NumPad1 &&
            input.Key != ConsoleKey.NumPad2 &&
            input.Key != ConsoleKey.NumPad3 &&
            input.Key != ConsoleKey.NumPad4 &&
            input.Key != ConsoleKey.NumPad5 &&
            input.Key != ConsoleKey.D1 &&
            input.Key != ConsoleKey.D2 &&
            input.Key != ConsoleKey.D3 &&
            input.Key != ConsoleKey.D4 &&
            input.Key != ConsoleKey.D5 &&
            input.Key != ConsoleKey.Enter &&
            input.Key != ConsoleKey.Escape);
            if (input.Key == ConsoleKey.NumPad1 || input.Key == ConsoleKey.D1)
            {
                returnKey = 1;
            }
            else if (input.Key == ConsoleKey.NumPad2 || input.Key == ConsoleKey.D2)
            {
                returnKey = 2;
            }
            else if (input.Key == ConsoleKey.NumPad3 || input.Key == ConsoleKey.D3)
            {
                returnKey = 3;
            }
            else if (input.Key == ConsoleKey.NumPad4 || input.Key == ConsoleKey.D4)
            {
                returnKey = 4;
            }
            else if (input.Key == ConsoleKey.NumPad5 || input.Key == ConsoleKey.D5)
            {
                returnKey = 5;
            }
            else if (input.Key == ConsoleKey.Enter)
            {
                returnKey = 6;
            }
            else
            {
                returnKey = -1;// if escape is pressed
            }

            return returnKey;

        }

        public void informationDisplay()
        {
            Console.Clear();// clears the screen
            hand.display();
            Console.WriteLine("\n");
            Console.WriteLine(hand.calculateCombination().name + "   prize- " + hand.calculateCombination().prize);// shows the combitnation
            Console.WriteLine("\n");
            Console.WriteLine("Overall Player has won {0} credits", credits);

        }
        public void endInformation()
        {
            Console.WriteLine("\nYou won " + hand.calculateCombination().prize + " Credits\n");


        }
    }
}
