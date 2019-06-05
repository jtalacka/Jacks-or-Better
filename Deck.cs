using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JacksOrBetter
{
    class Deck:Hand
    {
       public Deck()
        {
            populateDeck();
        }
        public void populateDeck()// Populates the deck
        {
            clear();

            foreach (Suits suit in Enum.GetValues(typeof(Suits)))
            {
                foreach(Value value in Enum.GetValues(typeof(Value)))//loops through all the enums of Suits and Value and creates every possible card
                {
                    cards.Add(new Card(suit, value));// Adds created card to a list
                }

            }
            ShuffleDeck();
        }
        public void ShuffleDeck(){// Shuffles the deck

            List<Card> tempDect = cards;
            cards = new List<Card>();
            Random rnd = new Random();
            while (tempDect.Count != 0)
            {
                int random = rnd.Next(0, tempDect.Count - 1);//Creates a random number which every cycle the tempDect list decreases
                cards.Add(tempDect.ElementAt(random));//Adds randomly selected card to the list
                tempDect.RemoveAt(random);// removes the same card from the temporary list
            }
        }
        public Card getCard()
        {

            Card cardToGive = cards[0];// retrieves the first card from the deck
            cards.RemoveAt(0); // removes the said card from the deck
            return cardToGive;

        }



    }
}
